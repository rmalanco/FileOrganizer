Imports FileOrganizer.Common
Imports FileOrganizer.Domain
Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.IO

''' <summary>
''' Main form of the File Organizer application.
''' </summary>
Public Class MainForm

#Region "Variables"
    ''' <summary>
    ''' Indicates whether the default files have been loaded.
    ''' </summary>
    Private InitLlenadoArchivosDefault As Boolean = False

    ''' <summary>
    ''' FileSystemWatcher to monitor changes in the log file.
    ''' </summary>
    Private logWatcher As FileSystemWatcher
#End Region

#Region "Eventos"

    ''' <summary>
    ''' Handles the Load event of the MainForm control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarFormulario()
        ConfigurarLogWatcher()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnOrganizar control.
    ''' Organizes the files based on the selected options.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnOrganizar_Click(sender As Object, e As EventArgs) Handles btnOrganizar.Click
        If lstArchivosProcesados.Items.Count = 0 OrElse lstArchivosProcesados.Items(0).Text = "Selecciona una carpeta para procesar" Then
            MessageBox.Show("No hay archivos para procesar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Logger.Log("Iniciando proceso de organización")

        Dim archivos = lstArchivosProcesados.Items.Cast(Of ListViewItem)().Select(Function(item) item.Text).ToList()
        Dim opciones As New List(Of String)
        For Each item As Object In chkListOpcionesAvanzadas.Items
            If chkListOpcionesAvanzadas.GetItemCheckState(chkListOpcionesAvanzadas.Items.IndexOf(item)) = CheckState.Checked Then
                opciones.Add(item.ToString())
            End If
        Next
        Dim eliminarDuplicados = opciones.Contains("Eliminar duplicados")
        Dim totalArchivos = archivos.Count

        Logger.Log($"Total de archivos a procesar: {totalArchivos}")
        Logger.Log("Iniciando proceso de organización")

        pbProgreso.Value = 0
        pbProgreso.Maximum = 100

        For Each archivo In archivos
            OrganizerService.OrganizarArchivos(archivo, eliminarDuplicados)
            pbProgreso.Value = Math.Min(pbProgreso.Maximum, CInt((pbProgreso.Value + 1) / totalArchivos * 100))
        Next

        CargarLog()

        MessageBox.Show("Proceso finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Logger.Log("Proceso finalizado")

        lstArchivosProcesados.Items.Clear()
        LlenarArchivosDefault()
        ActualizarGrafico()
        btnLimpiar.PerformClick()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnBuscarCarpeta control.
    ''' Opens a folder browser dialog to select a folder to process.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnBuscarCarpeta_Click(sender As Object, e As EventArgs) Handles btnBuscarCarpeta.Click
        Using dialog As New FolderBrowserDialog()
            dialog.Description = "Selecciona la carpeta a procesar"
            dialog.RootFolder = Environment.SpecialFolder.MyComputer
            dialog.ShowNewFolderButton = False
            If dialog.ShowDialog() = DialogResult.OK Then
                Dim archivos = Directory.GetFiles(dialog.SelectedPath)
                txtCarpetaSeleccionada.Text = dialog.SelectedPath
                LlenadoDeArchivos(archivos)
            Else
                lstArchivosProcesados.Items.Clear()
                LlenarArchivosDefault()
                btnLimpiar.PerformClick()
            End If
        End Using
        ActualizarGrafico()
    End Sub

    ''' <summary>
    ''' Handles the Click event of the btnLimpiar control.
    ''' Clears the list of processed files and reloads the default files.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        InitLlenadoArchivosDefault = False
        lstArchivosProcesados.Items.Clear()
        LlenarArchivosDefault()
        CargarLog()
        txtCarpetaSeleccionada.Text = "Ruta de la carpeta..."
        ConfigurarGrafico()
    End Sub

    ''' <summary>
    ''' Handles the SelectedIndexChanged event of the tcPrincipal control.
    ''' Loads the log when the log tab is selected.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub tcPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcPrincipal.SelectedIndexChanged
        If tcPrincipal.SelectedIndex = 2 Then
            CargarLog()
        End If
    End Sub

    ''' <summary>
    ''' Handles the LinkClicked event of the LinkWebPageRMalanco control.
    ''' Opens the specified URL in the default web browser.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
    Private Sub LinkWebPageRMalanco_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkWebPageRMalanco.LinkClicked
        System.Diagnostics.Process.Start("https://www.rmalanco.com/")
    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Initializes the form by setting up the ListView, CheckList, and loading default files.
    ''' </summary>
    Private Sub InicializarFormulario()
        InitListView()
        InitCheckList()
        LlenarArchivosDefault()
        CargarLog()
    End Sub

    ''' <summary>
    ''' Initializes the ListView control for displaying processed files.
    ''' </summary>
    Private Sub InitListView()
        lstArchivosProcesados.View = View.Details
        lstArchivosProcesados.FullRowSelect = True
        lstArchivosProcesados.HeaderStyle = ColumnHeaderStyle.None
        lstArchivosProcesados.MultiSelect = False
        lstArchivosProcesados.Columns.Clear()
        lstArchivosProcesados.Columns.Add("Archivo", lstArchivosProcesados.Width - 5)
    End Sub

    ''' <summary>
    ''' Initializes the CheckList control with advanced options.
    ''' </summary>
    Private Sub InitCheckList()
        chkListOpcionesAvanzadas.Items.Clear()
        chkListOpcionesAvanzadas.Items.Add("Eliminar duplicados")
    End Sub

    ''' <summary>
    ''' Loads the default files into the ListView control.
    ''' </summary>
    Private Sub LlenarArchivosDefault()
        If Not InitLlenadoArchivosDefault Then
            Dim archivos = {"Selecciona una carpeta para procesar"}
            LlenadoDeArchivos(archivos)
            InitLlenadoArchivosDefault = True
        End If
    End Sub

    ''' <summary>
    ''' Fills the ListView control with the specified files.
    ''' </summary>
    ''' <param name="archivos">The array of file paths to add to the ListView.</param>
    Private Sub LlenadoDeArchivos(archivos() As String)
        lstArchivosProcesados.Items.Clear()
        Dim totalArchivos = archivos.Length
        For Each archivo In archivos
            lstArchivosProcesados.Items.Add(New ListViewItem(archivo))
        Next
        pbProgreso.Value = 0
    End Sub

    ''' <summary>
    ''' Loads the log content into the log text box.
    ''' </summary>
    Private Sub CargarLog()
        txtLog.Text = Logger.GetLog()
    End Sub

    ''' <summary>
    ''' Configures the FileSystemWatcher to monitor changes in the log file.
    ''' </summary>
    Private Sub ConfigurarLogWatcher()
        Dim logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log")

        If Not Directory.Exists(logPath) Then
            Directory.CreateDirectory(logPath)
        End If

        logWatcher = New FileSystemWatcher() With {
            .Path = logPath,
            .Filter = "log.txt",
            .NotifyFilter = NotifyFilters.LastWrite Or NotifyFilters.Size
        }

        AddHandler logWatcher.Changed, AddressOf LogActualizado
        logWatcher.EnableRaisingEvents = True
    End Sub

    ''' <summary>
    ''' Handles the Changed event of the logWatcher control.
    ''' Reloads the log content when the log file is updated.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="FileSystemEventArgs"/> instance containing the event data.</param>
    Private Sub LogActualizado(sender As Object, e As FileSystemEventArgs)
        If InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf CargarLog))
        Else
            CargarLog()
        End If
    End Sub

    ''' <summary>
    ''' Configures the chart control for displaying file distribution.
    ''' </summary>
    Private Sub ConfigurarGrafico()
        chartEspacio.Series = New SeriesCollection()
        chartEspacio.LegendLocation = LegendLocation.Right
    End Sub

    ''' <summary>
    ''' Updates the chart with the distribution of files in the selected folder.
    ''' </summary>
    Private Sub ActualizarGrafico()
        If String.IsNullOrEmpty(txtCarpetaSeleccionada.Text) OrElse Not Directory.Exists(txtCarpetaSeleccionada.Text) Then Exit Sub

        Dim messageError As String
        Dim datos = ReportService.CalcularDistribucionArchivos(txtCarpetaSeleccionada.Text, messageError)

        If Not String.IsNullOrEmpty(messageError) Then
            MessageBox.Show(messageError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLimpiar.PerformClick()
            Return
        End If

        chartEspacio.Series.Clear()
        Dim series = New SeriesCollection()
        For Each dato In datos
            series.Add(New PieSeries With {
                .Title = dato.Key,
                .Values = New ChartValues(Of Double)({dato.Value}),
                .DataLabels = True
            })
        Next
        chartEspacio.Series = series
    End Sub

#End Region

End Class