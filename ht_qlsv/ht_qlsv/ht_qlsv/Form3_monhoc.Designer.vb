<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_monhoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmamon = New System.Windows.Forms.TextBox()
        Me.txttenmon = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.txttim = New System.Windows.Forms.TextBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MÔN HỌC"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(407, 298)
        Me.DataGridView1.TabIndex = 4
        '
        'btn_load
        '
        Me.btn_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.Location = New System.Drawing.Point(131, 388)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(153, 31)
        Me.btn_load.TabIndex = 5
        Me.btn_load.Text = "Tải/Hiện thông tin"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 442)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mã môn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tên môn"
        '
        'txtmamon
        '
        Me.txtmamon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamon.Location = New System.Drawing.Point(106, 432)
        Me.txtmamon.Name = "txtmamon"
        Me.txtmamon.Size = New System.Drawing.Size(256, 26)
        Me.txtmamon.TabIndex = 9
        '
        'txttenmon
        '
        Me.txttenmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmon.Location = New System.Drawing.Point(106, 466)
        Me.txttenmon.Name = "txttenmon"
        Me.txttenmon.Size = New System.Drawing.Size(256, 26)
        Me.txttenmon.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Tìm mã môn"
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(310, 43)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(67, 31)
        Me.btnxoa.TabIndex = 28
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntim.Location = New System.Drawing.Point(237, 43)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(67, 31)
        Me.btntim.TabIndex = 27
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txttim
        '
        Me.txttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttim.Location = New System.Drawing.Point(97, 45)
        Me.txttim.Name = "txttim"
        Me.txttim.Size = New System.Drawing.Size(132, 26)
        Me.txttim.TabIndex = 26
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(204, 498)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(92, 31)
        Me.btnreset.TabIndex = 31
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Location = New System.Drawing.Point(106, 498)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(92, 31)
        Me.btnthem.TabIndex = 30
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Form3_monhoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 543)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txttim)
        Me.Controls.Add(Me.txttenmon)
        Me.Controls.Add(Me.txtmamon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3_monhoc"
        Me.Text = "Form3_monhoc"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_load As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmamon As TextBox
    Friend WithEvents txttenmon As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnxoa As Button
    Friend WithEvents btntim As Button
    Friend WithEvents txttim As TextBox
    Friend WithEvents btnreset As Button
    Friend WithEvents btnthem As Button
End Class
