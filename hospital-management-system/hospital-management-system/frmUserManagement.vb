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

    End Sub

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
End Class