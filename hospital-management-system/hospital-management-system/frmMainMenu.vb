Imports System.Data.OleDb
Public Class frmMainMenu
    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Guna2VProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2VProgressBar1.ValueChanged

    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        Me.Hide()
        frmStaffManagement.Show()

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        Me.Hide()
        frmPatients.Show()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Me.Hide()
        frmStaffManagement.Show()
    End Sub
    Private Sub COUNTDOCS()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableStaff WHERE Designation='Doctor'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    Me.numDocs.Text = "" + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub
    Private Sub COUNTPatients()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableStaff WHERE Designation='Doctor'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    Me.numDocs.Text = "" + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub
    Private Sub CountStaff()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    Me.numStaff.Text = "" + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COUNTDOCS()
        CountStaff()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Me.Hide()
        frmAddStaff.Show()
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Me.Hide()
        frmUserManagement.Show()

    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        Me.Hide()
        frmPatients.Show()

    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        Me.Hide()
        frmPharmacyManagement.Show()

    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        Me.Hide()
        frmReports.Show()
    End Sub

    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) Handles GunaButton12.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

    End Sub
End Class