Imports System.Data.OleDb
Public Class frmUpdateStaff
    Private Sub frmUpdateStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click

    End Sub

    Private Sub GunaControlBox3_Click(sender As Object, e As EventArgs) Handles GunaControlBox3.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String = "select * from tableStaff where Gender ='" & txtGen.Text & "' or Designation= '" & txtDes.Text & "'"
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        con.Open()
        Dim adptr As New OleDbDataAdapter(sql, con)
        Dim ds As New DataTable
        adptr.Fill(ds)
        StaffData.DataSource = ds
        con.Close()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If txtAddress.Text = "" Or txtDesignation.Text = "" Or txtEmail.Text = "" Or txtFullname.Text = "" Or txtGender.Text = "" Or txtPhone.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to update details.", "Staff Registration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim sqlUpdate As String = "update tableStaff set Fullname='" & txtFullname.Text & "',Email='" & txtEmail.Text & "',Gender='" & txtGender.Text & "',Phone ='" & txtPhone.Text & "', Designation ='" & txtDesignation.Text & "',Address ='" & txtAddress.Text & "' where StaffID='" & Label7.Text & "'"
            Dim cmdUpdate As New OleDbCommand(sqlUpdate, con)
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Staff Details  has been successfully updated.", "Staff Admission", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            populate()
            btnClear_Click(sender, e)
        End If

    End Sub

    Private Sub populate()
        Dim sql As String = "select * from tableStaff"
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        con.Open()
        Dim adptr As New OleDbDataAdapter(sql, con)
        Dim ds As New DataTable
        adptr.Fill(ds)
        StaffData.DataSource = ds
        con.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddress.Text = ""
        txtDesignation.SelectedIndex = -1
        txtEmail.Text = ""
        txtFullname.Text = ""
        txtGender.SelectedIndex = -1
        txtPhone.Text = ""
    End Sub

    Private Sub StaffData_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles StaffData.RowStateChanged
        Try
            For i As Integer = 0 To StaffData.Rows.Count - 1
                Label7.Text = StaffData.SelectedRows(i).Cells(0).Value.ToString
                txtFullname.Text = StaffData.SelectedRows(i).Cells(1).Value.ToString
                txtGender.Text = StaffData.SelectedRows(i).Cells(3).Value.ToString
                txtEmail.Text = StaffData.SelectedRows(i).Cells(2).Value.ToString
                txtPhone.Text = StaffData.SelectedRows(i).Cells(4).Value.ToString
                txtDesignation.Text = StaffData.SelectedRows(i).Cells(6).Value.ToString
                txtAddress.Text = StaffData.SelectedRows(i).Cells(7).Value.ToString

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            populate()

        Else
            Dim sql As String = "select * from tableStaff where StaffID like '%" & txtSearch.Text & "%' or Fullname like'%" & txtSearch.Text & "%' or Phone like '%" & txtSearch.Text & "%' or  Phone like '%" & txtSearch.Text & "%'"
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim adptr As New OleDbDataAdapter(sql, con)
            Dim ds As New DataTable
            adptr.Fill(ds)
            StaffData.DataSource = ds
            con.Close()
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        txtDes.SelectedIndex = -1
        txtGen.SelectedIndex = -1

    End Sub
End Class