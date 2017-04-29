Public Class Form1
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String
    Dim MyDocumentsFolder As String
    Dim TheDatabase As String
    Dim FullDatabasePath As String

    Dim MaxRows As Integer

    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String

    Private Sub TblContactsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblContactsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddressBookDataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"

        TheDatabase = "/AddressBook.mdb"
        MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = MyDocumentsFolder & TheDatabase

        dbSource = "Data Source = " & FullDatabasePath
        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = "SELECT * FROM tblContacts"
        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "AddressBook")

        con.Close()

        MaxRows = ds.Tables("AddressBook").Rows.Count

        inc = -1
    End Sub

    Private Sub NavigateRecords()

        txtFirstName.Text = ds.Tables("AddressBook").Rows(inc).Item(1)
        txtSurname.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
        txtAddress1.Text = ds.Tables("AddressBook").Rows(inc).Item(3)
        txtAddress2.Text = ds.Tables("AddressBook").Rows(inc).Item(4)
        txtAddress3.Text = ds.Tables("AddressBook").Rows(inc).Item(5)
        txtPostcode.Text = ds.Tables("AddressBook").Rows(inc).Item(6)
        txtEmail.Text = ds.Tables("AddressBook").Rows(inc).Item(8)
        txtNotes.Text = ds.Tables("AddressBook").Rows(inc).Item(9)

    End Sub

    Private Sub BtnNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnNext.Click
        If inc <> MaxRows - 1 Then

            inc = inc + 1

            NavigateRecords()

        Else

            MessageBox.Show("No More Rows")

        End If
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If inc > 0 Then

            inc = inc - 1

            NavigateRecords()

        ElseIf inc = -1 Then

            MessageBox.Show("No Records Yet")

        ElseIf inc = 0 Then

            MessageBox.Show("First Record")

        End If
    End Sub

    Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        If inc <> 0 Then

            inc = 0

            NavigateRecords()

        End If
    End Sub

    Private Sub BtnFirst_Click(sender As System.Object, e As System.EventArgs) Handles BtnFirst.Click
        If inc <> MaxRows - 1 Then

            inc = MaxRows - 1

            NavigateRecords()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("AddressBook").Rows(inc).Item(1) = txtFirstName.Text
        ds.Tables("AddressBook").Rows(inc).Item(2) = txtSurname.Text
        ds.Tables("AddressBook").Rows(inc).Item(3) = txtAddress1.Text
        ds.Tables("AddressBook").Rows(inc).Item(4) = txtAddress2.Text
        ds.Tables("AddressBook").Rows(inc).Item(5) = txtAddress3.Text
        ds.Tables("AddressBook").Rows(inc).Item(6) = txtPostcode.Text
        ds.Tables("AddressBook").Rows(inc).Item(8) = txtEmail.Text
        ds.Tables("AddressBook").Rows(inc).Item(9) = txtNotes.Text

        da.Update(ds, "AddressBook")

        MessageBox.Show("Data updated")
    End Sub

    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtFirstName.Clear()
        txtSurname.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtAddress3.Clear()
        txtPostcode.Clear()
        txtEmail.Clear()
        txtNotes.Clear()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        inc = 0
        NavigateRecords()
    End Sub

    Private Sub btnCommit_Click(sender As System.Object, e As System.EventArgs) Handles btnCommit.Click
        If inc <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("AddressBook").NewRow()

            dsNewRow.Item("FirstName") = txtFirstName.Text
            dsNewRow.Item("Surname") = txtSurname.Text
            dsNewRow.Item("Address1") = txtAddress1.Text
            dsNewRow.Item("Address2") = txtAddress2.Text
            dsNewRow.Item("Address3") = txtAddress3.Text
            dsNewRow.Item("Postcode") = txtPostcode.Text
            dsNewRow.Item("Email") = txtEmail.Text
            dsNewRow.Item("Notes") = txtNotes.Text

            ds.Tables("AddressBook").Rows.Add(dsNewRow)

            da.Update(ds, "AddressBook")

            MessageBox.Show("New Record added to the Database")

            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True >
            btnDelete.Enabled = True

        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

            MessageBox.Show("Operation Cancelled")
            Exit Sub

        End If

        ds.Tables("AddressBook").Rows(inc).Delete()
        MaxRows = MaxRows - 1

        inc = 0
        da.Update(ds, "AddressBook")
        NavigateRecords()


    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
