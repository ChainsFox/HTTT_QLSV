Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Form4_diem
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
    Dim defaultCon As String = "Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from diem", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        con.Open()
        Dim cmd2 As New SqlCommand("select * from diem where masv = @masv", con)
        cmd2.Parameters.AddWithValue("@masv", txtmsv.Text)
        Dim myreader As SqlDataReader

        myreader = cmd2.ExecuteReader()
        Try
            'If (myreader.Read()) Then
            'con.Close()
            'MessageBox.Show("Không được phép lặp mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'con.Close()
            'Else
            con.Close()

            Dim masv As String = txtmsv.Text
            Dim mamon As String = UCase(txtmamon.Text)
            Dim diem As Double = txtdiem.Text

                Dim query As String = "insert into diem values(@masv,@mamon,@diem)"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@masv", masv)
                        cmd.Parameters.AddWithValue("@mamon", mamon)
                        cmd.Parameters.AddWithValue("@diem", diem)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    'txtmsv.Text = ""
                    MessageBox.Show("Thêm dữ liệu thành công")
                        BindData()
                    End Using
                End Using
            'End If
        Catch
            MessageBox.Show("Bạn đang để trống, thiếu thông tin, hoặc sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Sub ngoai le
    Public Sub BindData()
        Dim query As String = "select * from diem"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtmsv.Text = ""
        txtmamon.Text = ""
        txtdiem.Text = ""
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        'Dim query As String = "select * from diem where masv ='" & txttim.Text & "'"
        Dim query As String = "select * from diem where masv ='" & txttim.Text & "' and mamon ='" & txttim2.Text & "'"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtmsv.Text = dt.Rows(0)(0).ToString()
                            txtmamon.Text = dt.Rows(0)(1).ToString()
                            txtdiem.Text = dt.Rows(0)(2).ToString()
                        Else
                            txtmsv.Text = ""
                            txtmamon.Text = ""
                            txtdiem.Text = ""
                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Try
            Dim masv As String = txtmsv.Text
            Dim mamon As String = txtmamon.Text
            Dim diem As String = txtdiem.Text
            Dim query As String = "update diem set diem = @diem where masv = @masv and mamon = @mamon"
            Using con As SqlConnection = New SqlConnection(defaultCon)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@masv", masv)
                    cmd.Parameters.AddWithValue("@mamon", mamon)
                    cmd.Parameters.AddWithValue("@diem", diem)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtmsv.Text = ""
                    txtmamon.Text = ""
                    txtdiem.Text = ""
                    MessageBox.Show("Cập nhật dữ liệu thành công")
                    BindData()
                End Using
            End Using
        Catch
            MessageBox.Show("Bạn đang để trống, thiếu thông tin, hoặc sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim masv As String = txtmsv.Text
        Dim query As String = "delete from diem where masv ='" & txttim.Text & "' and mamon ='" & txttim2.Text & "'"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@masv", masv)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                txtmsv.Text = ""
                BindData()
            End Using
        End Using
    End Sub

    Private Sub btnxoa2_Click(sender As Object, e As EventArgs) Handles btnxoa2.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (result = DialogResult.OK) Then
                Dim masv As String = txtmsv.Text
                Dim query As String = "delete from diem where masv ='" & txttim.Text & "'"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@masv", masv)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtmsv.Text = ""
                        BindData()
                    End Using
                End Using
            End If
        Catch

        End Try
    End Sub

    Private Sub btnxoa3_Click(sender As Object, e As EventArgs) Handles btnxoa3.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (result = DialogResult.OK) Then
                Dim mamon As String = txtmamon.Text
                Dim query As String = "delete from diem where mamon ='" & txttim2.Text & "'"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@mamon", mamon)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtmsv.Text = ""
                        BindData()
                    End Using
                End Using
            End If
        Catch

        End Try
    End Sub
End Class