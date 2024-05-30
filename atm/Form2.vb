Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Newtonsoft.Json

Public Class Form2
    Public Class Account
        Public Property Username As String
        Public Property Password As String
        Public Property Money As Integer
    End Class

    Public Class AccountsData
        Public Property Accounts As List(Of Account)
    End Class
    Private Sub checkMoney_MouseClick(sender As Object, e As MouseEventArgs) Handles checkMoney.MouseClick
        Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.json")
        Dim json As String = File.ReadAllText(filePath)

        Dim accountsData As AccountsData = JsonConvert.DeserializeObject(Of AccountsData)(json)

        For Each account In accountsData.Accounts
            If account.Username = UserLabel.Text Then
                MsgBox("Your current ammount is: " & account.Money, MsgBoxStyle.OkOnly, "Money")
            End If
        Next
    End Sub

    Private Sub Deposit_MouseClick(sender As Object, e As MouseEventArgs) Handles Deposit.MouseClick
        Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.json")
        Dim json As String = File.ReadAllText(filePath)

        Dim accountsData As AccountsData = JsonConvert.DeserializeObject(Of AccountsData)(json)

        Dim checkedMoney As Integer

        For Each account In accountsData.Accounts
            If account.Username = UserLabel.Text Then
                checkedMoney = account.Money
            End If
        Next

        If ammountBox.Text Is "" Then
            MsgBox("Value must not be nothing", MsgBoxStyle.OkOnly, "Error")
        Else
            For Each account In accountsData.Accounts
                If account.Username = UserLabel.Text Then
                    account.Money = account.Money + ammountBox.Text
                End If
            Next

            Dim serializedJson As String

            serializedJson = JsonConvert.SerializeObject(accountsData, Formatting.Indented)

            File.WriteAllText(filePath, serializedJson)

        End If
    End Sub

    Private Sub withdrawButton_MouseClick(sender As Object, e As MouseEventArgs) Handles withdrawButton.MouseClick
        Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "accounts.json")
        Dim json As String = File.ReadAllText(filePath)

        Dim accountsData As AccountsData = JsonConvert.DeserializeObject(Of AccountsData)(json)

        Dim checkedMoney As Integer

        For Each account In accountsData.Accounts
            If account.Username = UserLabel.Text Then
                checkedMoney = account.Money
            End If
        Next

        If Not ammountBox.Text > checkedMoney Then
            For Each account In accountsData.Accounts
                If account.Username = UserLabel.Text Then
                    account.Money = account.Money - ammountBox.Text
                End If
            Next

            Dim serializedJson As String

            serializedJson = JsonConvert.SerializeObject(accountsData, Formatting.Indented)

            File.WriteAllText(filePath, serializedJson)
        Else
            MsgBox("Amout must not be greater than your current ammount", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class