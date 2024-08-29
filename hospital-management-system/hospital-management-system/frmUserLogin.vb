Imports System.Data.OleDb

Public Class frmUserLogin
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TxtUsertype.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please fill in the empty fields to login.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim sql As String = "select * from tableUsers where Usertype='" & TxtUsertype.Text & "'AND  @Username ='" & txtUsername.Text & "'and @Password='" & txtPassword.Text & "'"
            Dim cmd As New OleDbCommand(sql, con)
            con.Open()
            Dim rdr As OleDbDataReader = cmd.ExecuteReader()
            While rdr.Read()
                If rdr.HasRows Then
                    MessageBox.Show("Welcome " + rdr.Item(2) + " you have gained access to the system.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TxtUsertype.SelectedIndex = -1

                    txtPassword.Clear()
                    txtUsername.Clear()
                    frmMainMenu.Show()
                End If
            End While
            If rdr.HasRows = False Then
                TxtUsertype.SelectedIndex = -1
                txtPassword.Clear()
                txtUsername.Clear()
                MessageBox.Show("Sorry fill in your correct details to gain access.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            rdr.Close()
            con.Close()
            con.Dispose()
        End If

        Me.Hide()
        frmMainMenu.Show()

    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        Me.Hide()
        frmUserRegistration.Show()
    End Sub
End Class