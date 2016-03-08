<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSinhVien
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvSV = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLop = New System.Windows.Forms.ComboBox()
        Me.QLSinhVienDataSet = New QLSinhVien.QLSinhVienDataSet()
        Me.QLSinhVienDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLSinhVienDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLSinhVienDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSV
        '
        Me.dgvSV.AllowUserToAddRows = False
        Me.dgvSV.AllowUserToDeleteRows = False
        Me.dgvSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSV.Location = New System.Drawing.Point(27, 76)
        Me.dgvSV.MultiSelect = False
        Me.dgvSV.Name = "dgvSV"
        Me.dgvSV.ReadOnly = True
        Me.dgvSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSV.Size = New System.Drawing.Size(518, 274)
        Me.dgvSV.TabIndex = 0
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(579, 49)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(168, 23)
        Me.btnThem.TabIndex = 1
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(579, 95)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(168, 23)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(579, 139)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(168, 23)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(579, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lớp"
        '
        'cmbLop
        '
        Me.cmbLop.AllowDrop = True
        Me.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLop.FormattingEnabled = True
        Me.cmbLop.Location = New System.Drawing.Point(566, 220)
        Me.cmbLop.Name = "cmbLop"
        Me.cmbLop.Size = New System.Drawing.Size(196, 21)
        Me.cmbLop.TabIndex = 3
        '
        'QLSinhVienDataSet
        '
        Me.QLSinhVienDataSet.DataSetName = "QLSinhVienDataSet"
        Me.QLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QLSinhVienDataSetBindingSource
        '
        Me.QLSinhVienDataSetBindingSource.DataSource = Me.QLSinhVienDataSet
        Me.QLSinhVienDataSetBindingSource.Position = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Tìm kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tìm kiếm:"
        '
        'frmQLSinhVien
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 374)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbLop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvSV)
        Me.Name = "frmQLSinhVien"
        Me.Text = "Quản lý sinh viên"
        CType(Me.dgvSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLSinhVienDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLSinhVienDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSV As System.Windows.Forms.DataGridView
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLop As System.Windows.Forms.ComboBox
    Friend WithEvents QLSinhVienDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QLSinhVienDataSet As QLSinhVien.QLSinhVienDataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
