Imports System.IO

Public Class processdelete
    ' Cose per il pannello
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub panel_MouseDown() Handles Me.MouseDown, PictureBox1.MouseDown, Label1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
        Cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove() Handles Me.MouseMove, PictureBox1.MouseMove, Label1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub panel_MouseUp() Handles Me.MouseUp, PictureBox1.MouseUp, Label1.MouseUp
        drag = False
        Cursor = Cursors.WaitCursor
    End Sub
    ' Fine cose per il pannello

    Public filez As String
    Public folderz As String
    Public listz As New List(Of String)

    Private Async Sub processdelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Visible = True Then
            BackColor = INIZIO.BackColor
            ForeColor = INIZIO.ForeColor
            Await deletesomething(filez, folderz)
        End If
    End Sub

    Public Async Function deletesomething(file As String, folder As String) As Task
        Dim task As New Task(Sub()
                                 If Not file = "" Then
                                     Try
                                         IO.File.Delete(file)
                                     Catch
                                     End Try
                                     Try
                                         IO.File.Delete(file & ".version")
                                     Catch
                                     End Try
                                 End If
                                 If Not folder = "" Then
                                     Try
                                         DeleteFilesFromFolder(folder)
                                     Catch
                                     End Try
                                     Try
                                         IO.File.Delete(folder)
                                     Catch
                                     End Try
                                 End If
                                 If listz.Count > 0 Then
                                     For i = 0 To listz.Count - 1
                                         Try
                                             DeleteFilesFromFolder(listz.Item(i))
                                         Catch
                                         End Try
                                         Try
                                             IO.File.Delete(listz.Item(i))
                                             IO.File.Delete(listz.Item(i) & ".version")
                                         Catch
                                         End Try
                                     Next
                                     listz.Clear()
                                 End If
                             End Sub)
        task.Start()
        Await task
        Close()
    End Function

    Sub DeleteFilesFromFolder(Folder As String)
        For Each _file As String In Directory.GetFiles(Folder)
            Try
                File.Delete(_file)
            Catch
                Dim oFileInfo As New FileInfo(_file)
                If (oFileInfo.Attributes And FileAttributes.ReadOnly) > 0 Then
                    oFileInfo.Attributes = oFileInfo.Attributes Xor FileAttributes.ReadOnly
                    File.Delete(_file)
                End If
            End Try
        Next
        For Each _folder As String In Directory.GetDirectories(Folder)
            DeleteFilesFromFolder(_folder)
        Next
        Directory.Delete(Folder, True)
    End Sub
End Class