Public Class frmStaffManagement
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim generator As New ShiftGenerator(Me)
        generator.GenerateRandomShifts()
        MessageBox.Show("Random shifts have been Generated and inserted into the database.", "Staff Mnagement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '  lbDoctorsM.Text = 
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs)

    End Sub
End Class