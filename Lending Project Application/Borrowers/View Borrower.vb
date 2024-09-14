Imports System.Data.SqlClient

Public Class View_Borrower

    Public Property HoldBorrowerID As Integer

    ' Replace with your actual connection string
    'Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
    ' Replace with your actual connection string
    Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"


    Private Sub View_Borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the BorrowerID to load data for the selected borrower
        'MessageBox.Show("Borrower ID: " & HoldBorrowerID.ToString())

        ' Assign Borrower ID to the TextBox
        'txtBorrowerDetailsID.Text = HoldBorrowerID.ToString()

        ' Fetch and display borrower details from the database based on the BorrowerID
        LoadBorrowerDetails(HoldBorrowerID)
    End Sub

    Private Sub LoadBorrowerDetails(borrowerID As Integer)

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

    Private Sub btnViewBorrowerEdit_Click(sender As Object, e As EventArgs) Handles btnViewBorrowerEdit.Click
        txtViewBorrowerLastName.Enabled = True
        txtViewBorrowerFirstName.Enabled = True
        txtViewBorrowerMiddleName.Enabled = True
        cmbViewBorrowerSuffixName.Enabled = True
        dtpViewBorrowerBirthdate.Enabled = True
        txtViewBorrowerContactNo.Enabled = True
        txtViewBorrowerEmailAddress.Enabled = True
        txtViewBorrowerPlaceOfBirth.Enabled = True
        cmbViewBorrowerCivilStatus.Enabled = True
        txtViewBorrowerCitizenship.Enabled = True
        cmbViewBorrowerReligion.Enabled = True
        txtViewBorrowerAddress.Enabled = True
        txtViewBorrowerSpouseName.Enabled = True
        txtViewBorrowerSpouseEmployersName.Enabled = True
        txtViewBorrowerSpouseWorkAddress.Enabled = True
        txtViewBorrowerWorkEmployerName.Enabled = True
        cmbViewBorrowerWorkStatus.Enabled = True
        txtViewBorrowerWorkAddress.Enabled = True
        txtViewBorrowerBusinessName.Enabled = True
        txtViewBorrowerBusinessNature.Enabled = True
        txtViewBorrowerBusinessAddress.Enabled = True

        btnViewBorrowerEdit.Visible = False
        btnViewBorrowerSave.Enabled = True
    End Sub

    Private Sub btnViewBorrowerSave_Click(sender As Object, e As EventArgs) Handles btnViewBorrowerSave.Click
        'btnViewBorrowerEdit.Visible = True


        ' SQL Query to update borrower and name details
        Dim query As String = "
        UPDATE Borrowers 
        SET Birthdate = @Birthdate, TelNo = @TelNo, EmailAddress = @EmailAddress, PlaceOfBirth = @PlaceOfBirth, 
            CivilStatus = @CivilStatus, Citizenship = @Citizenship, Religion = @Religion, HomeAddress = @HomeAddress, 
            SpouseName = @SpouseName, SpouseEmployerName = @SpouseEmployerName, SpouseEmployerAddress = @SpouseEmployerAddress, 
            EmployerName = @EmployerName, EmploymentStatus = @EmploymentStatus, EmployerAddress = @EmployerAddress, 
            BusinessName = @BusinessName, BusinessNature = @BusinessNature, BusinessAddress = @BusinessAddress
        WHERE BorrowerID = @BorrowerID;

        UPDATE Names 
        SET LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName, SuffixName = @SuffixName
        WHERE NameID = @BorrowerID;"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Set the parameters for Borrowers table
                command.Parameters.AddWithValue("@BorrowerID", HoldBorrowerID)
                command.Parameters.AddWithValue("@Birthdate", dtpViewBorrowerBirthdate.Value)
                command.Parameters.AddWithValue("@TelNo", txtViewBorrowerContactNo.Text)
                command.Parameters.AddWithValue("@EmailAddress", txtViewBorrowerEmailAddress.Text)
                command.Parameters.AddWithValue("@PlaceOfBirth", txtViewBorrowerPlaceOfBirth.Text)
                command.Parameters.AddWithValue("@CivilStatus", cmbViewBorrowerCivilStatus.SelectedItem.ToString())
                command.Parameters.AddWithValue("@Citizenship", txtViewBorrowerCitizenship.Text)
                command.Parameters.AddWithValue("@Religion", cmbViewBorrowerReligion.SelectedItem.ToString())
                command.Parameters.AddWithValue("@HomeAddress", txtViewBorrowerAddress.Text)
                command.Parameters.AddWithValue("@SpouseName", txtViewBorrowerSpouseName.Text)
                command.Parameters.AddWithValue("@SpouseEmployerName", txtViewBorrowerSpouseEmployersName.Text)
                command.Parameters.AddWithValue("@SpouseEmployerAddress", txtViewBorrowerSpouseWorkAddress.Text)
                command.Parameters.AddWithValue("@EmployerName", txtViewBorrowerWorkEmployerName.Text)

                ' Check if an item is selected in the ComboBox, if not, default to "Unemployment"
                Dim employmentStatus As String = If(cmbViewBorrowerWorkStatus.SelectedItem IsNot Nothing, cmbViewBorrowerWorkStatus.SelectedItem.ToString(), "Unemployment")
                ' Now, set the parameter with the determined value
                command.Parameters.AddWithValue("@EmploymentStatus", employmentStatus)

                command.Parameters.AddWithValue("@EmployerAddress", txtViewBorrowerWorkAddress.Text)
                command.Parameters.AddWithValue("@BusinessName", txtViewBorrowerBusinessName.Text)
                command.Parameters.AddWithValue("@BusinessNature", txtViewBorrowerBusinessNature.Text)
                command.Parameters.AddWithValue("@BusinessAddress", txtViewBorrowerBusinessAddress.Text)

                ' Set the parameters for Names table
                command.Parameters.AddWithValue("@LastName", txtViewBorrowerLastName.Text)
                command.Parameters.AddWithValue("@FirstName", txtViewBorrowerFirstName.Text)
                command.Parameters.AddWithValue("@MiddleName", txtViewBorrowerMiddleName.Text)
                Dim suffixName As String = If(cmbViewBorrowerSuffixName.SelectedItem IsNot Nothing, cmbViewBorrowerSuffixName.SelectedItem.ToString(), "N/A")
                command.Parameters.AddWithValue("@SuffixName", suffixName)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        'MessageBox.Show("Borrower details updated successfully.")
        Me.Close()
    End Sub

End Class