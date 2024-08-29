Imports System.Data.OleDb


Public Class ShiftGenerator
    Public doctorCount As Integer

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb;"
    Private frmStaffManagement As frmStaffManagement

    Public Sub New(form As frmStaffManagement)
        Me.frmStaffManagement = form
    End Sub

    Public Sub GenerateRandomShifts()
        Dim random As New Random()
        Dim staffList As List(Of (ID As Integer, FullName As String, Designation As String)) = GetStaffList()

        ' Clear existing shifts
        ClearExistingShifts()

        For Each staff In staffList
            Dim shift As String = GenerateRandomShift()
            InsertShift(staff.ID, staff.FullName, shift, staff.Designation)
        Next

        ' Populate textboxes after generating shifts
        PopulateShiftTextBoxes()
        countDoc()
        countNurses()
        countTech()
        countDoc_after()
        countNurses_after()
        countTech_after()
        countNurse_night()
        countTech_night()
        countDoc_night()


    End Sub

    Private Function GetStaffList() As List(Of (ID As Integer, FullName As String, Designation As String))
        Dim staffList As New List(Of (ID As Integer, FullName As String, Designation As String))
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("SELECT StaffID, FullName,Designation FROM tableStaff", connection)
            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    staffList.Add((CInt(reader("StaffID")), reader("FullName").ToString(), reader("Designation").ToString()))
                End While
            End Using
        End Using
        Return staffList
    End Function

    Private Function GenerateRandomShift() As String
        Dim random As New Random()
        Dim shifts As String() = {"Morning", "Afternoon", "Night"}
        Return shifts(random.Next(0, shifts.Length))
    End Function

    Private Sub InsertShift(staffID As Integer, fullName As String, shift As String, designation As String)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO tableShifts (StaffID, FullName, Shift,Designation) VALUES (@StaffID, @FullName, @Shift,@designation)"
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@StaffID", staffID)
            command.Parameters.AddWithValue("@FullName", fullName)
            command.Parameters.AddWithValue("@Shift", shift)
            command.Parameters.AddWithValue("@designation", designation)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub ClearExistingShifts()
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim query As String = "DELETE FROM tableShifts"
            Dim command As New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub PopulateShiftTextBoxes()
        ' Clear existing text in textboxes
        frmStaffManagement.txtMorning.Clear()
        frmStaffManagement.txtAfternoon.Clear()
        frmStaffManagement.txtNight.Clear()

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT FullName, Shift FROM tableShifts ORDER BY Shift, FullName"
            Dim command As New OleDbCommand(query, connection)

            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim fullName As String = reader("FullName").ToString()
                    Dim shift As String = reader("Shift").ToString()

                    Select Case shift
                        Case "Morning"
                            frmStaffManagement.txtMorning.AppendText(fullName & Environment.NewLine)
                        Case "Afternoon"
                            frmStaffManagement.txtAfternoon.AppendText(fullName & Environment.NewLine)
                        Case "Night"
                            frmStaffManagement.txtNight.AppendText(fullName & Environment.NewLine)
                    End Select
                End While
            End Using
        End Using
    End Sub
    Private Sub countDoc()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Morning'AND Designation='Doctor'"
        Dim doctorCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    doctorCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.lbDoctorsM.Text = " Doctors: " + Str(doctorCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using


    End Sub
    Private Sub countTech()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Morning'AND Designation='Technician'"
        Dim techCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    techCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label7.Text = " Technician: " + Str(techCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using


    End Sub
    Private Sub countNurses()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Morning'AND Designation='Nurse'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label5.Text = " Doctors: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using

        ' You can continue with your code here
    End Sub
    'counting Afternoon
    Private Sub countNurses_after()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Afternoon'AND Designation='Nurse'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label10.Text = " Nurses: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using

        ' You can continue with your code here
    End Sub
    Private Sub countDoc_after()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Afternoon'AND Designation='Doctor'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label11.Text = " Doctors: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using

        ' You can continue with your code here
    End Sub
    Private Sub countTech_after()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Afternoon'AND Designation='Technician'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label8.Text = " Technicians: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using

        '
    End Sub
    Private Sub countTech_night()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Night'AND Designation='Technician'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label12.Text = " Technicians: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using

        '
    End Sub
    Private Sub countNurse_night()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Night'AND Designation='Nurse'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label14.Text = " Nurse: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using


        '
    End Sub
    Private Sub countDoc_night()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb"
        Dim sql As String = "SELECT COUNT(*) FROM tableShifts WHERE Shift='Night'AND Designation='Doctor'"
        Dim nurseCount As Integer = 0

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                Try
                    connection.Open()
                    nurseCount = CInt(command.ExecuteScalar())



                    frmStaffManagement.Label15.Text = " Doctors: " + Str(nurseCount)



                Catch ex As Exception
                    MsgBox($"An error occurred: {ex.Message}")
                End Try
            End Using
        End Using

        '
    End Sub


End Class