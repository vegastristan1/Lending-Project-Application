Public Class View_Borrower

    Public Property HoldBorrowerID As Integer

    Private Sub View_Borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the BorrowerID to load data for the selected borrower
        MessageBox.Show("Borrower ID: " & HoldBorrowerID.ToString())

        txtBorrowerDetailsID.Text = HoldBorrowerID

        ' You can add your logic to fetch and display borrower details based on the BorrowerID
    End Sub

    Private Sub btnBackToBorrowersList_Click(sender As Object, e As EventArgs) Handles btnBackToBorrowersList.Click
        Me.Close()
    End Sub

End Class