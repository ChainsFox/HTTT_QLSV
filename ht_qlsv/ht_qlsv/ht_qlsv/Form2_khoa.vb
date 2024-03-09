Imports System.Data.SqlClient

Public Class Form2_khoa
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
    Dim defaultCon As String = "Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from khoa", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        con.Open()
        Dim cmd2 As New SqlCommand("select * from khoa where makhoa = @makhoa", con)
        cmd2.Parameters.AddWithValue("@makhoa", txtmakhoa.Text)
        Dim myreader As SqlDataReader

        myreader = cmd2.ExecuteReader()
        Try
            If (myreader.Read()) Then
                con.Close()
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
            Else
                con.Close()

                Dim makhoa As String = UCase(txtmakhoa.Text)
                Dim tenkhoa As String = txttenkhoa.Text

                Dim query As String = "insert into khoa values(@makhoa,@tenkhoa)"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@makhoa", makhoa)
                        cmd.Parameters.AddWithValue("@tenkhoa", tenkhoa)
                        'nho cho tim hieu cau lenh ko duoc phep cho lap ma nhan vien(xong)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()

                        txtmakhoa.Text = ""
                        txttenkhoa.Text = ""
                        MessageBox.Show("Thêm dữ liệu thành công")
                        BindData()
                    End Using
                End Using
            End If
        Catch
            MessageBox.Show("Bạn đang để trống, thiếu thông tin, hoặc sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'sub ngoai le
    Public Sub BindData()
        Dim query As String = "select * from khoa"
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
        txtmakhoa.Text = ""
        txttenkhoa.Text = ""
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim query As String = "select * from khoa where makhoa ='" & txttim.Text & "'"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtmakhoa.Text = dt.Rows(0)(0).ToString()
                            txttenkhoa.Text = dt.Rows(0)(1).ToString()
                        Else
                            txtmakhoa.Text = ""
                            txttenkhoa.Text = ""
                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            Dim makhoa As String = txtmakhoa.Text
            Dim query As String = "delete from khoa where makhoa = @makhoa"
            Using con As SqlConnection = New SqlConnection(defaultCon)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@makhoa", makhoa)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtmakhoa.Text = ""
                    txttenkhoa.Text = ""
                    'MessageBox.Show("Xóa dữ liệu thành công")
                    BindData()
                End Using
            End Using
        Catch
            MessageBox.Show("Có sinh viên đang ở khoa này, vui lòng xóa hết sv có mã khoa cùng tên ở bảng -Sinh viên- thì mới được phép xóa ở bảng -Khoa-", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class