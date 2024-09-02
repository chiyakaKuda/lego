<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatients
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatients))
        Me.FormSkin1 = New FlatUI.FormSkin()
        Me.PatientsData = New Guna.UI.WinForms.GunaDataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCheckOut = New Guna.UI.WinForms.GunaButton()
        Me.btnCheckIn = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.txtCurrentSta = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtRelation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhoneKin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNextofKin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCurrentMed = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PatientsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.PatientsData)
        Me.FormSkin1.Controls.Add(Me.Guna2GroupBox1)
        Me.FormSkin1.Controls.Add(Me.btnClear)
        Me.FormSkin1.Controls.Add(Me.btnDelete)
        Me.FormSkin1.Controls.Add(Me.btnUpdate)
        Me.FormSkin1.Controls.Add(Me.btnAdd)
        Me.FormSkin1.Controls.Add(Me.txtCurrentSta)
        Me.FormSkin1.Controls.Add(Me.txtGender)
        Me.FormSkin1.Controls.Add(Me.txtRelation)
        Me.FormSkin1.Controls.Add(Me.txtPhoneKin)
        Me.FormSkin1.Controls.Add(Me.txtNextofKin)
        Me.FormSkin1.Controls.Add(Me.txtCurrentMed)
        Me.FormSkin1.Controls.Add(Me.txtAddress)
        Me.FormSkin1.Controls.Add(Me.txtPhone)
        Me.FormSkin1.Controls.Add(Me.txtFullname)
        Me.FormSkin1.Controls.Add(Me.txtID)
        Me.FormSkin1.Controls.Add(Me.Label10)
        Me.FormSkin1.Controls.Add(Me.Label9)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.GunaControlBox3)
        Me.FormSkin1.Controls.Add(Me.GunaControlBox2)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.ForeColor = System.Drawing.Color.White
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1585, 927)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Patient Registartion && Management"
        '
        'PatientsData
        '
        Me.PatientsData.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.PatientsData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PatientsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PatientsData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PatientsData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PatientsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.PatientsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientsData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PatientsData.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PatientsData.DefaultCellStyle = DataGridViewCellStyle3
        Me.PatientsData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PatientsData.EnableHeadersVisualStyles = False
        Me.PatientsData.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PatientsData.Location = New System.Drawing.Point(3, 440)
        Me.PatientsData.Name = "PatientsData"
        Me.PatientsData.RowHeadersVisible = False
        Me.PatientsData.RowTemplate.Height = 28
        Me.PatientsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PatientsData.Size = New System.Drawing.Size(1579, 475)
        Me.PatientsData.TabIndex = 204
        Me.PatientsData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.PatientsData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PatientsData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PatientsData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.PatientsData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PatientsData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PatientsData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PatientsData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PatientsData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PatientsData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PatientsData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PatientsData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PatientsData.ThemeStyle.HeaderStyle.Height = 25
        Me.PatientsData.ThemeStyle.ReadOnly = False
        Me.PatientsData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PatientsData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.PatientsData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.PatientsData.ThemeStyle.RowsStyle.Height = 28
        Me.PatientsData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PatientsData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.txtSearch)
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCheckOut)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCheckIn)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1134, 74)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(439, 360)
        Me.Guna2GroupBox1.TabIndex = 42
        Me.Guna2GroupBox1.Text = " Action Center"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderRadius = 9
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(37, 237)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search ID, Name, Next of Kin,Phone Number"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(384, 45)
        Me.txtSearch.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(33, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 21)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Search Patient"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.AnimationHoverSpeed = 0.07!
        Me.btnCheckOut.AnimationSpeed = 0.03!
        Me.btnCheckOut.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCheckOut.BorderColor = System.Drawing.Color.Black
        Me.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCheckOut.FocusedColor = System.Drawing.Color.Empty
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Image = Nothing
        Me.btnCheckOut.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCheckOut.Location = New System.Drawing.Point(267, 59)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnCheckOut.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCheckOut.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckOut.OnHoverImage = Nothing
        Me.btnCheckOut.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckOut.Radius = 12
        Me.btnCheckOut.Size = New System.Drawing.Size(154, 68)
        Me.btnCheckOut.TabIndex = 44
        Me.btnCheckOut.Text = "Check Out Patient"
        Me.btnCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCheckIn
        '
        Me.btnCheckIn.AnimationHoverSpeed = 0.07!
        Me.btnCheckIn.AnimationSpeed = 0.03!
        Me.btnCheckIn.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCheckIn.BorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCheckIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnCheckIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Image = Nothing
        Me.btnCheckIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCheckIn.Location = New System.Drawing.Point(37, 59)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnCheckIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCheckIn.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCheckIn.OnHoverImage = Nothing
        Me.btnCheckIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnCheckIn.Radius = 12
        Me.btnCheckIn.Size = New System.Drawing.Size(154, 68)
        Me.btnCheckIn.TabIndex = 43
        Me.btnCheckIn.Text = "Check In Patient"
        Me.btnCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.OrangeRed
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.Location = New System.Drawing.Point(196, 387)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Radius = 12
        Me.btnClear.Size = New System.Drawing.Size(130, 47)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "Clear Details"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.OrangeRed
        Me.btnDelete.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Nothing
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.Location = New System.Drawing.Point(332, 387)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Radius = 12
        Me.btnDelete.Size = New System.Drawing.Size(143, 47)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Remove Patient"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdate
        '
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.Location = New System.Drawing.Point(768, 387)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 12
        Me.btnUpdate.Size = New System.Drawing.Size(130, 47)
        Me.btnUpdate.TabIndex = 39
        Me.btnUpdate.Text = "Update Details"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.AnimationHoverSpeed = 0.07!
        Me.btnAdd.AnimationSpeed = 0.03!
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAdd.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Nothing
        Me.btnAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdd.Location = New System.Drawing.Point(942, 387)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Radius = 12
        Me.btnAdd.Size = New System.Drawing.Size(130, 47)
        Me.btnAdd.TabIndex = 38
        Me.btnAdd.Text = "Add Patient"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentSta
        '
        Me.txtCurrentSta.BackColor = System.Drawing.Color.Transparent
        Me.txtCurrentSta.BorderRadius = 9
        Me.txtCurrentSta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtCurrentSta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCurrentSta.FocusedColor = System.Drawing.Color.Empty
        Me.txtCurrentSta.FocusedState.Parent = Me.txtCurrentSta
        Me.txtCurrentSta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentSta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtCurrentSta.FormattingEnabled = True
        Me.txtCurrentSta.HoverState.Parent = Me.txtCurrentSta
        Me.txtCurrentSta.ItemHeight = 30
        Me.txtCurrentSta.Items.AddRange(New Object() {"Weak", "Normal", "Strong"})
        Me.txtCurrentSta.ItemsAppearance.Parent = Me.txtCurrentSta
        Me.txtCurrentSta.Location = New System.Drawing.Point(766, 137)
        Me.txtCurrentSta.Name = "txtCurrentSta"
        Me.txtCurrentSta.ShadowDecoration.Parent = Me.txtCurrentSta
        Me.txtCurrentSta.Size = New System.Drawing.Size(306, 36)
        Me.txtCurrentSta.TabIndex = 37
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.Transparent
        Me.txtGender.BorderRadius = 9
        Me.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.FocusedColor = System.Drawing.Color.Empty
        Me.txtGender.FocusedState.Parent = Me.txtGender
        Me.txtGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.HoverState.Parent = Me.txtGender
        Me.txtGender.ItemHeight = 30
        Me.txtGender.Items.AddRange(New Object() {"Male ", "Female"})
        Me.txtGender.ItemsAppearance.Parent = Me.txtGender
        Me.txtGender.Location = New System.Drawing.Point(201, 194)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ShadowDecoration.Parent = Me.txtGender
        Me.txtGender.Size = New System.Drawing.Size(274, 36)
        Me.txtGender.TabIndex = 36
        '
        'txtRelation
        '
        Me.txtRelation.BorderRadius = 9
        Me.txtRelation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRelation.DefaultText = ""
        Me.txtRelation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRelation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRelation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRelation.DisabledState.Parent = Me.txtRelation
        Me.txtRelation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRelation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRelation.FocusedState.Parent = Me.txtRelation
        Me.txtRelation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRelation.HoverState.Parent = Me.txtRelation
        Me.txtRelation.Location = New System.Drawing.Point(766, 335)
        Me.txtRelation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRelation.Name = "txtRelation"
        Me.txtRelation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRelation.PlaceholderText = ""
        Me.txtRelation.SelectedText = ""
        Me.txtRelation.ShadowDecoration.Parent = Me.txtRelation
        Me.txtRelation.Size = New System.Drawing.Size(306, 36)
        Me.txtRelation.TabIndex = 35
        '
        'txtPhoneKin
        '
        Me.txtPhoneKin.BorderRadius = 9
        Me.txtPhoneKin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneKin.DefaultText = ""
        Me.txtPhoneKin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneKin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneKin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneKin.DisabledState.Parent = Me.txtPhoneKin
        Me.txtPhoneKin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneKin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneKin.FocusedState.Parent = Me.txtPhoneKin
        Me.txtPhoneKin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneKin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneKin.HoverState.Parent = Me.txtPhoneKin
        Me.txtPhoneKin.Location = New System.Drawing.Point(766, 257)
        Me.txtPhoneKin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhoneKin.Name = "txtPhoneKin"
        Me.txtPhoneKin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneKin.PlaceholderText = ""
        Me.txtPhoneKin.SelectedText = ""
        Me.txtPhoneKin.ShadowDecoration.Parent = Me.txtPhoneKin
        Me.txtPhoneKin.Size = New System.Drawing.Size(306, 36)
        Me.txtPhoneKin.TabIndex = 34
        '
        'txtNextofKin
        '
        Me.txtNextofKin.BorderRadius = 9
        Me.txtNextofKin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNextofKin.DefaultText = ""
        Me.txtNextofKin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNextofKin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNextofKin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNextofKin.DisabledState.Parent = Me.txtNextofKin
        Me.txtNextofKin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNextofKin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNextofKin.FocusedState.Parent = Me.txtNextofKin
        Me.txtNextofKin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNextofKin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNextofKin.HoverState.Parent = Me.txtNextofKin
        Me.txtNextofKin.Location = New System.Drawing.Point(766, 194)
        Me.txtNextofKin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNextofKin.Name = "txtNextofKin"
        Me.txtNextofKin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNextofKin.PlaceholderText = ""
        Me.txtNextofKin.SelectedText = ""
        Me.txtNextofKin.ShadowDecoration.Parent = Me.txtNextofKin
        Me.txtNextofKin.Size = New System.Drawing.Size(306, 36)
        Me.txtNextofKin.TabIndex = 33
        '
        'txtCurrentMed
        '
        Me.txtCurrentMed.BorderRadius = 9
        Me.txtCurrentMed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCurrentMed.DefaultText = ""
        Me.txtCurrentMed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCurrentMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCurrentMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentMed.DisabledState.Parent = Me.txtCurrentMed
        Me.txtCurrentMed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCurrentMed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentMed.FocusedState.Parent = Me.txtCurrentMed
        Me.txtCurrentMed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentMed.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCurrentMed.HoverState.Parent = Me.txtCurrentMed
        Me.txtCurrentMed.Location = New System.Drawing.Point(766, 74)
        Me.txtCurrentMed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentMed.Name = "txtCurrentMed"
        Me.txtCurrentMed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCurrentMed.PlaceholderText = ""
        Me.txtCurrentMed.SelectedText = ""
        Me.txtCurrentMed.ShadowDecoration.Parent = Me.txtCurrentMed
        Me.txtCurrentMed.Size = New System.Drawing.Size(306, 36)
        Me.txtCurrentMed.TabIndex = 32
        '
        'txtAddress
        '
        Me.txtAddress.BorderRadius = 9
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(201, 320)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(274, 36)
        Me.txtAddress.TabIndex = 31
        '
        'txtPhone
        '
        Me.txtPhone.BorderRadius = 9
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.DisabledState.Parent = Me.txtPhone
        Me.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.FocusedState.Parent = Me.txtPhone
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.HoverState.Parent = Me.txtPhone
        Me.txtPhone.Location = New System.Drawing.Point(201, 257)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.PlaceholderText = ""
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.ShadowDecoration.Parent = Me.txtPhone
        Me.txtPhone.Size = New System.Drawing.Size(274, 36)
        Me.txtPhone.TabIndex = 30
        '
        'txtFullname
        '
        Me.txtFullname.BorderRadius = 9
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.DefaultText = ""
        Me.txtFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullname.DisabledState.Parent = Me.txtFullname
        Me.txtFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullname.FocusedState.Parent = Me.txtFullname
        Me.txtFullname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullname.HoverState.Parent = Me.txtFullname
        Me.txtFullname.Location = New System.Drawing.Point(201, 137)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullname.PlaceholderText = ""
        Me.txtFullname.SelectedText = ""
        Me.txtFullname.ShadowDecoration.Parent = Me.txtFullname
        Me.txtFullname.Size = New System.Drawing.Size(274, 36)
        Me.txtFullname.TabIndex = 29
        '
        'txtID
        '
        Me.txtID.BorderRadius = 9
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.Parent = Me.txtID
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.FocusedState.Parent = Me.txtID
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.HoverState.Parent = Me.txtID
        Me.txtID.Location = New System.Drawing.Point(201, 79)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderText = ""
        Me.txtID.SelectedText = ""
        Me.txtID.ShadowDecoration.Parent = Me.txtID
        Me.txtID.Size = New System.Drawing.Size(274, 36)
        Me.txtID.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(517, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 22)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Health Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(517, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 22)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Current Medication"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(517, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Relationship"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(517, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(517, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Next of Kin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 22)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 22)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fullname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Patient ID"
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaControlBox3.IconColor = System.Drawing.Color.White
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(1535, -5)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(50, 54)
        Me.GunaControlBox3.TabIndex = 17
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1484, -5)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(50, 54)
        Me.GunaControlBox2.TabIndex = 16
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 927)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPatients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPatients"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PatientsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FlatUI.FormSkin
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCurrentSta As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtRelation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhoneKin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNextofKin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCurrentMed As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCheckOut As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCheckIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents PatientsData As Guna.UI.WinForms.GunaDataGridView
End Class
