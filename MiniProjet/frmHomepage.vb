Public Class frmHomepage

    Private Sub frmHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim lblShopping As New Label
        lblShopping.Font = New Font(lblShopping.Font, FontStyle.Bold)

        btnList.Style = 1
        btnList.Image = MiniProjet.My.Resources.Resources.List
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblShopping.Click

    End Sub
End Class
