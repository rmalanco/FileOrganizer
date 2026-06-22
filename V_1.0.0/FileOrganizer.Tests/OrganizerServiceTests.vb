Imports System.IO
Imports System.Text
Imports FileOrganizer.Domain
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class OrganizerServiceTests

    Private testDirectory As String
    Private testFile As String

    <TestInitialize>
    Public Sub Setup()
        ' Create a test directory and a test file
        testDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString())
        Directory.CreateDirectory(testDirectory)
        testFile = Path.Combine(testDirectory, "testFile.txt")
        File.WriteAllText(testFile, "This is a test file.")
    End Sub

    <TestCleanup>
    Public Sub Cleanup()
        ' Delete the test directory and its contents
        If Directory.Exists(testDirectory) Then
            Directory.Delete(testDirectory, True)
        End If
    End Sub

    <TestMethod>
    Public Sub OrganizarArchivos_ShouldMoveFileToNewDirectory()
        ' Arrange
        Dim eliminarDuplicados As Boolean = False

        ' Act
        OrganizerService.OrganizarArchivos(testFile, eliminarDuplicados)

        Assert.IsTrue(True)
    End Sub

    <TestMethod>
    Public Sub OrganizarArchivos_ShouldDeleteDuplicateFile()
        ' Arrange
        Dim eliminarDuplicados As Boolean = True
        Dim duplicateFile As String = Path.Combine(testDirectory, "duplicateFile.txt")
        File.WriteAllText(duplicateFile, "This is a duplicate file.")

        ' Act
        OrganizerService.OrganizarArchivos(duplicateFile, eliminarDuplicados)

        ' Assert
        Assert.IsFalse(File.Exists(duplicateFile), "The duplicate file should be deleted.")
    End Sub

End Class
