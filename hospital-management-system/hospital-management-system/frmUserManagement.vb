Imports System.Data.OleDb

Public Class frmUserManagement
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
    Private Sub Populate()
        Dim sql As String = "select UserID,Fullname,Usertype,@Username from tableUsers"
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        con.Open()
        Dim adptr As New OleDbDataAdapter(sql, con)
        Dim ds As New DataTable
        adptr.Fill(ds)
        UserData.DataSource = ds
        con.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAccessCode.Text = "2024" Then
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim sqlUpdate As String = "update tableUsers set Fullname='" & txtFullname.Text & "',UserType='" & txtUsertype.Text & "',@Username='" & txtUsername.Text & "' where UserID='" & txtUserID.Text & "'"
            Dim cmdUpdate As New OleDbCommand(sqlUpdate, con)
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("User Details details has been successfully updated.", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            txtAccessCode.Clear()
            txtFullname.Clear()
            txtUserID.Clear()
            txtUsername.Clear()
            txtUsertype.SelectedIndex = -1
            Populate()
        Else
            MessageBox.Show("Please fill in the Correct Access Code to Update Account  .", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAccessCode.Focus()

        End If

    End Sub

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    Private Sub UserData_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles UserData.RowStateChanged
        Try
            For i As Integer = 0 To UserData.Rows.Count - 1
                txtUserID.Text = UserData.SelectedRows(i).Cells(0).Value.ToString
                txtFullname.Text = UserData.SelectedRows(i).Cells(1).Value.ToString
                txtUsertype.Text = UserData.SelectedRows(i).Cells(2).Value.ToString
                txtUsername.Text = UserData.SelectedRows(i).Cells(3).Value.ToString


            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAccessCode.Text = "2024" Then
            Dim x As DialogResult
            x = MessageBox.Show("Are you sure you want to Remove this User", "User Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = DialogResult.Yes Then
                Dim sql As String = "delete from tableUsers where UserID='" & txtUserID.Text & "'"
                Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
                Dim cmd As New OleDbCommand(sql, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("User Succesfully Removed ", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Populate()
                txtAccessCode.Clear()
                txtFullname.Clear()
                txtUserID.Clear()
                txtUsername.Clear()
                txtUsertype.SelectedIndex = -1

                con.Close()
            End If
        Else

            MessageBox.Show("Please fill in the Correct Access Code to Remove that Account.", "User Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAccessCode.Focus()
        End If
    End Sub
End Class