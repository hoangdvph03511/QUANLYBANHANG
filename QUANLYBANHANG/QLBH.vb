Public Class QLBH
    Private _DBAccess As New DataBaseAccess

    Private Sub LoadKH()
        Dim sqlQuery As String = String.Format("Select MaKH,TenKH,GioiTinh,DiaChi,SDT From KhachHang")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvKhachhang.DataSource = dTable
        With Me.dgvKhachhang
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "GioiTinh"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(4).HeaderText = "SDT"
            .Columns(1).Width = 300
        End With
    End Sub

    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = "Select * From KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvKhachhang.DataSource = dTable
    End Sub

 
    Private Sub Search(value As String)
        Dim SqlQuery As String = " Select * From KhachHang "
        If Me.cmbbox.SelectedIndex = 0 Then 'Timtheoma
            SqlQuery += String.Format("Where MaKH LIKE '{0}%'", value)
        ElseIf Me.cmbbox.SelectedIndex = 1 Then 'Timtheoten
            SqlQuery += String.Format("Where TenKH LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(SqlQuery)
        Me.dgvKhachhang.DataSource = dTable
    End Sub

    Private Sub QLBH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub


   
    Private Sub txtboxsearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearch.TextChanged
        Search(Me.txtboxsearch.Text)
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New frmadd(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView()
        End If


    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New frmadd(True)
        frm.txtmakh.ReadOnly = True
        With Me.dgvKhachhang
            frm.txtmakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
            frm.txttenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
            frm.cmbgioitinh.Text = .Rows(.CurrentCell.RowIndex).Cells("GioiTinh").Value
            frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            frm.txtsdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'Khai bao bien lay MaKH ma dang chon tu dgvKhachhang
        Dim MaKH As String = Me.dgvKhachhang.Rows(Me.dgvKhachhang.CurrentCell.RowIndex).Cells("MaKH").Value

        'khai bao cau lenh de xoa
        Dim sqlQuery As String = String.Format("DELETE Khachhang Where MaKH = '{0}'", MaKH)

        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xóa Khách Hàng thành công!")
            LoadDataOnGridView()
        Else
            MessageBox.Show("Khách hàng còn nợ !", "Thông Báo!")
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        MessageBox.Show("Bài làm ASSIGNMENT môn ĐIỆN TOÁN ĐÁM MÂY, Dương Văn Hoàng - PH03511",
                        "Thông Báo")
    End Sub


End Class

