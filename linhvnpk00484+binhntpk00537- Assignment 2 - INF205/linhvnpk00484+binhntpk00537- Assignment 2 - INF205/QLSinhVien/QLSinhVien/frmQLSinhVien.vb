Public Class frmQLSinhVien
    Private dbAccess As New SQLAccess

    Private kiemtraDuLieu As Boolean = False


    'load dữ liệu lớp học
    Private Sub LoadDataOnComboBox()
        Dim sqlQuery As String = "select malop, tenlop from dbo.Lop"
        Dim dTable As DataTable = dbAccess.getDataTable(sqlQuery)
        Me.cmbLop.DataSource = dTable
        Me.cmbLop.ValueMember = "maLop"
        Me.cmbLop.DisplayMember = "tenLop"
    End Sub

    Private Sub LoadDataOnGridView(maLop As String)
        Dim sqlquery As String = String.Format("select maSV, tenSV, sdt, diachi from dbo.TTSinhVien where maLop ='{0}'", maLop)
        Dim dTable As DataTable = dbAccess.GetDataTable(sqlquery)
        Me.dgvSV.DataSource = dTable
        With Me.dgvSV
            .Columns(0).HeaderText = "maSV"
            .Columns(1).HeaderText = "tenSV"
            .Columns(2).HeaderText = "sdt"
            .Columns(3).HeaderText = "diachi"
            .Columns(3).Width = 200
        End With
    End Sub

    Private Sub frmQLSinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        kiemtraDuLieu = True
        LoadDataOnComboBox()
        LoadDataOnGridView(Me.cmbLop.SelectedValue)
        kiemtraDuLieu = False

    End Sub

    Private Sub cmbLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLop.SelectedIndexChanged
        If Not kiemtraDuLieu Then
            LoadDataOnGridView(Me.cmbLop.SelectedValue)
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim frm As New frmSua(False)
        frm.txtMaLop.Text = Me.cmbLop.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            LoadDataOnGridView(Me.cmbLop.SelectedValue)
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim frm As New frmSua(True)
        frm.txtMaLop.Text = Me.cmbLop.SelectedValue
        With Me.dgvSV
            frm.txtMaSV.Text = .Rows(.CurrentCell.RowIndex).Cells("maSV").Value
            frm.txtTenSV.Text = .Rows(.CurrentCell.RowIndex).Cells("tenSV").Value
            frm.txtSdt.Text = .Rows(.CurrentCell.RowIndex).Cells("sdt").Value
            frm.txtDiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("diachi").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then  'Thêm DL thành công thì đưa là listview
            LoadDataOnGridView(Me.cmbLop.SelectedValue)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim maSV As String = Me.dgvSV.Rows(Me.dgvSV.CurrentCell.RowIndex).Cells("maSV").Value
        Dim sqlQuery As String = String.Format("Delete TTSinhVien where maSV = '{0}'", maSV)

        If dbAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa thành công!")
            LoadDataOnGridView(Me.cmbLop.SelectedValue)
        End If
    End Sub
End Class
