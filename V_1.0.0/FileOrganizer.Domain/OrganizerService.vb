Imports System.IO
Imports FileOrganizer.Common

''' <summary>
''' Provides services to organize files in a directory.
''' </summary>
Public Class OrganizerService

    ''' <summary>
    ''' Organizes files in the specified directory by moving them to subdirectories based on their extensions.
    ''' </summary>
    ''' <param name="ruta">The path of the directory to organize.</param>
    ''' <param name="eliminarDuplicados">If set to <c>true</c>, duplicate files will be deleted.</param>
    Public Shared Sub OrganizarArchivos(ruta As String, eliminarDuplicados As Boolean)
        Dim rutaArchivo = Path.GetDirectoryName(ruta)

        If String.IsNullOrEmpty(rutaArchivo) OrElse Not Directory.Exists(rutaArchivo) Then
            Return
        End If

        Dim archivos = Directory.GetFiles(rutaArchivo)
        If archivos.Length = 0 Then
            Return
        End If

        For Each archivo In archivos
            Try
                Dim extension = Path.GetExtension(archivo).ToLower()
                Dim nuevaCarpeta = FileHelper.ObtenerCarpetaDestino(extension, rutaArchivo)

                Directory.CreateDirectory(nuevaCarpeta)

                MoverArchivo(archivo, nuevaCarpeta, eliminarDuplicados)
            Catch ex As Exception
                Logger.Log($"Error al procesar el archivo '{archivo}': {ex.Message}")
            End Try
        Next
    End Sub

    ''' <summary>
    ''' Moves a file to a new directory. If duplicates are to be deleted, it deletes the file if it already exists in the destination.
    ''' </summary>
    ''' <param name="archivo">The file to move.</param>
    ''' <param name="nuevaCarpeta">The destination directory.</param>
    ''' <param name="eliminarDuplicados">If set to <c>true</c>, duplicate files will be deleted.</param>
    Private Shared Sub MoverArchivo(archivo As String, nuevaCarpeta As String, eliminarDuplicados As Boolean)
        Dim nuevoArchivo = Path.Combine(nuevaCarpeta, Path.GetFileName(archivo))

        If eliminarDuplicados AndAlso File.Exists(nuevoArchivo) Then
            File.Delete(archivo)
            Logger.Log($"Archivo duplicado eliminado: {archivo}")
        Else
            Try
                If File.Exists(nuevoArchivo) Then
                    File.Delete(nuevoArchivo)
                End If

                File.Move(archivo, nuevoArchivo)
                Logger.Log($"Archivo movido: {archivo} → {nuevoArchivo}")
            Catch ex As IOException
                Logger.Log($"Error al mover el archivo '{archivo}': {ex.Message}")
            End Try
        End If
    End Sub

End Class
