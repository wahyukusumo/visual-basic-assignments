<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.TB_Harga = New System.Windows.Forms.TextBox()
        Me.TB_Hari = New System.Windows.Forms.TextBox()
        Me.TB_JumlahBayar = New System.Windows.Forms.TextBox()
        Me.TB_Diskon = New System.Windows.Forms.TextBox()
        Me.TB_TotalBayar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_Kamar = New System.Windows.Forms.ComboBox()
        Me.BTN_Calculate = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Exit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KamarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp5.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelangganTableAdapter = New WindowsApp5.Database1DataSetTableAdapters.PelangganTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_ID
        '
        Me.TB_ID.Location = New System.Drawing.Point(108, 23)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.Size = New System.Drawing.Size(292, 20)
        Me.TB_ID.TabIndex = 0
        '
        'TB_Nama
        '
        Me.TB_Nama.Location = New System.Drawing.Point(108, 49)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(292, 20)
        Me.TB_Nama.TabIndex = 1
        '
        'TB_Harga
        '
        Me.TB_Harga.Location = New System.Drawing.Point(108, 102)
        Me.TB_Harga.Name = "TB_Harga"
        Me.TB_Harga.Size = New System.Drawing.Size(292, 20)
        Me.TB_Harga.TabIndex = 2
        '
        'TB_Hari
        '
        Me.TB_Hari.Location = New System.Drawing.Point(567, 23)
        Me.TB_Hari.Name = "TB_Hari"
        Me.TB_Hari.Size = New System.Drawing.Size(292, 20)
        Me.TB_Hari.TabIndex = 3
        '
        'TB_JumlahBayar
        '
        Me.TB_JumlahBayar.Location = New System.Drawing.Point(567, 49)
        Me.TB_JumlahBayar.Name = "TB_JumlahBayar"
        Me.TB_JumlahBayar.Size = New System.Drawing.Size(292, 20)
        Me.TB_JumlahBayar.TabIndex = 4
        '
        'TB_Diskon
        '
        Me.TB_Diskon.Location = New System.Drawing.Point(567, 76)
        Me.TB_Diskon.Name = "TB_Diskon"
        Me.TB_Diskon.Size = New System.Drawing.Size(292, 20)
        Me.TB_Diskon.TabIndex = 5
        '
        'TB_TotalBayar
        '
        Me.TB_TotalBayar.Location = New System.Drawing.Point(567, 102)
        Me.TB_TotalBayar.Name = "TB_TotalBayar"
        Me.TB_TotalBayar.Size = New System.Drawing.Size(292, 20)
        Me.TB_TotalBayar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Pilihan Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Harga Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(471, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jumlah Hari"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(471, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jumlah Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(471, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(471, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Bayar"
        '
        'CB_Kamar
        '
        Me.CB_Kamar.FormattingEnabled = True
        Me.CB_Kamar.Location = New System.Drawing.Point(108, 75)
        Me.CB_Kamar.Name = "CB_Kamar"
        Me.CB_Kamar.Size = New System.Drawing.Size(292, 21)
        Me.CB_Kamar.TabIndex = 17
        '
        'BTN_Calculate
        '
        Me.BTN_Calculate.Location = New System.Drawing.Point(460, 143)
        Me.BTN_Calculate.Name = "BTN_Calculate"
        Me.BTN_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Calculate.TabIndex = 18
        Me.BTN_Calculate.Text = "Hitung"
        Me.BTN_Calculate.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(541, 143)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Clear.TabIndex = 19
        Me.BTN_Clear.Text = "Bersih"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(622, 143)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Save.TabIndex = 20
        Me.BTN_Save.Text = "Simpan"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(703, 143)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Delete.TabIndex = 21
        Me.BTN_Delete.Text = "Hapus"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'BTN_Exit
        '
        Me.BTN_Exit.Location = New System.Drawing.Point(784, 143)
        Me.BTN_Exit.Name = "BTN_Exit"
        Me.BTN_Exit.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Exit.TabIndex = 22
        Me.BTN_Exit.Text = "Keluar"
        Me.BTN_Exit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.KamarDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.HariDataGridViewTextBoxColumn, Me.JumlahbayarDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.TotalbayarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PelangganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 251)
        Me.DataGridView1.TabIndex = 23
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID Pelanggan"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama Pelanggan"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'KamarDataGridViewTextBoxColumn
        '
        Me.KamarDataGridViewTextBoxColumn.DataPropertyName = "kamar"
        Me.KamarDataGridViewTextBoxColumn.HeaderText = "Jenis Kamar"
        Me.KamarDataGridViewTextBoxColumn.Name = "KamarDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'HariDataGridViewTextBoxColumn
        '
        Me.HariDataGridViewTextBoxColumn.DataPropertyName = "hari"
        Me.HariDataGridViewTextBoxColumn.HeaderText = "Lama Menginap"
        Me.HariDataGridViewTextBoxColumn.Name = "HariDataGridViewTextBoxColumn"
        '
        'JumlahbayarDataGridViewTextBoxColumn
        '
        Me.JumlahbayarDataGridViewTextBoxColumn.DataPropertyName = "jumlah_bayar"
        Me.JumlahbayarDataGridViewTextBoxColumn.HeaderText = "Jumlah Bayar"
        Me.JumlahbayarDataGridViewTextBoxColumn.Name = "JumlahbayarDataGridViewTextBoxColumn"
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        '
        'TotalbayarDataGridViewTextBoxColumn
        '
        Me.TotalbayarDataGridViewTextBoxColumn.DataPropertyName = "total_bayar"
        Me.TotalbayarDataGridViewTextBoxColumn.HeaderText = "Total Bayar"
        Me.TotalbayarDataGridViewTextBoxColumn.Name = "TotalbayarDataGridViewTextBoxColumn"
        '
        'PelangganBindingSource
        '
        Me.PelangganBindingSource.DataMember = "Pelanggan"
        Me.PelangganBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'PelangganTableAdapter
        '
        Me.PelangganTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_Exit)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.BTN_Calculate)
        Me.Controls.Add(Me.CB_Kamar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_TotalBayar)
        Me.Controls.Add(Me.TB_Diskon)
        Me.Controls.Add(Me.TB_JumlahBayar)
        Me.Controls.Add(Me.TB_Hari)
        Me.Controls.Add(Me.TB_Harga)
        Me.Controls.Add(Me.TB_Nama)
        Me.Controls.Add(Me.TB_ID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_ID As TextBox
    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents TB_Harga As TextBox
    Friend WithEvents TB_Hari As TextBox
    Friend WithEvents TB_JumlahBayar As TextBox
    Friend WithEvents TB_Diskon As TextBox
    Friend WithEvents TB_TotalBayar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CB_Kamar As ComboBox
    Friend WithEvents BTN_Calculate As Button
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Save As Button
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents BTN_Exit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PelangganBindingSource As BindingSource
    Friend WithEvents PelangganTableAdapter As Database1DataSetTableAdapters.PelangganTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KamarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HariDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalbayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
