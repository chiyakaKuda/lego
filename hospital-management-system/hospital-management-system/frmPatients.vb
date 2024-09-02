Imports System.Data.OleDb
Public Class frmPatients
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddress.Clear()
        txtCurrentMed.Clear()
        txtCurrentSta.SelectedIndex = -1
        txtFullname.Clear()
        txtGender.SelectedIndex = -1
        txtID.Clear()
        txtNextofKin.Clear()
        txtRelation.Clear()
        txtSearch.Clear()
        GenerateID()
    End Sub

    Private Sub Populate()
        Dim sql As String = "select * from tablePatient"
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        con.Open()
        Dim adptr As New OleDbDataAdapter(sql, con)
        Dim ds As New DataTable
        adptr.Fill(ds)
        PatientsData.DataSource = ds
        con.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAddress.Text = "" Or txtCurrentMed.Text = "" Or txtCurrentSta.Text = "" Or txtFullname.Text = "" Or txtGender.Text = "" Or txtID.Text = "" Or txtNextofKin.Text = "" Or txtPhone.Text = "" Or txtPhoneKin.Text = "" Or txtRelation.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to add patient.", "Patient Admission", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim sql1 As String = "insert into tablePatient (PatientID,Fullname,Gender,Phone,Address,CurrentMed,HealthStatus,NextofKin,PhoneNumber,Relationship)  values('" & txtID.Text & "' ,'" & txtFullname.Text & "','" & txtGender.Text & "','" & txtPhone.Text & "','" & txtPhone.Text & "','" & txtAddress.Text & "','" & txtCurrentMed.Text & "','" & txtCurrentSta.Text & "','" & txtNextofKin.Text & "','" & txtPhoneKin.Text & "','" & txtRelation.Text & "')"
            Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmd1 As New OleDbCommand(sql1, con1)
            con1.Open()
            cmd1.ExecuteNonQuery()
            MessageBox.Show("You have succesfully added   a new Patient.", "Patient Admission", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con1.Close()
            btnClear_Click(sender, e)
            GenerateID()
        End If
    End Sub
    Private Sub GenerateID()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim userID As String = currentDateTime.ToString("yyyy-MM-dd-HHmm-ss")
        txtID.Text = userID

    End Sub

    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles Me.Load
        GenerateID()
        Populate()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Me.Hide()
        frmPatientCheckIn.Show()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Me.Hide()
        frmPatientCheckOut.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAddress.Text = "" Or txtCurrentMed.Text = "" Or txtCurrentSta.Text = "" Or txtFullname.Text = "" Or txtGender.Text = "" Or txtID.Text = "" Or txtNextofKin.Text = "" Or txtPhone.Text = "" Or txtPhoneKin.Text = "" Or txtRelation.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to add patient.", "Patient Admission", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim sqlUpdate As String = "update tablePatient set Fullname='" & txtFullname.Text & "',Gender='" & txtGender.Text & "',Phone='" & txtPhone.Text & "',Address ='" & txtAddress.Text & "', CurrentMed ='" & txtCurrentMed.Text & "',HealthStatus ='" & txtCurrentSta.Text & "',NextofKin ='" & txtNextofKin.Text & "' , PhoneNumber='" & txtPhoneKin.Text & "' ,Relationship ='" & txtRelation.Text & "'where PatientID='" & txtID.Text & "'"
            Dim cmdUpdate As New OleDbCommand(sqlUpdate, con)
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Patient Details  has been successfully updated.", "Patient Admission", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Populate()
            btnClear_Click(sender, e)

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim x As DialogResult
        x = MessageBox.Show("Are you sure you want to Remove this Patient", "Patient Admission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Dim sql As String = "delete from tablePatient where PatientID='" & txtID.Text & "'"
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmd As New OleDbCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Patient Succesfully Removed ", "Patient Admission", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClear_Click(sender, e)
            Populate()
            con.Close()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            Populate()

        Else
            Dim sql As String = "select * from tablePatient where PatientID like '%" & txtSearch.Text & "%' or Fullname like'%" & txtSearch.Text & "%' or NextofKin like '%" & txtSearch.Text & "%' or  Phone like '%" & txtSearch.Text & "%'"
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim adptr As New OleDbDataAdapter(sql, con)
            Dim ds As New DataTable
            adptr.Fill(ds)
            PatientsData.DataSource = ds
            con.Close()
        End If

    End Sub

    Private Sub PatientsData_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles PatientsData.RowStateChanged
        Try
            For i As Integer = 0 To PatientsData.Rows.Count - 1
                txtID.Text = PatientsData.SelectedRows(i).Cells(0).Value.ToString
                txtFullname.Text = PatientsData.SelectedRows(i).Cells(1).Value.ToString
                txtGender.Text = PatientsData.SelectedRows(i).Cells(2).Value.ToString
                txtPhone.Text = PatientsData.SelectedRows(i).Cells(3).Value.ToString
                txtAddress.Text = PatientsData.SelectedRows(i).Cells(4).Value.ToString
                txtCurrentMed.Text = PatientsData.SelectedRows(i).Cells(5).Value.ToString
                txtCurrentSta.Text = PatientsData.SelectedRows(i).Cells(6).Value.ToString
                txtNextofKin.Text = PatientsData.SelectedRows(i).Cells(7).Value.ToString
                txtPhoneKin.Text = PatientsData.SelectedRows(i).Cells(8).Value.ToString
                txtRelation.Text = PatientsData.SelectedRows(i).Cells(9).Value.ToString
            Next

        Catch ex As Exception

        End Try
    End Sub
End Class