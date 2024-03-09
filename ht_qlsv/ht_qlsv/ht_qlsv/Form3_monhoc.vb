Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Form3_monhoc
    Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
    Dim defaultCon As String = "Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ht_qlsv;Integrated Security=True;TrustServerCertificate=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from monhoc", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        con.Open()
        Dim cmd2 As New SqlCommand("select * from monhoc where mamon = @mamon", con)
        cmd2.Parameters.AddWithValue("@mamon", txtmamon.Text)
        Dim myreader As SqlDataReader

        myreader = cmd2.ExecuteReader()
        Try
            If (myreader.Read()) Then
                con.Close()
                MessageBox.Show("Không được phép lặp mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
            Else
                con.Close()

                Dim mamon As String = UCase(txtmamon.Text)
                Dim tenmon As String = txttenmon.Text


                Dim query As String = "insert into monhoc values(@mamon,@tenmon)"
                Using con As SqlConnection = New SqlConnection(defaultCon)
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@mamon", mamon)
                        cmd.Parameters.AddWithValue("@tenmon", tenmon)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtmamon.Text = ""
                        txttenmon.Text = ""
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
        Dim query As String = "select * from monhoc"
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
        txtmamon.Text = ""
        txttenmon.Text = ""
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim query As String = "select * from monhoc where mamon ='" & txttim.Text & "'"
        Using con As SqlConnection = New SqlConnection(defaultCon)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtmamon.Text = dt.Rows(0)(0).ToString()
                            txttenmon.Text = dt.Rows(0)(1).ToString()
                        Else
                            txtmamon.Text = ""
                            txttenmon.Text = ""
                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            Dim mamon As String = txtmamon.Text
            Dim query As String = "delete from monhoc where mamon = @mamon"
            Using con As SqlConnection = New SqlConnection(defaultCon)
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@mamon", mamon)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtmamon.Text = ""
                    txttenmon.Text = ""
                    BindData()
                End Using
            End Using
        Catch
            MessageBox.Show("Phải xóa hết sv có mã môn này ở bảng -Điểm- thì mới được phép xóa ở bảng -Môn học-", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class