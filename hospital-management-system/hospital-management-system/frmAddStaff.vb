Imports System.Data.OleDb
Public Class frmAddStaff
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddress.Clear()
        txtDate.Value = DateAndTime.Today
        txtDesignation.SelectedIndex = -1
        txtEmail.Clear()
        txtFullname.Clear()
        txtGender.SelectedIndex = -1
        txtPhone.Clear()
        GenerateID()

    End Sub

    Private Sub FlatGroupBox1_Click(sender As Object, e As EventArgs) Handles FlatGroupBox1.Click

    End Sub
    Private Sub GenerateID()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim userID As String = currentDateTime.ToString("yyyy-MM-dd-HHmm-ss")
        txtStaffID.Text = userID

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAddress.Text = "" Or txtDesignation.Text = "" Or txtEmail.Text = "" Or txtFullname.Text = "" Or txtGender.Text = "" Or txtPhone.Text = "" Or txtStaffID.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to register.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim sqlSearch As String = "select * from tableStaff where StaffID='" & txtStaffID.Text & "' AND Fullname = '" & txtFullname.Text & "'"
            Dim conSearch As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmdSearch As New OleDbCommand(sqlSearch, conSearch)
            conSearch.Open()
            Dim rdr As OleDbDataReader = cmdSearch.ExecuteReader()
            If rdr.HasRows Then
                MessageBox.Show("Another User with similar details is already in the system.", "Staff Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim sql1 As String = "insert into tableStaff (StaffID,Fullname,Email,Gender,Phone,DOB,Designation,Address)  values('" & txtStaffID.Text & "' ,'" & txtFullname.Text & "','" & txtEmail.Text & "','" & txtGender.Text & "','" & txtPhone.Text & "','" & txtDate.Value & "','" & txtDesignation.Text & "','" & txtAddress.Text & "')"
                Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
                Dim cmd1 As New OleDbCommand(sql1, con1)
                con1.Open()
                cmd1.ExecuteNonQuery()
                MessageBox.Show("You have succesfully registered as a new Staff Member.", "Staff Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con1.Close()
                txtAddress.Clear()
                txtFullname.Clear()
                txtDate.Value = Date.Now
                txtDesignation.SelectedIndex = -1
                txtEmail.Clear()
                txtGender.SelectedIndex = -1
                txtPhone.Clear()
                GenerateID()

            End If
        End If



    End Sub

    Private Sub frmAddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateID()
    End Sub
End Class