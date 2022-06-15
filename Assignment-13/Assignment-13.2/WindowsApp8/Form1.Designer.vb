<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pick_nim = New System.Windows.Forms.ComboBox()
        Me.tbs_konsentrasi = New System.Windows.Forms.TextBox()
        Me.tbs_nama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbs_jurusan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbs_date = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbs_alamat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nim = New System.Windows.Forms.TextBox()
        Me.tb_jurusan = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggallahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurusanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KonsentrasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp8.Database1DataSet()
        Me.tb_date = New System.Windows.Forms.TextBox()
        Me.StudentTableAdapter = New WindowsApp8.Database1DataSetTableAdapters.StudentTableAdapter()
        Me.tb_konsentrasi = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(339, 210)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 14
        Me.BTN_Save.Text = "Simpan"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(420, 210)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Clear.TabIndex = 15
        Me.BTN_Clear.Text = "Data Baru"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(501, 210)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 16
        Me.BTN_Delete.Text = "Hapus"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.Location = New System.Drawing.Point(582, 210)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Exit.TabIndex = 17
        Me.BTN_Exit.Text = "Keluar"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pick_nim)
        Me.GroupBox2.Controls.Add(Me.tbs_konsentrasi)
        Me.GroupBox2.Controls.Add(Me.tbs_nama)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbs_jurusan)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbs_date)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbs_alamat)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 183)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil Input Data"
        '
        'pick_nim
        '
        Me.pick_nim.FormattingEnabled = True
        Me.pick_nim.Location = New System.Drawing.Point(86, 18)
        Me.pick_nim.Name = "pick_nim"
        Me.pick_nim.Size = New System.Drawing.Size(216, 21)
        Me.pick_nim.TabIndex = 11
        '
        'tbs_konsentrasi
        '
        Me.tbs_konsentrasi.Location = New System.Drawing.Point(88, 149)
        Me.tbs_konsentrasi.Name = "tbs_konsentrasi"
        Me.tbs_konsentrasi.ReadOnly = True
        Me.tbs_konsentrasi.Size = New System.Drawing.Size(214, 20)
        Me.tbs_konsentrasi.TabIndex = 10
        '
        'tbs_nama
        '
        Me.tbs_nama.Location = New System.Drawing.Point(88, 45)
        Me.tbs_nama.Name = "tbs_nama"
        Me.tbs_nama.ReadOnly = True
        Me.tbs_nama.Size = New System.Drawing.Size(214, 20)
        Me.tbs_nama.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "NIM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama"
        '
        'tbs_jurusan
        '
        Me.tbs_jurusan.Location = New System.Drawing.Point(88, 122)
        Me.tbs_jurusan.Name = "tbs_jurusan"
        Me.tbs_jurusan.ReadOnly = True
        Me.tbs_jurusan.Size = New System.Drawing.Size(214, 20)
        Me.tbs_jurusan.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Alamat"
        '
        'tbs_date
        '
        Me.tbs_date.Location = New System.Drawing.Point(88, 97)
        Me.tbs_date.Name = "tbs_date"
        Me.tbs_date.ReadOnly = True
        Me.tbs_date.Size = New System.Drawing.Size(214, 20)
        Me.tbs_date.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Tanggal Lahir"
        '
        'tbs_alamat
        '
        Me.tbs_alamat.Location = New System.Drawing.Point(88, 71)
        Me.tbs_alamat.Name = "tbs_alamat"
        Me.tbs_alamat.ReadOnly = True
        Me.tbs_alamat.Size = New System.Drawing.Size(214, 20)
        Me.tbs_alamat.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Jurusan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Konsentrasi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Konsentrasi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(90, 57)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(229, 20)
        Me.tb_nama.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(90, 83)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(229, 20)
        Me.tb_alamat.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'tb_nim
        '
        Me.tb_nim.Location = New System.Drawing.Point(90, 31)
        Me.tb_nim.Name = "tb_nim"
        Me.tb_nim.Size = New System.Drawing.Size(229, 20)
        Me.tb_nim.TabIndex = 6
        '
        'tb_jurusan
        '
        Me.tb_jurusan.FormattingEnabled = True
        Me.tb_jurusan.Location = New System.Drawing.Point(90, 134)
        Me.tb_jurusan.Name = "tb_jurusan"
        Me.tb_jurusan.Size = New System.Drawing.Size(229, 21)
        Me.tb_jurusan.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NimDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TanggallahirDataGridViewTextBoxColumn, Me.JurusanDataGridViewTextBoxColumn, Me.KonsentrasiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 186)
        Me.DataGridView1.TabIndex = 21
        '
        'NimDataGridViewTextBoxColumn
        '
        Me.NimDataGridViewTextBoxColumn.DataPropertyName = "nim"
        Me.NimDataGridViewTextBoxColumn.HeaderText = "nim"
        Me.NimDataGridViewTextBoxColumn.Name = "NimDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'TanggallahirDataGridViewTextBoxColumn
        '
        Me.TanggallahirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.HeaderText = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.Name = "TanggallahirDataGridViewTextBoxColumn"
        '
        'JurusanDataGridViewTextBoxColumn
        '
        Me.JurusanDataGridViewTextBoxColumn.DataPropertyName = "jurusan"
        Me.JurusanDataGridViewTextBoxColumn.HeaderText = "jurusan"
        Me.JurusanDataGridViewTextBoxColumn.Name = "JurusanDataGridViewTextBoxColumn"
        '
        'KonsentrasiDataGridViewTextBoxColumn
        '
        Me.KonsentrasiDataGridViewTextBoxColumn.DataPropertyName = "konsentrasi"
        Me.KonsentrasiDataGridViewTextBoxColumn.HeaderText = "konsentrasi"
        Me.KonsentrasiDataGridViewTextBoxColumn.Name = "KonsentrasiDataGridViewTextBoxColumn"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tb_date
        '
        Me.tb_date.Location = New System.Drawing.Point(90, 109)
        Me.tb_date.Name = "tb_date"
        Me.tb_date.Size = New System.Drawing.Size(229, 20)
        Me.tb_date.TabIndex = 22
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'tb_konsentrasi
        '
        Me.tb_konsentrasi.FormattingEnabled = True
        Me.tb_konsentrasi.Location = New System.Drawing.Point(90, 161)
        Me.tb_konsentrasi.Name = "tb_konsentrasi"
        Me.tb_konsentrasi.Size = New System.Drawing.Size(229, 21)
        Me.tb_konsentrasi.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 450)
        Me.Controls.Add(Me.tb_konsentrasi)
        Me.Controls.Add(Me.tb_date)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tb_jurusan)
        Me.Controls.Add(Me.tb_nim)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Save As Button
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents BTN_Exit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pick_nim As ComboBox
    Friend WithEvents tbs_konsentrasi As TextBox
    Friend WithEvents tbs_nama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbs_jurusan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbs_date As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbs_alamat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_nim As TextBox
    Friend WithEvents tb_jurusan As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_date As TextBox
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As Database1DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents NimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggallahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JurusanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KonsentrasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tb_konsentrasi As ComboBox
End Class
