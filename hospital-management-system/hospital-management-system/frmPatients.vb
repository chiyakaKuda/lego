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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
    Private Sub GenerateID()
        Dim currentDateTime As DateTime = DateTime.Now
        Dim userID As String = currentDateTime.ToString("yyyy-MM-dd-HHmm-ss")
        txtID.Text = userID

    End Sub

    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles Me.Load
        GenerateID()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Me.Hide()
        frmPatientCheckIn.Show()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Me.Hide()
        frmPatientCheckOut.Show()
    End Sub
End Class