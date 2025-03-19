Imports System.IO

''' <summary>
''' Helper class for file operations.
''' </summary>
Public Class FileHelper

    ''' <summary>
    ''' Dictionary containing file extensions and their corresponding categories.
    ''' </summary>
    Public Shared ReadOnly CATEGORIAS As New Dictionary(Of String, String) From {
            {".jpg", "Imagenes"}, {".jpeg", "Imagenes"}, {".png", "Imagenes"}, {".gif", "Imagenes"},
            {".bmp", "Imagenes"}, {".tiff", "Imagenes"}, {".webp", "Imagenes"},
            {".mp4", "Videos"}, {".avi", "Videos"}, {".mov", "Videos"}, {".wmv", "Videos"},
            {".mkv", "Videos"}, {".flv", "Videos"}, {".webm", "Videos"}, {".3gp", "Videos"},
            {".mp3", "Audio"}, {".wav", "Audio"}, {".flac", "Audio"}, {".aac", "Audio"},
            {".ogg", "Audio"}, {".wma", "Audio"},
            {".pdf", "Documentos"}, {".doc", "Documentos"}, {".docx", "Documentos"}, {".xls", "Documentos"},
            {".xlsx", "Documentos"}, {".ppt", "Documentos"}, {".pptx", "Documentos"}, {".csv", "Documentos"},
            {".odt", "Documentos"}, {".ods", "Documentos"}, {".odp", "Documentos"},
            {".txt", "Textos"}, {".log", "Textos"}, {".rtf", "Textos"},
            {".html", "Codigo"}, {".htm", "Codigo"}, {".css", "Codigo"}, {".js", "Codigo"},
            {".xml", "Codigo"}, {".json", "Codigo"}, {".php", "Codigo"}, {".java", "Codigo"},
            {".py", "Codigo"}, {".cpp", "Codigo"}, {".c", "Codigo"}, {".cs", "Codigo"},
            {".vb", "Codigo"}, {".swift", "Codigo"}, {".go", "Codigo"}, {".sh", "Codigo"},
            {".zip", "Comprimidos"}, {".rar", "Comprimidos"}, {".7z", "Comprimidos"},
            {".tar", "Comprimidos"}, {".gz", "Comprimidos"},
            {".exe", "Ejecutables"}, {".msi", "Ejecutables"}, {".bat", "Ejecutables"},
            {".apk", "Ejecutables"}, {".app", "Ejecutables"},
            {".iso", "Discos"}, {".img", "Discos"},
            {".ttf", "Fuentes"}, {".otf", "Fuentes"},
            {".psd", "Diseño"}, {".ai", "Diseño"}, {".sketch", "Diseño"},
            {".dwg", "Diseño"}, {".indd", "Diseño"}
        }

    ''' <summary>
    ''' Obtains the destination folder based on the file extension.
    ''' </summary>
    ''' <param name="extension">The file extension.</param>
    ''' <param name="rutaBase">The base path where the folders are located.</param>
    ''' <returns>The path to the destination folder.</returns>
    Public Shared Function ObtenerCarpetaDestino(extension As String, rutaBase As String) As String
        Dim carpetaOtros As String = Path.Combine(rutaBase, "Otros")

        If CATEGORIAS.ContainsKey(extension) Then
            Return Path.Combine(rutaBase, CATEGORIAS(extension))
        Else
            Return Path.Combine(carpetaOtros, extension.TrimStart("."))
        End If
    End Function

End Class
