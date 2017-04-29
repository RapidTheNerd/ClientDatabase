<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AddressBookDataSet = New WindowsApplication15.AddressBookDataSet()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsTableAdapter = New WindowsApplication15.AddressBookDataSetTableAdapters.tblContactsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication15.AddressBookDataSetTableAdapters.TableAdapterManager()
        Me.TblContactsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblContactsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAddress3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblContactsBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddressBookDataSet
        '
        Me.AddressBookDataSet.DataSetName = "AddressBookDataSet"
        Me.AddressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblContactsBindingSource
        '
        Me.TblContactsBindingSource.DataMember = "tblContacts"
        Me.TblContactsBindingSource.DataSource = Me.AddressBookDataSet
        '
        'TblContactsTableAdapter
        '
        Me.TblContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblContactsTableAdapter = Me.TblContactsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication15.AddressBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblContactsBindingNavigator
        '
        Me.TblContactsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblContactsBindingNavigator.BindingSource = Me.TblContactsBindingSource
        Me.TblContactsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblContactsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblContactsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblContactsBindingNavigatorSaveItem})
        Me.TblContactsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblContactsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblContactsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblContactsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblContactsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblContactsBindingNavigator.Name = "TblContactsBindingNavigator"
        Me.TblContactsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblContactsBindingNavigator.Size = New System.Drawing.Size(542, 25)
        Me.TblContactsBindingNavigator.TabIndex = 0
        Me.TblContactsBindingNavigator.Text = "BindingNavigator1"
        Me.TblContactsBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblContactsBindingNavigatorSaveItem
        '
        Me.TblContactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblContactsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblContactsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblContactsBindingNavigatorSaveItem.Name = "TblContactsBindingNavigatorSaveItem"
        Me.TblContactsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblContactsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(93, 44)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(93, 89)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 4
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(27, 518)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 5
        Me.btnLast.Text = "<<"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(134, 518)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Location = New System.Drawing.Point(432, 518)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(75, 23)
        Me.BtnFirst.TabIndex = 8
        Me.BtnFirst.Text = ">>"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(325, 518)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 7
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(397, 47)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(97, 42)
        Me.btnAddNew.TabIndex = 9
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(397, 106)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(97, 42)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(397, 167)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(97, 42)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(397, 288)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 42)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(397, 227)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 42)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(93, 128)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(150, 20)
        Me.txtAddress1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Address Line 1"
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(93, 167)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(150, 20)
        Me.txtAddress2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Address Line 2"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(93, 282)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Email"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(93, 243)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(150, 20)
        Me.txtPostcode.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Postcode"
        '
        'txtAddress3
        '
        Me.txtAddress3.Location = New System.Drawing.Point(93, 204)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.Size = New System.Drawing.Size(150, 20)
        Me.txtAddress3.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Address Line 3"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(93, 323)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(279, 167)
        Me.txtNotes.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Notes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(542, 553)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblContactsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblContactsBindingNavigator.ResumeLayout(False)
        Me.TblContactsBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddressBookDataSet As WindowsApplication15.AddressBookDataSet
    Friend WithEvents TblContactsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblContactsTableAdapter As WindowsApplication15.AddressBookDataSetTableAdapters.tblContactsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication15.AddressBookDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblContactsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblContactsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
