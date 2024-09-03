Imports System.Data.OleDb
Public Class frmPatientCheckOut
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conSearch As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        Dim sqlUpdate As String = "update tableChecks set HealthStatus='" & txtHealthSta.Text & "',Status='" & "Checked Out" & "' where ID='" & txtPatient.Text & "'"
        Dim q1 As String = "update tablePatient set HealthStatus='" & txtHealthSta.Text & "' where PatientID='" & txtPatient.Text & "'"
        conSearch.Open()
        Dim cmdUpdate As New OleDbCommand(sqlUpdate, conSearch)
        Dim q2 As New OleDbCommand(q1, conSearch)
        cmdUpdate.ExecuteNonQuery()
        q2.ExecuteNonQuery()
        MessageBox.Show("Patient  has been successfully Check Out.", "Patient Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conSearch.Close()
        txtFullname.Clear()
        txtHealthSta.Clear()
        txtPatient.Clear()
    End Sub

    Private Sub txtPatient_TextChanged(sender As Object, e As EventArgs) Handles txtPatient.TextChanged
        Dim sql As String = "select * from tablePatient where PatientID = '" & txtPatient.Text & "'"
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        Dim cmd As New OleDbCommand(sql, con)
        con.Open()
        Dim rdr As OleDbDataReader = cmd.ExecuteReader()
        While rdr.Read
            If rdr.HasRows Then
                txtPatient.Text = rdr.Item(0).ToString
                txtFullname.Text = rdr.Item(1).ToString

            End If
        End While
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        txtFullname.Clear()
        txtHealthSta.Clear()
        txtPatient.Clear()

    End Sub
End Class