Imports System.Data.OleDb
Public Class frmPharmacyManagement
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        FlatTabControl1.SelectedTab = FlatTabControl1.TabPages(0)

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        FlatTabControl1.SelectedTab = FlatTabControl1.TabPages(1)
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        FlatTabControl1.SelectedTab = FlatTabControl1.TabPages(2)
    End Sub

    Private Sub GunaButton15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton16_Click(sender As Object, e As EventArgs) Handles GunaButton16.Click

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim x As DialogResult
        x = MessageBox.Show("Are you sure you want to Remove this product", "Inventory Mnagement", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Dim sql As String = "delete from tblInventory where ItemID='" & txtID.Text & "'"
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmd As New OleDbCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product Succesfully Removed ", "Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtID.Clear()
            txtName.Clear()
            txtPrice.Clear()
            txtCategory.Clear()
            populate()
            con.Close()
        End If
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtID.Text = "" Or txtName.Text = "" Or txtCategory.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Fill in empty fileds to update  product details", "Inventory Mnagement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim sqlUpdate As String = "update tblInventory set ItemName='" & txtName.Text & "',Category='" & txtCategory.Text & "',Price='" & txtPrice.Text & "',Expiry ='" & expery.Value & "' where ItemID='" & txtID.Text & "'"
            Dim cmdUpdate As New OleDbCommand(sqlUpdate, con)
            cmdUpdate.ExecuteNonQuery()
            MessageBox.Show("Product Details  has been successfully updated.", "Inventory Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            populate()
            txtID.Clear()
            txtName.Clear()
            txtPrice.Clear()
            txtCategory.Clear()
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtID.Text = "" Or txtName.Text = "" Or txtCategory.Text = "" Or txtPrice.Text = "" Then
            MessageBox.Show("Fill in empty fileds to add product", "Inventory Mnagement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim sql1 As String = "insert into tblInventory (ItemID,ItemName,Category,Price,Expirys)  values('" & txtID.Text & "' ,'" & txtName.Text & "','" & txtCategory.Text & "','" & txtPrice.Text & "','" & expery.Value & "')"
            Dim con1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            Dim cmd1 As New OleDbCommand(sql1, con1)
            con1.Open()
            cmd1.ExecuteNonQuery()
            MessageBox.Show("You have succesfully registered as a new Product.", "Inventory Mnagement", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con1.Close()
            txtID.Clear()
            txtName.Clear()
            txtPrice.Clear()
            txtCategory.Clear()
            populate()
        End If
    End Sub
    Private Sub populate()
        Dim sql As String = "select * from tblInventory"
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
        con.Open()
        Dim adptr As New OleDbDataAdapter(sql, con)
        Dim ds As New DataTable
        adptr.Fill(ds)
        InventoryData.DataSource = ds
        con.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            populate()

        Else
            Dim sql As String = "select * from tblInventory where ItemID like '%" & txtSearch.Text & "%' or ItemName like'%" & txtSearch.Text & "%' or Category like '%" & txtSearch.Text & "%'"
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=hospital-records.mdb")
            con.Open()
            Dim adptr As New OleDbDataAdapter(sql, con)
            Dim ds As New DataTable
            adptr.Fill(ds)
            InventoryData.DataSource = ds
            con.Close()
        End If
    End Sub
End Class