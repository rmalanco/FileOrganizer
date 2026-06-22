Imports System.IO
Imports System.Text
Imports FileOrganizer.Domain
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class ReportServiceTests

    Private testDirectory As String

    <TestInitialize>
    Public Sub Setup()
        ' Create a test directory
        testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())
        Directory.CreateDirectory(testDirectory)
    End Sub

    <TestCleanup>
    Public Sub Cleanup()
        ' Delete the test directory and its contents
        If Directory.Exists(testDirectory) Then
            Directory.Delete(testDirectory, True)
        End If
    End Sub

    <TestMethod>
    Public Sub CalcularDistribucionArchivos_ShouldReturnEmptyDictionary_WhenDirectoryDoesNotExist()
        ' Arrange
        Dim nonExistentDirectory As String = Path.Combine(testDirectory, "NonExistent")
        Dim messageError As String

        ' Act
        Dim result = ReportService.CalcularDistribucionArchivos(nonExistentDirectory, messageError)

        ' Assert
        Assert.AreEqual(0, result.Count, "The result should be an empty dictionary.")
        Assert.AreEqual("La carpeta especificada no existe.", messageError, "The error message should indicate that the directory does not exist.")
    End Sub

    <TestMethod>
    Public Sub CalcularDistribucionArchivos_ShouldReturnEmptyDictionary_WhenNoFilesInDirectory()
        ' Arrange
        Dim messageError As String

        ' Act
        Dim result = ReportService.CalcularDistribucionArchivos(testDirectory, messageError)

        ' Assert
        Assert.AreEqual(0, result.Count, "The result should be an empty dictionary.")
        Assert.AreEqual("No se encontraron archivos en la carpeta especificada.", messageError, "The error message should indicate that no files were found.")
    End Sub

    <TestMethod>
    Public Sub CalcularDistribucionArchivos_ShouldReturnCorrectDistribution()
        ' Arrange
        Dim messageError As String
        Dim file1 As String = Path.Combine(testDirectory, "file1.txt")
        Dim file2 As String = Path.Combine(testDirectory, "file2.txt")
        Dim file3 As String = Path.Combine(testDirectory, "file3.pdf")
        File.WriteAllText(file1, "This is a test file.")
        File.WriteAllText(file2, "This is another test file.")
        File.WriteAllText(file3, "This is a PDF file.")

        ' Act
        Dim result = ReportService.CalcularDistribucionArchivos(testDirectory, messageError)

        ' Assert
        Assert.AreEqual(2, result.Count, "The result should contain two entries.")
        Assert.AreEqual(66.67, result(".txt"), "The .txt files should account for 66.67% of the total.")
        Assert.AreEqual(33.33, result(".pdf"), "The .pdf files should account for 33.33% of the total.")
        Assert.AreEqual(String.Empty, messageError, "There should be no error message.")
    End Sub

End Class
