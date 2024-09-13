Imports System.Data.SqlClient

Public Class View_Borrower

    Public Property HoldBorrowerID As Integer

    Private Sub View_Borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the BorrowerID to load data for the selected borrower
        'MessageBox.Show("Borrower ID: " & HoldBorrowerID.ToString())

        ' Assign Borrower ID to the TextBox
        'txtBorrowerDetailsID.Text = HoldBorrowerID.ToString()

        ' Fetch and display borrower details from the database based on the BorrowerID
        LoadBorrowerDetails(HoldBorrowerID)
    End Sub

    Private Sub LoadBorrowerDetails(borrowerID As Integer)
        ' Replace with your actual connection string
        Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

        ' SQL Query to fetch borrower details
        ' SQL Query to fetch borrower and name details using INNER JOIN
        Dim query As String = "
            SELECT 
                n.LastName, n.FirstName, n.MiddleName, n.SuffixName,
                b.Birthdate, b.TelNo, b.EmailAddress, b.PlaceOfBirth, b.CivilStatus, b.Citizenship, b.Religion, b.HomeAddress, 
                b.SpouseName, b.SpouseEmployerName, b.SpouseEmployerAddress, b.EmployerName, b.EmploymentStatus, b.EmployerAddress, 
                b.BusinessName, b.BusinessNature, b.BusinessAddress 
            FROM Borrowers b
            INNER JOIN Names n ON b.BorrowerID = n.NameID
            WHERE b.BorrowerID = @BorrowerID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@BorrowerID", borrowerID)

                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Populate the TextBox and ComboBox controls with the data
                    txtViewBorrowerLastName.Text = reader("LastName").ToString()
                    txtViewBorrowerFirstName.Text = reader("FirstName").ToString()
                    txtViewBorrowerMiddleName.Text = reader("MiddleName").ToString()
                    cmbViewBorrowerSuffixName.SelectedItem = reader("SuffixName").ToString()
                    dtpViewBorrowerBirthdate.Value = Convert.ToDateTime(reader("Birthdate"))
                    txtViewBorrowerContactNo.Text = reader("TelNo").ToString()
                    txtViewBorrowerEmailAddress.Text = reader("EmailAddress").ToString()
                    txtViewBorrowerPlaceOfBirth.Text = reader("PlaceOfBirth").ToString()
                    cmbViewBorrowerCivilStatus.SelectedItem = reader("CivilStatus").ToString()
                    txtViewBorrowerCitizenship.Text = reader("Citizenship").ToString()
                    cmbViewBorrowerReligion.SelectedItem = reader("Religion").ToString()
                    txtViewBorrowerAddress.Text = reader("HomeAddress").ToString()
                    txtViewBorrowerSpouseName.Text = reader("SpouseName").ToString()
                    txtViewBorrowerSpouseEmployersName.Text = reader("SpouseEmployerName").ToString()
                    txtViewBorrowerSpouseWorkAddress.Text = reader("SpouseEmployerAddress").ToString()
                    txtViewBorrowerWorkEmployerName.Text = reader("EmployerName").ToString()
                    cmbViewBorrowerWorkStatus.SelectedItem = reader("EmploymentStatus").ToString()
                    txtViewBorrowerWorkAddress.Text = reader("EmployerAddress").ToString()
                    txtViewBorrowerBusinessName.Text = reader("BusinessName").ToString()
                    txtViewBorrowerBusinessNature.Text = reader("BusinessNature").ToString()
                    txtViewBorrowerBusinessAddress.Text = reader("BusinessAddress").ToString()
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub btnBackToBorrowersList_Click(sender As Object, e As EventArgs) Handles btnBackToBorrowersList.Click
        Me.Close()
    End Sub

End Class