Imports System.Data.SqlClient

Public Class Add_New_Borrower
    Private Sub BtnBackToBorrowersList_Click(sender As Object, e As EventArgs) Handles btnBackToBorrowersList.Click
        Me.Close()
    End Sub

    Private Sub BtnAddNewBorrowerSave_Click(sender As Object, e As EventArgs) Handles btnAddNewBorrowerSave.Click
        ' Collect the form data from your input fields
        Dim lastname As String = txtAddNewBorrowerLastName.Text
        Dim firstname As String = txtAddNewBorrowerFirstName.Text
        Dim middlename As String = txtAddNewBorrowerMiddleName.Text
        Dim homeaddress As String = txtAddNewBorrowerAddress.Text
        Dim telno As String = txtAddNewBorrowerContactNo.Text
        Dim birthdate As Date = dtpBirthdateAddNewBorrowerBirthday.Value ' assuming you are using a datetimepicker
        Dim placeofbirth As String = txtAddNewBorrowerPlaceOfBirth.Text

        ' Check if civilStatus ComboBox has a selected item, otherwise default to an empty string
        Dim religion As String = If(cboAddNewBorrowerReligion.SelectedItem IsNot Nothing, cboAddNewBorrowerReligion.SelectedItem.ToString(), "")

        ' Check if civilStatus ComboBox has a selected item, otherwise default to an empty string
        Dim civilStatus As String = If(cboAddNewBorrowerCivilStatus.SelectedItem IsNot Nothing, cboAddNewBorrowerCivilStatus.SelectedItem.ToString(), "")

        Dim employername As String = txtAddNewBorrowerWorkEmployerName.Text

        ' Check if employmentStatus ComboBox has a selected item, otherwise default to an empty string
        Dim employmentStatus As String = If(cboAddNewBorrowerWorkStatus.SelectedItem IsNot Nothing, cboAddNewBorrowerWorkStatus.SelectedItem.ToString(), "")

        Dim employeraddress As String = txtAddNewBorrowerWorkAddress.Text
        Dim businessname As String = txtAddNewBorrowerBusinessName.Text
        Dim businessnature As String = txtAddNewBorrowerBusinessEnvironment.Text
        Dim businessaddress As String = txtAddNewBorrowerBusinessAddress.Text
        Dim spousename As String = txtAddNewBorrowerSpouseLastName.Text + " " + txtAddNewBorrowerSpouseFirstName.Text + " " + txtAddNewBorrowerSpouseMiddleName.Text
        Dim spouseemployeraddress As String = txtAddNewBorrowerSpouseAddress.Text

        ' Call the InsertBorrowerAndName method and pass the collected data
        InsertBorrowerAndName(lastname, firstname, middlename, homeaddress, telno, birthdate, placeofbirth,
        religion, civilStatus, employername, employmentStatus,
        employeraddress, businessname, businessnature, businessaddress, spousename,
        spouseemployeraddress)

        ' Optionally, display a confirmation message or clear the form fields after saving
        MessageBox.Show("Borrower information added successfully!")
        Clearformfields() ' Assuming you have a method to clear the form after saving

    End Sub

    Public Sub InsertBorrowerAndName(ByVal lastName As String, ByVal firstName As String, ByVal middleName As String,
                                 ByVal homeAddress As String, ByVal telNo As String, ByVal birthdate As Date,
                                 ByVal placeOfBirth As String, ByVal religion As String,
                                 ByVal civilStatus As String, ByVal employerName As String, ByVal employmentStatus As String,
                                 ByVal employerAddress As String, ByVal businessName As String, ByVal businessNature As String,
                                 ByVal businessAddress As String, ByVal spouseName As String,
                                 ByVal spouseEmployerAddress As String)

        ' Connection string to the SQL Server
        Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True"

        ' Create a connection to SQL Server
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' SQL Transaction to ensure both inserts happen together
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' Step 1: Insert into the Names table and get the generated NameID
                Dim nameInsertQuery As String = "INSERT INTO Names (LastName, FirstName, MiddleName) VALUES (@LastName, @FirstName, @MiddleName); " &
                                                "SELECT SCOPE_IDENTITY();" ' This returns the newly inserted NameID

                Dim nameID As Integer
                Using cmd As New SqlCommand(nameInsertQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@MiddleName", middleName)

                    ' Execute the query and get the generated NameID
                    nameID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Step 2: Insert into the Borrowers table using the NameID
                Dim borrowerInsertQuery As String = "INSERT INTO Borrowers (NameID, HomeAddress, TelNo, Birthdate, PlaceOfBirth, Religion, CivilStatus, EmployerName, EmploymentStatus, EmployerAddress, BusinessName, BusinessNature, BusinessAddress, SpouseName, SpouseEmployerAddress) " &
                                                    "VALUES (@NameID, @HomeAddress, @TelNo, @Birthdate, @PlaceOfBirth, @Religion, @CivilStatus, @EmployerName, @EmploymentStatus, @EmployerAddress, @BusinessName, @BusinessNature, @BusinessAddress, @SpouseName, @SpouseEmployerAddress);"

                Using cmd2 As New SqlCommand(borrowerInsertQuery, conn, transaction)
                    cmd2.Parameters.AddWithValue("@NameID", nameID)
                    cmd2.Parameters.AddWithValue("@HomeAddress", homeAddress)
                    cmd2.Parameters.AddWithValue("@TelNo", telNo)
                    cmd2.Parameters.AddWithValue("@Birthdate", birthdate)
                    cmd2.Parameters.AddWithValue("@PlaceOfBirth", placeOfBirth)
                    cmd2.Parameters.AddWithValue("@Religion", religion)
                    cmd2.Parameters.AddWithValue("@CivilStatus", civilStatus)
                    cmd2.Parameters.AddWithValue("@EmployerName", employerName)
                    cmd2.Parameters.AddWithValue("@EmploymentStatus", employmentStatus)
                    cmd2.Parameters.AddWithValue("@EmployerAddress", employerAddress)
                    cmd2.Parameters.AddWithValue("@BusinessName", businessName)
                    cmd2.Parameters.AddWithValue("@BusinessNature", businessNature)
                    cmd2.Parameters.AddWithValue("@BusinessAddress", businessAddress)
                    cmd2.Parameters.AddWithValue("@SpouseName", spouseName)
                    cmd2.Parameters.AddWithValue("@SpouseEmployerAddress", spouseEmployerAddress)

                    ' Execute the insert query
                    cmd2.ExecuteNonQuery()
                End Using

                ' If everything is successful, commit the transaction
                transaction.Commit()

                MessageBox.Show("Borrower and Name added successfully!")

            Catch ex As Exception
                ' If any error occurs, roll back the transaction
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Optional: A method to clear the form fields after saving
    Private Sub Clearformfields()
        txtAddNewBorrowerLastName.Clear()
        txtAddNewBorrowerFirstName.Clear()
        txtAddNewBorrowerMiddleName.Clear()
        txtAddNewBorrowerAddress.Clear()
        txtAddNewBorrowerContactNo.Clear()
        dtpBirthdateAddNewBorrowerBirthday.Value = DateTime.Now ' reset to today's date
        txtAddNewBorrowerPlaceOfBirth.Clear()
        cboAddNewBorrowerReligion.SelectedIndex = -1
        cboAddNewBorrowerCivilStatus.SelectedIndex = -1 ' reset combobox
        txtAddNewBorrowerWorkEmployerName.Clear()
        cboAddNewBorrowerWorkStatus.SelectedIndex = -1
        txtAddNewBorrowerWorkAddress.Clear()
        txtAddNewBorrowerBusinessName.Clear()
        txtAddNewBorrowerBusinessEnvironment.Clear()
        txtAddNewBorrowerBusinessAddress.Clear()
        txtAddNewBorrowerSpouseLastName.Clear()
        txtAddNewBorrowerSpouseFirstName.Clear()
        txtAddNewBorrowerSpouseMiddleName.Clear()
        txtAddNewBorrowerSpouseAddress.Clear()
    End Sub
End Class
