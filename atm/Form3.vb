Imports System.IO
Imports Newtonsoft.Json

Public Class Form3
    Public Class Account
        Public Property Username As String
        Public Property Password As String
        Public Property Money As Integer
    End Class

    Public Class AccountsData
        Public Property Accounts As List(Of Account)
    End Class

    Private Sub SubmitBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles SubmitBtn.MouseClick
        If username.Text IsNot "" AndAlso password.Text = repeatedPass.Text Then
            Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.json")

            Dim accountsData As AccountsData
            If File.Exists(filePath) Then
                Dim json As String = File.ReadAllText(filePath)
                accountsData = JsonConvert.DeserializeObject(Of AccountsData)(json)
            Else
                accountsData = New AccountsData()
                accountsData.Accounts = New List(Of Account)()
            End If

            Dim newAccount As New Account() With {
                .Username = username.Text,
                .Password = password.Text,
                .Money = 0
            }

            accountsData.Accounts.Add(newAccount)

            Dim updatedJson As String = JsonConvert.SerializeObject(accountsData, Formatting.Indented)

            File.WriteAllText(filePath, updatedJson)

            username.Text = ""
            password.Text = ""
            repeatedPass.Text = ""

            MessageBox.Show("Account created successfully!")
        Else
            MessageBox.Show("Please ensure all fields are filled and passwords match.")
        End If
    End Sub
End Class
