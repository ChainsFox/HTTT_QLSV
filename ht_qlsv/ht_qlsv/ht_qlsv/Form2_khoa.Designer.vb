<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2_khoa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmakhoa = New System.Windows.Forms.TextBox()
        Me.txttenkhoa = New System.Windows.Forms.TextBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.txttim = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "KHOA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã khoa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 467)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tên khoa"
        '
        'txtmakhoa
        '
        Me.txtmakhoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.Location = New System.Drawing.Point(106, 429)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.Size = New System.Drawing.Size(256, 26)
        Me.txtmakhoa.TabIndex = 9
        '
        'txttenkhoa
        '
        Me.txttenkhoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenkhoa.Location = New System.Drawing.Point(106, 461)
        Me.txttenkhoa.Name = "txttenkhoa"
        Me.txttenkhoa.Size = New System.Drawing.Size(256, 26)
        Me.txttenkhoa.TabIndex = 10
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(204, 503)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(92, 31)
        Me.btnreset.TabIndex = 21
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Location = New System.Drawing.Point(106, 503)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(92, 31)
        Me.btnthem.TabIndex = 19
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(381, 296)
        Me.DataGridView1.TabIndex = 22
        '
        'btn_load
        '
        Me.btn_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.Location = New System.Drawing.Point(129, 392)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(153, 31)
        Me.btn_load.TabIndex = 23
        Me.btn_load.Text = "Tải/Hiện thông tin"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Tìm mã khoa"
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(325, 56)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(68, 31)
        Me.btnxoa.TabIndex = 28
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntim.Location = New System.Drawing.Point(250, 56)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(69, 31)
        Me.btntim.TabIndex = 27
        Me.btntim.Text = "Tìm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'txttim
        '
        Me.txttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttim.Location = New System.Drawing.Point(100, 58)
        Me.txttim.Name = "txttim"
        Me.txttim.Size = New System.Drawing.Size(134, 26)
        Me.txttim.TabIndex = 26
        '
        'Form2_khoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 548)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.txttim)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txttenkhoa)
        Me.Controls.Add(Me.txtmakhoa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2_khoa"
        Me.Text = "Form2_khoa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmakhoa As TextBox
    Friend WithEvents txttenkhoa As TextBox
    Friend WithEvents btnreset As Button
    Friend WithEvents btnthem As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_load As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnxoa As Button
    Friend WithEvents btntim As Button
    Friend WithEvents txttim As TextBox
End Class
