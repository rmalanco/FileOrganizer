<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tcPrincipal = New MaterialSkin.Controls.MaterialTabControl()
        Me.tpMain = New System.Windows.Forms.TabPage()
        Me.btnLimpiar = New MaterialSkin.Controls.MaterialButton()
        Me.lstArchivosProcesados = New System.Windows.Forms.ListView()
        Me.lbArchivos = New MaterialSkin.Controls.MaterialLabel()
        Me.chartEspacio = New LiveCharts.WinForms.PieChart()
        Me.chkListOpcionesAvanzadas = New MaterialSkin.Controls.MaterialCheckedListBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnOrganizar = New MaterialSkin.Controls.MaterialButton()
        Me.lblSeleccionarCarpeta = New MaterialSkin.Controls.MaterialLabel()
        Me.pbProgreso = New MaterialSkin.Controls.MaterialProgressBar()
        Me.btnBuscarCarpeta = New MaterialSkin.Controls.MaterialButton()
        Me.txtCarpetaSeleccionada = New MaterialSkin.Controls.MaterialTextBox()
        Me.tbAbout = New System.Windows.Forms.TabPage()
        Me.LinkWebPageRMalanco = New System.Windows.Forms.LinkLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.tbLog = New System.Windows.Forms.TabPage()
        Me.MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.tcPrincipal.SuspendLayout()
        Me.tpMain.SuspendLayout()
        Me.tbAbout.SuspendLayout()
        Me.tbLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcPrincipal
        '
        Me.tcPrincipal.Controls.Add(Me.tpMain)
        Me.tcPrincipal.Controls.Add(Me.tbAbout)
        Me.tcPrincipal.Controls.Add(Me.tbLog)
        Me.tcPrincipal.Depth = 0
        Me.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPrincipal.Location = New System.Drawing.Point(3, 64)
        Me.tcPrincipal.MouseState = MaterialSkin.MouseState.HOVER
        Me.tcPrincipal.Multiline = True
        Me.tcPrincipal.Name = "tcPrincipal"
        Me.tcPrincipal.SelectedIndex = 0
        Me.tcPrincipal.Size = New System.Drawing.Size(943, 533)
        Me.tcPrincipal.TabIndex = 0
        '
        'tpMain
        '
        Me.tpMain.Controls.Add(Me.btnLimpiar)
        Me.tpMain.Controls.Add(Me.lstArchivosProcesados)
        Me.tpMain.Controls.Add(Me.lbArchivos)
        Me.tpMain.Controls.Add(Me.chartEspacio)
        Me.tpMain.Controls.Add(Me.chkListOpcionesAvanzadas)
        Me.tpMain.Controls.Add(Me.MaterialLabel1)
        Me.tpMain.Controls.Add(Me.btnOrganizar)
        Me.tpMain.Controls.Add(Me.lblSeleccionarCarpeta)
        Me.tpMain.Controls.Add(Me.pbProgreso)
        Me.tpMain.Controls.Add(Me.btnBuscarCarpeta)
        Me.tpMain.Controls.Add(Me.txtCarpetaSeleccionada)
        Me.tpMain.Location = New System.Drawing.Point(4, 22)
        Me.tpMain.Name = "tpMain"
        Me.tpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMain.Size = New System.Drawing.Size(935, 507)
        Me.tpMain.TabIndex = 0
        Me.tpMain.Text = "Main"
        Me.tpMain.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.AutoSize = False
        Me.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLimpiar.Depth = 0
        Me.btnLimpiar.HighEmphasis = True
        Me.btnLimpiar.Icon = Nothing
        Me.btnLimpiar.Location = New System.Drawing.Point(629, 132)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLimpiar.Size = New System.Drawing.Size(299, 36)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar Listado Archivos"
        Me.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLimpiar.UseAccentColor = False
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lstArchivosProcesados
        '
        Me.lstArchivosProcesados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstArchivosProcesados.HideSelection = False
        Me.lstArchivosProcesados.Location = New System.Drawing.Point(6, 100)
        Me.lstArchivosProcesados.Name = "lstArchivosProcesados"
        Me.lstArchivosProcesados.Size = New System.Drawing.Size(614, 387)
        Me.lstArchivosProcesados.TabIndex = 11
        Me.lstArchivosProcesados.UseCompatibleStateImageBehavior = False
        '
        'lbArchivos
        '
        Me.lbArchivos.AutoSize = True
        Me.lbArchivos.Depth = 0
        Me.lbArchivos.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbArchivos.Location = New System.Drawing.Point(6, 78)
        Me.lbArchivos.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbArchivos.Name = "lbArchivos"
        Me.lbArchivos.Size = New System.Drawing.Size(66, 19)
        Me.lbArchivos.TabIndex = 10
        Me.lbArchivos.Text = "Archivos:"
        '
        'chartEspacio
        '
        Me.chartEspacio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartEspacio.Location = New System.Drawing.Point(626, 255)
        Me.chartEspacio.Name = "chartEspacio"
        Me.chartEspacio.Size = New System.Drawing.Size(302, 232)
        Me.chartEspacio.TabIndex = 5
        Me.chartEspacio.Text = "PieChart1"
        '
        'chkListOpcionesAvanzadas
        '
        Me.chkListOpcionesAvanzadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkListOpcionesAvanzadas.AutoScroll = True
        Me.chkListOpcionesAvanzadas.BackColor = System.Drawing.Color.Transparent
        Me.chkListOpcionesAvanzadas.Depth = 0
        Me.chkListOpcionesAvanzadas.Location = New System.Drawing.Point(626, 196)
        Me.chkListOpcionesAvanzadas.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkListOpcionesAvanzadas.Name = "chkListOpcionesAvanzadas"
        Me.chkListOpcionesAvanzadas.Size = New System.Drawing.Size(302, 53)
        Me.chkListOpcionesAvanzadas.Striped = False
        Me.chkListOpcionesAvanzadas.StripeDarkColor = System.Drawing.Color.Empty
        Me.chkListOpcionesAvanzadas.TabIndex = 9
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(626, 174)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(154, 19)
        Me.MaterialLabel1.TabIndex = 8
        Me.MaterialLabel1.Text = "Opciones Avanzadas:"
        '
        'btnOrganizar
        '
        Me.btnOrganizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrganizar.AutoSize = False
        Me.btnOrganizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOrganizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnOrganizar.Depth = 0
        Me.btnOrganizar.HighEmphasis = True
        Me.btnOrganizar.Icon = Nothing
        Me.btnOrganizar.Location = New System.Drawing.Point(629, 84)
        Me.btnOrganizar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnOrganizar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOrganizar.Name = "btnOrganizar"
        Me.btnOrganizar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnOrganizar.Size = New System.Drawing.Size(299, 36)
        Me.btnOrganizar.TabIndex = 7
        Me.btnOrganizar.Text = "Organizar Archivos"
        Me.btnOrganizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnOrganizar.UseAccentColor = False
        Me.btnOrganizar.UseVisualStyleBackColor = True
        '
        'lblSeleccionarCarpeta
        '
        Me.lblSeleccionarCarpeta.AutoSize = True
        Me.lblSeleccionarCarpeta.Depth = 0
        Me.lblSeleccionarCarpeta.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblSeleccionarCarpeta.Location = New System.Drawing.Point(6, 3)
        Me.lblSeleccionarCarpeta.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSeleccionarCarpeta.Name = "lblSeleccionarCarpeta"
        Me.lblSeleccionarCarpeta.Size = New System.Drawing.Size(240, 19)
        Me.lblSeleccionarCarpeta.TabIndex = 6
        Me.lblSeleccionarCarpeta.Text = "Selecciona la carpeta a organizar:"
        '
        'pbProgreso
        '
        Me.pbProgreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgreso.Depth = 0
        Me.pbProgreso.Location = New System.Drawing.Point(6, 493)
        Me.pbProgreso.MouseState = MaterialSkin.MouseState.HOVER
        Me.pbProgreso.Name = "pbProgreso"
        Me.pbProgreso.Size = New System.Drawing.Size(922, 5)
        Me.pbProgreso.TabIndex = 4
        '
        'btnBuscarCarpeta
        '
        Me.btnBuscarCarpeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarCarpeta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBuscarCarpeta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnBuscarCarpeta.Depth = 0
        Me.btnBuscarCarpeta.HighEmphasis = True
        Me.btnBuscarCarpeta.Icon = Nothing
        Me.btnBuscarCarpeta.Location = New System.Drawing.Point(782, 36)
        Me.btnBuscarCarpeta.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBuscarCarpeta.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBuscarCarpeta.Name = "btnBuscarCarpeta"
        Me.btnBuscarCarpeta.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnBuscarCarpeta.Size = New System.Drawing.Size(146, 36)
        Me.btnBuscarCarpeta.TabIndex = 1
        Me.btnBuscarCarpeta.Text = "Buscar Carpeta"
        Me.btnBuscarCarpeta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBuscarCarpeta.UseAccentColor = False
        Me.btnBuscarCarpeta.UseVisualStyleBackColor = True
        '
        'txtCarpetaSeleccionada
        '
        Me.txtCarpetaSeleccionada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCarpetaSeleccionada.AnimateReadOnly = False
        Me.txtCarpetaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCarpetaSeleccionada.Depth = 0
        Me.txtCarpetaSeleccionada.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtCarpetaSeleccionada.LeadingIcon = Nothing
        Me.txtCarpetaSeleccionada.Location = New System.Drawing.Point(3, 25)
        Me.txtCarpetaSeleccionada.MaxLength = 50
        Me.txtCarpetaSeleccionada.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCarpetaSeleccionada.Multiline = False
        Me.txtCarpetaSeleccionada.Name = "txtCarpetaSeleccionada"
        Me.txtCarpetaSeleccionada.ReadOnly = True
        Me.txtCarpetaSeleccionada.Size = New System.Drawing.Size(772, 50)
        Me.txtCarpetaSeleccionada.TabIndex = 0
        Me.txtCarpetaSeleccionada.Text = "Ruta de la carpeta..."
        Me.txtCarpetaSeleccionada.TrailingIcon = Nothing
        '
        'tbAbout
        '
        Me.tbAbout.Controls.Add(Me.LinkWebPageRMalanco)
        Me.tbAbout.Controls.Add(Me.MaterialLabel3)
        Me.tbAbout.Controls.Add(Me.lblVersion)
        Me.tbAbout.Location = New System.Drawing.Point(4, 22)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAbout.Size = New System.Drawing.Size(935, 507)
        Me.tbAbout.TabIndex = 1
        Me.tbAbout.Text = "Acerca de"
        Me.tbAbout.UseVisualStyleBackColor = True
        '
        'LinkWebPageRMalanco
        '
        Me.LinkWebPageRMalanco.AutoSize = True
        Me.LinkWebPageRMalanco.Location = New System.Drawing.Point(266, 59)
        Me.LinkWebPageRMalanco.Name = "LinkWebPageRMalanco"
        Me.LinkWebPageRMalanco.Size = New System.Drawing.Size(141, 13)
        Me.LinkWebPageRMalanco.TabIndex = 2
        Me.LinkWebPageRMalanco.TabStop = True
        Me.LinkWebPageRMalanco.Text = "https://www.rmalanco.com/"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(16, 57)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(234, 19)
        Me.MaterialLabel3.TabIndex = 1
        Me.MaterialLabel3.Text = "Desarrollado por Rafael Malanco"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Depth = 0
        Me.lblVersion.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblVersion.Location = New System.Drawing.Point(16, 29)
        Me.lblVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(93, 19)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Versión 1.0.0"
        '
        'tbLog
        '
        Me.tbLog.Controls.Add(Me.txtLog)
        Me.tbLog.Location = New System.Drawing.Point(4, 22)
        Me.tbLog.Name = "tbLog"
        Me.tbLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLog.Size = New System.Drawing.Size(935, 507)
        Me.tbLog.TabIndex = 2
        Me.tbLog.Text = "Log"
        Me.tbLog.UseVisualStyleBackColor = True
        '
        'MaterialCheckbox1
        '
        Me.MaterialCheckbox1.Depth = 0
        Me.MaterialCheckbox1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialCheckbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox1.Name = "MaterialCheckbox1"
        Me.MaterialCheckbox1.ReadOnly = False
        Me.MaterialCheckbox1.Ripple = True
        Me.MaterialCheckbox1.Size = New System.Drawing.Size(104, 37)
        Me.MaterialCheckbox1.TabIndex = 0
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(6, 6)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(923, 495)
        Me.txtLog.TabIndex = 0
        Me.txtLog.TabStop = False
        Me.txtLog.WordWrap = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 600)
        Me.Controls.Add(Me.tcPrincipal)
        Me.DrawerTabControl = Me.tcPrincipal
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Organizer"
        Me.tcPrincipal.ResumeLayout(False)
        Me.tpMain.ResumeLayout(False)
        Me.tpMain.PerformLayout()
        Me.tbAbout.ResumeLayout(False)
        Me.tbAbout.PerformLayout()
        Me.tbLog.ResumeLayout(False)
        Me.tbLog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcPrincipal As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tpMain As TabPage
    Friend WithEvents txtCarpetaSeleccionada As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnBuscarCarpeta As MaterialSkin.Controls.MaterialButton
    Friend WithEvents pbProgreso As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents chartEspacio As LiveCharts.WinForms.PieChart
    Friend WithEvents lblSeleccionarCarpeta As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnOrganizar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents chkListOpcionesAvanzadas As MaterialSkin.Controls.MaterialCheckedListBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbArchivos As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lstArchivosProcesados As ListView
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents btnLimpiar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tbAbout As TabPage
    Friend WithEvents LinkWebPageRMalanco As LinkLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblVersion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbLog As TabPage
    Friend WithEvents txtLog As TextBox
End Class
