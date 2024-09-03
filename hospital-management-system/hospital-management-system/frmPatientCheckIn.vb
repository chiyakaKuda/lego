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
            Dim sqlSearch As String = "select * from tableChecks where ID='" & txtPatient.Text & "'"
            Dim conSearch As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmdSearch As New OleDbCommand(sqlSearch, conSearch)
            conSearch.Open()
            Dim rdr As OleDbDataReader = cmdSearch.ExecuteReader()
            If rdr.HasRows Then
                Dim sqlUpdate As String = "update tableChecks set HealthStatus='" & txtHealthSta.Text & "',Status='" & "Checked In" & "' where ID='" & txtPatient.Text & "'"
                Dim q1 As String = "update tablePatient set HealthStatus='" & txtHealthSta.Text & "' where PatientID='" & txtPatient.Text & "'"
                Dim cmdUpdate As New OleDbCommand(sqlUpdate, conSearch)
                Dim q2 As New OleDbCommand(q1, conSearch)
                q2.ExecuteNonQuery()
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("You have succesfully CheckIn as a new patient.", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conSearch.Close()
            Else
                Dim sql1 As String = "insert into tableChecks (ID,Fullname,Visit,Onset,HealthStatus,Status)  values('" & txtPatient.Text & "' ,'" & txtFullname.Text & "','" & txtVisit.Text & "','" & txtDate.Value & "','" & txtHealthSta.Text & "','" & "Checked In" & "')"
                Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
                Dim cmd1 As New OleDbCommand(sql1, con1)
                con1.Open()
                Dim q1 As String = "update tablePatient set HealthStatus='" & txtHealthSta.Text & "' where PatientID='" & txtPatient.Text & "'"
                Dim q2 As New OleDbCommand(q1, conSearch)
                cmd1.ExecuteNonQuery()
                q2.ExecuteNonQuery()
                MessageBox.Show("You have succesfully CheckIn as a new patient.", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con1.Close()

            End If
            GunaButton1_Click(sender, e)

        End If

    End Sub

    Private Sub GunaControlBox3_Click(sender As Object, e As EventArgs) Handles GunaControlBox3.Click
        Me.Hide()
        frmPatients.Show()

    End Sub
End Class