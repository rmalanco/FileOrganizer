Imports System.IO

''' <summary>
''' Provides logging functionality to write and read log messages to and from a log file.
''' </summary>
Public Class Logger
    ''' <summary>
    ''' The path where the log file is stored.
    ''' </summary>
    Private Shared ReadOnly logPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log")
    Private logWatcher As FileSystemWatcher

    ''' <summary>
    ''' Writes a log message to the log file with a timestamp.
    ''' </summary>
    ''' <param name="mensaje">The message to log.</param>
    Public Shared Sub Log(mensaje As String)
        Try
            If Not Directory.Exists(logPath) Then
                Directory.CreateDirectory(logPath)
            End If

            Dim logFile As String = Path.Combine(logPath, "log.txt")
            Dim logMessage As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensaje}"

            File.AppendAllText(logFile, logMessage & Environment.NewLine)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Reads and returns the content of the log file.
    ''' </summary>
    ''' <returns>The content of the log file as a string. If the log file does not exist, returns an empty string.</returns>
    Public Shared Function GetLog() As String
        Dim logFile As String = Path.Combine(logPath, "log.txt")
        If File.Exists(logFile) Then
            Return File.ReadAllText(logFile)
        End If
        Return String.Empty
    End Function

End Class
