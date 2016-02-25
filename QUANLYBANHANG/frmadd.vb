Public Class frmadd
    'Khai bao bien truy xuat DB tu lop DBAccess
    Private _DBAccess As New DataBaseAccess

    'Khai bao trang thai THem/Sua
    Private _IsEdit As Boolean = False


    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IsEdit = IsEdit
    End Sub


    'DInh nghĩa ham them ban ghi  khach hang  vao database
    Private Function InsertKhachhang() As Boolean
        Dim SqlQuery As String = "INSERT INTO dbo.Khachhang (MaKH, TenKH, GioiTinh, DiaChi, SDT)"
        SqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}')", txtmakh.Text, txttenkh.Text, cmbgioitinh.Text, txtdiachi.Text, txtsdt.Text)
        Return _DBAccess.ExecuteNoneQuery(SqlQuery)
    End Function

    'Update
    Private Function Updatekhanhhang() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE Khachhang Set TenKH = '{0}', GioiTinh = '{1}', DiaChi = '{2}', SDT = '{3}' WHERE MaKH = '{4}'", _
            Me.txttenkh.Text, Me.cmbgioitinh.Text, Me.txtdiachi.Text, Me.txtsdt.Text, Me.txtmakh.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Kiem tra du lieu truoc khi insert du lieu vao database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) OrElse _
        String.IsNullOrEmpty(cmbgioitinh.Text) OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse _
        String.IsNullOrEmpty(txtsdt.Text))


    End Function



    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If IsEmpty() Then
            MessageBox.Show("Hay nhap gia tri vao truoc khi ghi vao database", "Error", MessageBoxButtons.OK)
        Else
            If _IsEdit Then
                If Updatekhanhhang() Then
                    MessageBox.Show("Sửa dữ liệu thành công!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Lỗi sửa dữ liệu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If InsertKhachhang() Then
                    MessageBox.Show("Them du lieu thanh cong!", "Information", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi them du lieu", "Thong bao!", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub


    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Me.Close()
    End Sub

   
End Class