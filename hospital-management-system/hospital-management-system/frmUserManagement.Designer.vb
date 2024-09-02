<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagement))
        Me.txtUserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FormSkin1 = New FlatUI.FormSkin()
        Me.UserData = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtUsertype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtAccessCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.UserData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserID
        '
        Me.txtUserID.BorderRadius = 9
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.DefaultText = ""
        Me.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.DisabledState.Parent = Me.txtUserID
        Me.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.Enabled = False
        Me.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.FocusedState.Parent = Me.txtUserID
        Me.txtUserID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.HoverState.Parent = Me.txtUserID
        Me.txtUserID.Location = New System.Drawing.Point(166, 81)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserID.PlaceholderText = ""
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.ShadowDecoration.Parent = Me.txtUserID
        Me.txtUserID.Size = New System.Drawing.Size(269, 36)
        Me.txtUserID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fullname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(471, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "UserType"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(471, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Username"
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
        Me.txtFullname.Location = New System.Drawing.Point(166, 185)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullname.PlaceholderText = ""
        Me.txtFullname.SelectedText = ""
        Me.txtFullname.ShadowDecoration.Parent = Me.txtFullname
        Me.txtFullname.Size = New System.Drawing.Size(269, 36)
        Me.txtFullname.TabIndex = 5
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.UserData)
        Me.FormSkin1.Controls.Add(Me.txtUsertype)
        Me.FormSkin1.Controls.Add(Me.txtAccessCode)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.btnDelete)
        Me.FormSkin1.Controls.Add(Me.btnUpdate)
        Me.FormSkin1.Controls.Add(Me.GunaControlBox3)
        Me.FormSkin1.Controls.Add(Me.GunaControlBox2)
        Me.FormSkin1.Controls.Add(Me.txtUsername)
        Me.FormSkin1.Controls.Add(Me.txtFullname)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.txtUserID)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.ForeColor = System.Drawing.Color.White
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1007, 619)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "User Management"
        '
        'UserData
        '
        Me.UserData.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.UserData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.UserData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UserData.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserData.DefaultCellStyle = DataGridViewCellStyle3
        Me.UserData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.UserData.EnableHeadersVisualStyles = False
        Me.UserData.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserData.Location = New System.Drawing.Point(3, 361)
        Me.UserData.Name = "UserData"
        Me.UserData.RowHeadersVisible = False
        Me.UserData.RowTemplate.Height = 28
        Me.UserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserData.Size = New System.Drawing.Size(1001, 256)
        Me.UserData.TabIndex = 203
        Me.UserData.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.UserData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.UserData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.UserData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.UserData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.UserData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UserData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.UserData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.UserData.ThemeStyle.HeaderStyle.Height = 25
        Me.UserData.ThemeStyle.ReadOnly = False
        Me.UserData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.UserData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.UserData.ThemeStyle.RowsStyle.Height = 28
        Me.UserData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UserData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'txtUsertype
        '
        Me.txtUsertype.BackColor = System.Drawing.Color.Transparent
        Me.txtUsertype.BorderRadius = 9
        Me.txtUsertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUsertype.FocusedColor = System.Drawing.Color.Empty
        Me.txtUsertype.FocusedState.Parent = Me.txtUsertype
        Me.txtUsertype.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsertype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtUsertype.FormattingEnabled = True
        Me.txtUsertype.HoverState.Parent = Me.txtUsertype
        Me.txtUsertype.ItemHeight = 30
        Me.txtUsertype.Items.AddRange(New Object() {"Admin", "Clerk"})
        Me.txtUsertype.ItemsAppearance.Parent = Me.txtUsertype
        Me.txtUsertype.Location = New System.Drawing.Point(647, 170)
        Me.txtUsertype.Name = "txtUsertype"
        Me.txtUsertype.ShadowDecoration.Parent = Me.txtUsertype
        Me.txtUsertype.Size = New System.Drawing.Size(347, 36)
        Me.txtUsertype.TabIndex = 33
        '
        'txtAccessCode
        '
        Me.txtAccessCode.BorderRadius = 9
        Me.txtAccessCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccessCode.DefaultText = ""
        Me.txtAccessCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAccessCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAccessCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccessCode.DisabledState.Parent = Me.txtAccessCode
        Me.txtAccessCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAccessCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccessCode.FocusedState.Parent = Me.txtAccessCode
        Me.txtAccessCode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAccessCode.HoverState.Parent = Me.txtAccessCode
        Me.txtAccessCode.Location = New System.Drawing.Point(648, 247)
        Me.txtAccessCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAccessCode.Name = "txtAccessCode"
        Me.txtAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccessCode.PlaceholderText = ""
        Me.txtAccessCode.SelectedText = ""
        Me.txtAccessCode.ShadowDecoration.Parent = Me.txtAccessCode
        Me.txtAccessCode.Size = New System.Drawing.Size(346, 36)
        Me.txtAccessCode.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(471, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 21)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Admin Access Code"
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
        Me.btnDelete.Location = New System.Drawing.Point(648, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Radius = 7
        Me.btnDelete.Size = New System.Drawing.Size(141, 33)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "Remove User"
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
        Me.btnUpdate.Location = New System.Drawing.Point(853, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Green
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 7
        Me.btnUpdate.Size = New System.Drawing.Size(141, 33)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update User"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaControlBox3.IconColor = System.Drawing.Color.White
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(957, -6)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(50, 54)
        Me.GunaControlBox3.TabIndex = 27
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(906, -6)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(50, 54)
        Me.GunaControlBox2.TabIndex = 26
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 9
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(647, 81)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(347, 36)
        Me.txtUsername.TabIndex = 7
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 619)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserManagement"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.UserData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FormSkin1 As FlatUI.FormSkin
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents txtUsertype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtAccessCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents UserData As Guna.UI.WinForms.GunaDataGridView
End Class
