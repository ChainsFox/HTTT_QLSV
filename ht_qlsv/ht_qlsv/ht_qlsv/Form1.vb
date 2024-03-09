Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
    Dim defaultCon As String = "Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from sinhvien", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        con.Open()
        Dim cmd2 As New SqlCommand("select * from sinhvien where masv = @masv", con)
        cmd2.Parameters.AddWithValue("@masv", txtmsv.Text)
        Dim myreader As SqlDataReader

        myreader = cmd2.ExecuteReader()
        Try
            If (myreader.Read()) Then
                con.Close()
                MessageBox.Show("Không được phép lặp mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
            Else
                con.Close()

                Dim masv As String = txtmsv.Text
                Dim hoten As String = txthoten.Text
                Dim gt As String = cboxgt.SelectedItem
                Dim ns As String = txtns.Text
                Dim makhoa As String = UCase(txtmakhoa.Text)
                Dim lop As String = txtlop.Text

                Dim query As String = "insert into sinhvien values(@masv,@hoten,@gt,@ns,@makhoa,@lop)"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@masv", masv)
                        cmd.Parameters.AddWithValue("@hoten", hoten)
                        cmd.Parameters.AddWithValue("@gt", gt)
                        cmd.Parameters.AddWithValue("@ns", ns)
                        cmd.Parameters.AddWithValue("@makhoa", makhoa)
                        cmd.Parameters.AddWithValue("@lop", lop)
                        'nho cho tim hieu cau lenh ko duoc phep cho lap ma nhan vien(xong)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtmsv.Text = ""
                        txthoten.Text = ""
                        txtns.Text = ""
                        cboxgt.Text = ""
                        txtmakhoa.Text = ""
                        txtlop.Text = ""
                        MessageBox.Show("Thêm dữ liệu thành công")
                        BindData()
                    End Using
                End Using
            End If
        Catch
            MessageBox.Show("Bạn đang để trống, thiếu thông tin, hoặc sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Sub ngoai le
    Public Sub BindData()
        Dim query As String = "select * from sinhvien"
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
        txthoten.Text = ""
        cboxgt.Text = ""
        txtns.Text = ""
        txtmakhoa.Text = ""
        txtlop.Text = ""
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim query As String = "select * from sinhvien where masv ='" & txttim.Text & "'"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtmsv.Text = dt.Rows(0)(0).ToString()
                            txthoten.Text = dt.Rows(0)(1).ToString()
                            cboxgt.Text = dt.Rows(0)(2).ToString()
                            txtns.Text = dt.Rows(0)(3).ToString()
                            txtmakhoa.Text = dt.Rows(0)(4).ToString()
                            txtlop.Text = dt.Rows(0)(5).ToString()
                        Else
                            txtmsv.Text = ""
                            txthoten.Text = ""
                            cboxgt.Text = ""
                            txtns.Text = ""
                            txtmakhoa.Text = ""
                            txtlop.Text = ""

                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btncapnhat_Click(sender As Object, e As EventArgs) Handles btncapnhat.Click
        Try
            Dim masv As String = txtmsv.Text
            Dim hoten As String = txthoten.Text
            Dim gt As String = cboxgt.SelectedItem
            Dim ns As String = txtns.Text
            Dim makhoa As String = UCase(txtmakhoa.Text)
            Dim lop As String = txtlop.Text
            Dim query As String = "update sinhvien set hoten = @hoten, gt = @gt, ns = @ns, makhoa = @makhoa, lop = @lop where masv = @masv"
            Using con As SqlConnection = New SqlConnection(defaultCon)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@masv", masv)
                    cmd.Parameters.AddWithValue("@hoten", hoten)
                    cmd.Parameters.AddWithValue("@gt", gt)
                    cmd.Parameters.AddWithValue("@ns", ns)
                    cmd.Parameters.AddWithValue("@makhoa", makhoa)
                    cmd.Parameters.AddWithValue("@lop", lop)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtmsv.Text = ""
                    txthoten.Text = ""
                    cboxgt.Text = ""
                    txtns.Text = ""
                    txtmakhoa.Text = ""
                    txtlop.Text = ""
                    MessageBox.Show("Cập nhật dữ liệu thành công")
                    BindData()
                End Using
            End Using
        Catch
            MessageBox.Show("Bạn đang để trống, thiếu thông tin, hoặc sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            Dim masv As String = txtmsv.Text
            Dim query As String = "delete from sinhvien where masv = @masv"
            Using con As SqlConnection = New SqlConnection(defaultCon)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@masv", masv)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtmsv.Text = ""
                    txthoten.Text = ""
                    cboxgt.Text = ""
                    txtns.Text = ""
                    txtmakhoa.Text = ""
                    txtlop.Text = ""
                    'MessageBox.Show("Xóa dữ liệu thành công")
                    BindData()
                End Using
            End Using
        Catch
            MessageBox.Show("Muốn xóa sv phải xóa hết điểm của sv đó ở bảng -Điểm-", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) _
Handles Label7.MouseEnter
        Label7.ForeColor = (Color.Blue)
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) _
Handles Label7.MouseLeave
        Label7.ForeColor = (Color.Black)
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) _
Handles Label8.MouseEnter
        Label8.ForeColor = (Color.Blue)
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) _
Handles Label8.MouseLeave
        Label8.ForeColor = (Color.Black)
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As EventArgs) _
Handles Label12.MouseEnter
        Label12.ForeColor = (Color.Blue)
    End Sub

    Private Sub Label12_MouseLeave(sender As Object, e As EventArgs) _
Handles Label12.MouseLeave
        Label12.ForeColor = (Color.Black)
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) _
Handles Label9.MouseEnter
        Label9.ForeColor = (Color.Blue)
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) _
Handles Label9.MouseLeave
        Label9.ForeColor = (Color.Black)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form2_khoa.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Form3_monhoc.Show()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Form4_diem.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Form5_hdsd.Show()

    End Sub

    Private Sub btntim2_Click(sender As Object, e As EventArgs) Handles btntim2.Click
        Dim query As String = "select * from sinhvien where makhoa ='" & txttim2.Text & "'"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtmsv.Text = dt.Rows(0)(0).ToString()
                            txthoten.Text = dt.Rows(0)(1).ToString()
                            cboxgt.Text = dt.Rows(0)(2).ToString()
                            txtns.Text = dt.Rows(0)(3).ToString()
                            txtmakhoa.Text = dt.Rows(0)(4).ToString()
                            txtlop.Text = dt.Rows(0)(5).ToString()
                        Else
                            txtmsv.Text = ""
                            txthoten.Text = ""
                            cboxgt.Text = ""
                            txtns.Text = ""
                            txtmakhoa.Text = ""
                            txtlop.Text = ""

                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnxoa2_Click(sender As Object, e As EventArgs) Handles btnxoa2.Click
        Try
            'MessageBox.Show("Bạn có chắc không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (result = DialogResult.OK) Then
                Dim makhoa As String = txtmakhoa.Text
                Dim query As String = "delete from sinhvien where makhoa = @makhoa"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@makhoa", makhoa)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtmsv.Text = ""
                        txthoten.Text = ""
                        cboxgt.Text = ""
                        txtns.Text = ""
                        txtmakhoa.Text = ""
                        txtlop.Text = ""
                        'MessageBox.Show("Xóa dữ liệu thành công")
                        BindData()
                    End Using
                End Using
            End If

        Catch
            MessageBox.Show("Thông tin sinh viên phải được xóa ở bảng -Điểm- thì mới được xóa ở bảng -Sinh viên-", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class