<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfiling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfiling))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datePick = New System.Windows.Forms.DateTimePicker()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDno = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtYrSection = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.Location = New System.Drawing.Point(30, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student Profiling "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datePick)
        Me.GroupBox1.Controls.Add(Me.rbtnFemale)
        Me.GroupBox1.Controls.Add(Me.rbtnMale)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.Controls.Add(Me.txtMname)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 238)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'datePick
        '
        Me.datePick.CustomFormat = ""
        Me.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datePick.Location = New System.Drawing.Point(175, 159)
        Me.datePick.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.datePick.Name = "datePick"
        Me.datePick.Size = New System.Drawing.Size(107, 22)
        Me.datePick.TabIndex = 18
        Me.datePick.Value = New Date(2022, 7, 5, 0, 0, 0, 0)
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Location = New System.Drawing.Point(237, 198)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(71, 20)
        Me.rbtnFemale.TabIndex = 9
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Location = New System.Drawing.Point(175, 198)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(55, 20)
        Me.rbtnMale.TabIndex = 8
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Gender:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Birthdate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Last name:"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(175, 93)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(246, 22)
        Me.txtLname.TabIndex = 4
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(175, 63)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(246, 22)
        Me.txtMname.TabIndex = 3
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(175, 35)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(246, 22)
        Me.txtFname.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Middle name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(18, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please fill up the information correctly."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "STUDENT ID NUMBER:"
        '
        'txtIDno
        '
        Me.txtIDno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDno.Location = New System.Drawing.Point(273, 150)
        Me.txtIDno.Name = "txtIDno"
        Me.txtIDno.Size = New System.Drawing.Size(169, 22)
        Me.txtIDno.TabIndex = 1
        Me.txtIDno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtYrSection)
        Me.GroupBox2.Controls.Add(Me.txtCourse)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 441)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 105)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Academic"
        '
        'txtYrSection
        '
        Me.txtYrSection.Location = New System.Drawing.Point(175, 63)
        Me.txtYrSection.MaxLength = 2
        Me.txtYrSection.Name = "txtYrSection"
        Me.txtYrSection.Size = New System.Drawing.Size(94, 22)
        Me.txtYrSection.TabIndex = 9
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(175, 35)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(246, 22)
        Me.txtCourse.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(275, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "example: 4-A"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Year and Section:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Course:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(494, 194)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(883, 548)
        Me.DataGridView1.TabIndex = 6
        Me.DataGridView1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.IndianRed
        Me.lblDate.Location = New System.Drawing.Point(556, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 18)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(472, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.IndianRed
        Me.lblTime.Location = New System.Drawing.Point(556, 40)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(45, 18)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(470, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Time:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tan
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(510, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(112, 39)
        Me.Button2.TabIndex = 11
        Me.Button2.TabStop = False
        Me.Button2.Text = "Records"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1231, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 13
        Me.Button1.TabStop = False
        Me.Button1.Text = "Close"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tan
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(744, 142)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDelete.Size = New System.Drawing.Size(100, 39)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Tan
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(636, 142)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEdit.Size = New System.Drawing.Size(100, 39)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(21, 624)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSave.Size = New System.Drawing.Size(140, 40)
        Me.btnSave.TabIndex = 10
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.IndianRed
        Me.Label9.Location = New System.Drawing.Point(560, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 18)
        Me.Label9.TabIndex = 14
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnDone.FlatAppearance.BorderSize = 0
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDone.Image = CType(resources.GetObject("btnDone.Image"), System.Drawing.Image)
        Me.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDone.Location = New System.Drawing.Point(21, 624)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDone.Size = New System.Drawing.Size(140, 40)
        Me.btnDone.TabIndex = 17
        Me.btnDone.TabStop = False
        Me.btnDone.Text = " Done"
        Me.btnDone.UseVisualStyleBackColor = False
        Me.btnDone.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(470, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ID Number:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.IndianRed
        Me.Label13.Location = New System.Drawing.Point(30, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 25)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Welcome"
        '
        'frmProfiling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1412, 806)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtIDno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProfiling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Education"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIDno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYrSection As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents datePick As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
End Class
