Imports System.IO
Imports FileOrganizer.Common

Public Class ReportService

    ''' <summary>
    ''' Calculates the distribution of files by their extensions in the specified folder.
    ''' </summary>
    ''' <param name="rutaCarpeta">The path of the folder to analyze.</param>
    ''' <param name="messageError">Output parameter to hold any error message encountered during execution.</param>
    ''' <returns>A dictionary where the keys are file extensions and the values are the percentage of files with that extension.</returns>
    Public Shared Function CalcularDistribucionArchivos(rutaCarpeta As String, ByRef messageError As String) As Dictionary(Of String, Double)
        messageError = String.Empty

        Try
            Dim distribucion As New Dictionary(Of String, Double)

            If Not Directory.Exists(rutaCarpeta) Then
                messageError = "La carpeta especificada no existe."
                Return distribucion
            End If

            Dim archivos = Directory.GetFiles(rutaCarpeta, "*.*", SearchOption.AllDirectories)
            If archivos.Length = 0 Then
                messageError = "No se encontraron archivos en la carpeta especificada."
                Return distribucion
            End If

            Dim totalArchivos As Integer = archivos.Length
            Dim conteoExtensiones As New Dictionary(Of String, Integer)

            ' Contar archivos por extensión
            For Each archivo In archivos
                Dim extension As String = Path.GetExtension(archivo).ToLower()
                If String.IsNullOrEmpty(extension) Then extension = "Sin Extensión"

                If Not conteoExtensiones.ContainsKey(extension) Then
                    conteoExtensiones(extension) = 0
                End If
                conteoExtensiones(extension) += 1
            Next

            ' Calcular porcentaje
            For Each kvp In conteoExtensiones
                Dim porcentaje As Double = (kvp.Value / totalArchivos) * 100
                distribucion.Add(kvp.Key, Math.Round(porcentaje, 2)) ' Redondea a 2 decimales
            Next

            Return distribucion

        Catch ex As UnauthorizedAccessException
            messageError = $"Error al acceder a la carpeta: {ex.Message}"
            Logger.Log(messageError)
            Return New Dictionary(Of String, Double)
        End Try

    End Function

End Class
