<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmsv = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtns = New System.Windows.Forms.TextBox()
        Me.txtmakhoa = New System.Windows.Forms.TextBox()
        Me.txttim = New System.Windows.Forms.TextBox()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btncapnhat = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.cboxgt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtlop = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttim2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnxoa2 = New System.Windows.Forms.Button()
        Me.btntim2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(359, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 298)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_load
        '
        Me.btn_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.Location = New System.Drawing.Point(134, 110)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(153, 31)
        Me.btn_load.TabIndex = 1
        Me.btn_load.Text = "Tải/Hiện thông tin"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "QUẢN LÝ SINH VIÊN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mã sv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Họ tên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Giới tính"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ngày sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mã khoa"
        '
        'txtmsv
        '
        Me.txtmsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsv.Location = New System.Drawing.Point(80, 154)
        Me.txtmsv.Name = "txtmsv"
        Me.txtmsv.Size = New System.Drawing.Size(256, 26)
        Me.txtmsv.TabIndex = 8
        '
        'txthoten
        '
        Me.txthoten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoten.Location = New System.Drawing.Point(80, 186)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(256, 26)
        Me.txthoten.TabIndex = 9
        '
        'txtns
        '
        Me.txtns.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtns.Location = New System.Drawing.Point(80, 252)
        Me.txtns.Name = "txtns"
        Me.txtns.Size = New System.Drawing.Size(256, 26)
        Me.txtns.TabIndex = 11
        '
        'txtmakhoa
        '
        Me.txtmakhoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.Location = New System.Drawing.Point(80, 287)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.Size = New System.Drawing.Size(256, 26)
        Me.txtmakhoa.TabIndex = 12
        '
        'txttim
        '
        Me.txttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttim.Location = New System.Drawing.Point(418, 110)
        Me.txttim.Name = "txttim"
        Me.txttim.Size = New System.Drawing.Size(207, 26)
        Me.txttim.TabIndex = 13
        '
        'btntim
        '
        Me.btntim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntim.Location = New System.Drawing.Point(631, 105)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(78, 31)
        Me.btntim.TabIndex = 14
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(715, 105)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(117, 31)
        Me.btnxoa.TabIndex = 15
        Me.btnxoa.Text = "Xóa sinh viên"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Location = New System.Drawing.Point(23, 364)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(92, 31)
        Me.btnthem.TabIndex = 16
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btncapnhat
        '
        Me.btncapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapnhat.Location = New System.Drawing.Point(134, 364)
        Me.btncapnhat.Name = "btncapnhat"
        Me.btncapnhat.Size = New System.Drawing.Size(92, 31)
        Me.btncapnhat.TabIndex = 17
        Me.btncapnhat.Text = "Cập nhật"
        Me.btncapnhat.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(244, 364)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(92, 31)
        Me.btnreset.TabIndex = 18
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'cboxgt
        '
        Me.cboxgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxgt.FormattingEnabled = True
        Me.cboxgt.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cboxgt.Location = New System.Drawing.Point(80, 218)
        Me.cboxgt.Name = "cboxgt"
        Me.cboxgt.Size = New System.Drawing.Size(61, 28)
        Me.cboxgt.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "KHOA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "ĐIỂM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(876, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Hướng dẫn sử dụng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Lớp"
        '
        'txtlop
        '
        Me.txtlop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlop.Location = New System.Drawing.Point(78, 323)
        Me.txtlop.Name = "txtlop"
        Me.txtlop.Size = New System.Drawing.Size(256, 26)
        Me.txtlop.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(356, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Tìm msv"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(132, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "MÔN HỌC"
        '
        'txttim2
        '
        Me.txttim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttim2.Location = New System.Drawing.Point(447, 78)
        Me.txttim2.Name = "txttim2"
        Me.txttim2.Size = New System.Drawing.Size(178, 26)
        Me.txttim2.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(356, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Tìm mã khoa"
        '
        'btnxoa2
        '
        Me.btnxoa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa2.Location = New System.Drawing.Point(715, 73)
        Me.btnxoa2.Name = "btnxoa2"
        Me.btnxoa2.Size = New System.Drawing.Size(153, 31)
        Me.btnxoa2.TabIndex = 30
        Me.btnxoa2.Text = "Xóa sv có mã khoa"
        Me.btnxoa2.UseVisualStyleBackColor = True
        '
        'btntim2
        '
        Me.btntim2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntim2.Location = New System.Drawing.Point(631, 73)
        Me.btntim2.Name = "btntim2"
        Me.btntim2.Size = New System.Drawing.Size(78, 31)
        Me.btntim2.TabIndex = 29
        Me.btntim2.Text = "Tìm"
        Me.btntim2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1011, 484)
        Me.Controls.Add(Me.btnxoa2)
        Me.Controls.Add(Me.btntim2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txttim2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtlop)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboxgt)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncapnhat)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txttim)
        Me.Controls.Add(Me.txtmakhoa)
        Me.Controls.Add(Me.txtns)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmsv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_load As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmsv As TextBox
    Friend WithEvents txthoten As TextBox
    Friend WithEvents txtns As TextBox
    Friend WithEvents txtmakhoa As TextBox
    Friend WithEvents txttim As TextBox
    Friend WithEvents btntim As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents btncapnhat As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents cboxgt As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtlop As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txttim2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnxoa2 As Button
    Friend WithEvents btntim2 As Button
End Class
