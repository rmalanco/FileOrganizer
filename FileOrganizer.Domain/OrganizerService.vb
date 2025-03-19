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
        Dim nombreArchivo As String = Path.GetFileName(ruta)
        Dim rutaArchivo As String = Path.GetDirectoryName(ruta)

        If Not Directory.Exists(rutaArchivo) Then Exit Sub

        Dim archivos = Directory.GetFiles(rutaArchivo)

        For Each archivo In archivos
            Dim extension = Path.GetExtension(archivo).ToLower()
            Dim nuevaCarpeta As String = FileHelper.ObtenerCarpetaDestino(extension, rutaArchivo)

            ' Crear la carpeta si no existe
            Directory.CreateDirectory(nuevaCarpeta)

            ' Mover el archivo a su nueva ubicación
            MoverArchivo(archivo, nuevaCarpeta, eliminarDuplicados)
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
            File.Move(archivo, nuevoArchivo)
            Logger.Log($"Archivo movido: {archivo} → {nuevoArchivo}")
        End If
    End Sub

End Class
