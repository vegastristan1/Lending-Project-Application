Imports System.Data.SqlClient
Imports System.Text

Public Class Add_New_Loan
    ' Connection string for your SQL Server
    Dim connectionString As String = "Data Source=LENOVO-GEN7\SQLEXPRESS;Initial Catalog=dbLending;Integrated Security=True;TrustServerCertificate=True"


    Private Sub btnBackToLoansList_Click(sender As Object, e As EventArgs) Handles btnBackToLoansList.Click
        Me.Close()
    End Sub

    Private Sub Add_New_Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' SQL query to retrieve borrower data
        Dim query As String = "
                SELECT 
                    b.BorrowerID, 
                    CONCAT(
                        n.LastName, ', ', 
                        n.FirstName, ' ', 
                        n.MiddleName, ' ', 
                        CASE 
                            WHEN n.SuffixName IS NULL OR n.SuffixName = 'NA' OR n.SuffixName = 'N/A' THEN '' 
                            ELSE n.SuffixName 
                        END
                    ) AS Name
                FROM 
                    Names n
                INNER JOIN 
                    Borrowers b ON n.NameID = b.NameID;"

        ' Create a new SQL connection
        Using connection As New SqlConnection(connectionString)
            ' Create a new SQL command
            Dim command As New SqlCommand(query, connection)

            Try
                ' Open the connection
                connection.Open()

                ' Execute the query and retrieve the data
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Loop through the results and add each name to the ComboBox
                While reader.Read()
                    ' Get the full name from the "Name" column of the query
                    Dim fullName As String = reader("Name").ToString()

                    ' Add the full name to the ComboBox items
                    cmbAddNewLoanBorrower.Items.Add(fullName)
                End While

                ' Close the reader
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
End Class