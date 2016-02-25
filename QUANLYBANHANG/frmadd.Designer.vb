<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadd
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
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.lbltenKH = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.cmbgioitinh = New System.Windows.Forms.ComboBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.Location = New System.Drawing.Point(36, 44)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(37, 13)
        Me.lblmakh.TabIndex = 0
        Me.lblmakh.Text = "MaKH"
        '
        'lbltenKH
        '
        Me.lbltenKH.AutoSize = True
        Me.lbltenKH.Location = New System.Drawing.Point(36, 74)
        Me.lbltenKH.Name = "lbltenKH"
        Me.lbltenKH.Size = New System.Drawing.Size(41, 13)
        Me.lbltenKH.TabIndex = 0
        Me.lbltenKH.Text = "TenKH"
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Location = New System.Drawing.Point(36, 102)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(46, 13)
        Me.lblgioitinh.TabIndex = 0
        Me.lblgioitinh.Text = "GioiTinh"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(36, 138)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(38, 13)
        Me.lbldiachi.TabIndex = 0
        Me.lbldiachi.Text = "DiaChi"
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Location = New System.Drawing.Point(44, 178)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(29, 13)
        Me.lblsdt.TabIndex = 0
        Me.lblsdt.Text = "SDT"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(117, 41)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(121, 20)
        Me.txtmakh.TabIndex = 1
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(117, 74)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(121, 20)
        Me.txttenkh.TabIndex = 1
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(117, 131)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(121, 20)
        Me.txtdiachi.TabIndex = 1
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(117, 175)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(121, 20)
        Me.txtsdt.TabIndex = 1
        '
        'cmbgioitinh
        '
        Me.cmbgioitinh.FormattingEnabled = True
        Me.cmbgioitinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.cmbgioitinh.Location = New System.Drawing.Point(117, 104)
        Me.cmbgioitinh.Name = "cmbgioitinh"
        Me.cmbgioitinh.Size = New System.Drawing.Size(121, 21)
        Me.cmbgioitinh.TabIndex = 2
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(66, 244)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(182, 244)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 4
        Me.btnxoa.Text = "Trở Lại"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'frmadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 318)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.cmbgioitinh)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblgioitinh)
        Me.Controls.Add(Me.lbltenKH)
        Me.Controls.Add(Me.lblmakh)
        Me.Name = "frmadd"
        Me.Text = "AddKhachhang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents lbltenKH As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents cmbgioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
End Class
