Imports System.Data.OleDb
Public Class frmUserRegistration
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

    End Sub
    Private Sub GenerateID()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim userID As String = currentDateTime.ToString("yyyy-MM-dd-HHmm-ss")
        txtUserID.Text = userID

    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUserID.Text = "" Or txtFullname.Text = "" Or txtPassword.Text = "" Or txtUsername.Text = "" Or txtUserType.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to register.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtAccessCode.Text = "" Then
            MessageBox.Show("Please fill in the Access Code to Create Account.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAccessCode.Focus()

        Else
            Dim sqlSearch As String = "select * from tableUsers where UserID='" & txtUserID.Text & "' OR @Username = '" & txtUsername.Text & "'"
            Dim conSearch As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmdSearch As New OleDbCommand(sqlSearch, conSearch)
            conSearch.Open()
            Dim rdr As OleDbDataReader = cmdSearch.ExecuteReader()
            If rdr.HasRows Then
                MessageBox.Show("Another User with similar details is already in the system.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If txtAccessCode.Text = "2024" Then

                    Dim sql1 As String = "insert into tableUsers (UserID,Usertype,Fullname,@Username,@Password)  values('" & txtUserID.Text & "' ,'" & txtUserType.Text & "','" & txtFullname.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')"
                    Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
                    Dim cmd1 As New OleDbCommand(sql1, con1)
                    con1.Open()
                    cmd1.ExecuteNonQuery()
                    MessageBox.Show("You have succesfully registered as a new user.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con1.Close()
                    txtAccessCode.Clear()
                    txtFullname.Clear()
                    txtPassword.Clear()
                    txtUserID.Clear()
                    txtUsername.Clear()
                    txtUserType.SelectedIndex = -1
                    GenerateID()
                Else
                    MessageBox.Show("Please fill in the Correct Access Code to Create Account.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAccessCode.Focus()



                End If
            End If
        End If

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub frmUserRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        GenerateID()
    End Sub
End Class