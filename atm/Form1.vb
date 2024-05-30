Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Public Class Account
        Public Property Username As String
        Public Property Password As String
        Public Property Money As Integer
    End Class

    Public Class AccountsData
        Public Property Accounts As List(Of Account)
    End Class
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.json")
        Dim json As String = File.ReadAllText(filePath)

        Dim accountsData As AccountsData = JsonConvert.DeserializeObject(Of AccountsData)(json)

        Dim usr As String
        Dim passwrd As String

        If CheckLogin(accountsData, user.Text, pass.Text) Then
            usr = user.Text
            passwrd = pass.Text

            MsgBox("Login success!", MsgBoxStyle.OkOnly, "Login info")
            Form2.Show()
            Form2.UserLabel.Text = usr
        Else
            MsgBox("Login failed, incorrect details", MsgBoxStyle.OkOnly, "Login info")
        End If
    End Sub

    Function CheckLogin(accountsData As AccountsData, username As String, password As String) As Boolean
        For Each account In accountsData.Accounts
            If account.Username = username AndAlso account.Password = password Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
