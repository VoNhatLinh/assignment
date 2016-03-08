Public Class frmSua

    Private dbAccess As New SQLAccess

    Private _isEdit As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Function insertStudent() As Boolean
        Dim sqlQuery As String = "insert into TTSinhVien (masv, tensv, sdt, diachi,maLop) "
        sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}','{4}')", txtMaSV.Text, txtTenSV.Text, txtSdt.Text, txtDiachi.Text, txtMaLop.Text)
        Return dbAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Hàm Update
    Private Function UpdateSV() As Boolean
        Dim sqlQuery As String = String.Format("Update TTSinhVien set tensv = '{0}' , sdt = '{1}', diachi = '{2}' where masv = '{3}'", _
        Me.txtTenSV.Text, Me.txtSdt.Text, Me.txtDiachi.Text, Me.txtMaSV.Text)
        Return dbAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function DLtrong() As Boolean
        Return (String.IsNullOrEmpty(txtMaSV.Text) OrElse String.IsNullOrEmpty(txtTenSV.Text) OrElse _
            String.IsNullOrEmpty(txtSdt.Text) OrElse String.IsNullOrEmpty(txtDiachi.Text) OrElse String.IsNullOrEmpty(txtMaLop.Text))

    End Function
    Private Sub frmSua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DLtrong() Then
            MessageBox.Show("Nhập dữ liệu vào bảng sau", "Thông báo", MessageBoxButtons.OK) 'thông báo nhập dữ liệu vào 
        Else
            If insertStudent() Then 'Thông báo khi thêm thành công
                MessageBox.Show("Thêm dữ liệu thành công", "Thông tin", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Nhập dữ liệu cần sửa", "...", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If DLtrong() Then     'Kiểm tra trường dữ liệu trước khi thêm hoặc sửa
            MessageBox.Show("Nhập dữ liệu vào trước khi thêm", "Lỗi", MessageBoxButtons.OK) 'thông báo lỗi khi chưa nhập dữ liệu
        Else
            If _isEdit Then
                If UpdateSV() Then
                    MessageBox.Show("Sửa dữ liệu thành công", "Thành công", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Lỗi sửa dữ liệu", "Lỗi", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If insertStudent() Then 'Thông báo khi thêm thành công
                    MessageBox.Show("Thêm dữ liệu thành công", "Thành công", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                Else
                    MessageBox.Show("Lỗi thêm dữ liệu", "Lỗi", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If

            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

   
End Class