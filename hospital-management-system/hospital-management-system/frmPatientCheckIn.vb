Imports System.Data.OleDb
Public Class frmPatientCheckIn
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPatient.TextChanged
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
        txtVisit.SelectedIndex = -1

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtFullname.Text = "" Or txtHealthSta.Text = "" Or txtPatient.Text = "" Or txtVisit.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to Check in Patient.", "Patient Check In", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

        End If
    End Sub
End Class