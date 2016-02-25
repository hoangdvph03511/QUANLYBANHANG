<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLBH
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
        Me.dgvKhachhang = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.txtboxsearch = New System.Windows.Forms.TextBox()
        Me.cmbbox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvKhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKhachhang
        '
        Me.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachhang.Location = New System.Drawing.Point(12, 105)
        Me.dgvKhachhang.Name = "dgvKhachhang"
        Me.dgvKhachhang.Size = New System.Drawing.Size(673, 339)
        Me.dgvKhachhang.TabIndex = 0
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnadd.Location = New System.Drawing.Point(727, 118)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(84, 39)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Thêm"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnedit.Location = New System.Drawing.Point(727, 163)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(85, 45)
        Me.btnedit.TabIndex = 3
        Me.btnedit.Text = "Sửa"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btndelete.Location = New System.Drawing.Point(726, 214)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(85, 39)
        Me.btndelete.TabIndex = 4
        Me.btndelete.Text = "Xóa"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(726, 259)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(86, 39)
        Me.btnsearch.TabIndex = 5
        Me.btnsearch.Text = "Thông Tin"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(12, 66)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(70, 20)
        Me.lblsearch.TabIndex = 6
        Me.lblsearch.Text = "Tìm theo"
        '
        'txtboxsearch
        '
        Me.txtboxsearch.Location = New System.Drawing.Point(233, 68)
        Me.txtboxsearch.Name = "txtboxsearch"
        Me.txtboxsearch.Size = New System.Drawing.Size(452, 20)
        Me.txtboxsearch.TabIndex = 7
        '
        'cmbbox
        '
        Me.cmbbox.FormattingEnabled = True
        Me.cmbbox.Items.AddRange(New Object() {"MaKH", "TenKH"})
        Me.cmbbox.Location = New System.Drawing.Point(103, 68)
        Me.cmbbox.Name = "cmbbox"
        Me.cmbbox.Size = New System.Drawing.Size(121, 21)
        Me.cmbbox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Meiryo", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(228, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 50)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "QUẢN LÝ KHÁCH HÀNG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QLBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 456)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbbox)
        Me.Controls.Add(Me.txtboxsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dgvKhachhang)
        Me.Name = "QLBH"
        Me.Text = "QUẢN LÝ BÁN HÀNG"
        CType(Me.dgvKhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvKhachhang As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents txtboxsearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbbox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
