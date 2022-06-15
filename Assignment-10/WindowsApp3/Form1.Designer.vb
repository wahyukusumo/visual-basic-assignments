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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_Nama = New System.Windows.Forms.TextBox()
        Me.TB_Harga = New System.Windows.Forms.TextBox()
        Me.TB_JumlahBeli = New System.Windows.Forms.TextBox()
        Me.TB_JumlahBayar = New System.Windows.Forms.TextBox()
        Me.TB_Diskon = New System.Windows.Forms.TextBox()
        Me.TB_TotalBayar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTN_Transaction = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp3.Database1DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamacustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisbarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PembelianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_JenisBarang = New System.Windows.Forms.ComboBox()
        Me.CB_Pembelian = New System.Windows.Forms.ComboBox()
        Me.PelangganTableAdapter = New WindowsApp3.Database1DataSetTableAdapters.PelangganTableAdapter()
        Me.NamacustomerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisbarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbeliDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbayarDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PembelianDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalbayarDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lemon/Milk", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penjulan Motor Honda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Custormer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(450, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pembelian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(450, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Diskon"
        '
        'TB_Nama
        '
        Me.TB_Nama.Location = New System.Drawing.Point(125, 78)
        Me.TB_Nama.Name = "TB_Nama"
        Me.TB_Nama.Size = New System.Drawing.Size(290, 20)
        Me.TB_Nama.TabIndex = 8
        '
        'TB_Harga
        '
        Me.TB_Harga.Location = New System.Drawing.Point(125, 130)
        Me.TB_Harga.Name = "TB_Harga"
        Me.TB_Harga.ReadOnly = True
        Me.TB_Harga.Size = New System.Drawing.Size(290, 20)
        Me.TB_Harga.TabIndex = 10
        '
        'TB_JumlahBeli
        '
        Me.TB_JumlahBeli.Location = New System.Drawing.Point(125, 156)
        Me.TB_JumlahBeli.Name = "TB_JumlahBeli"
        Me.TB_JumlahBeli.Size = New System.Drawing.Size(290, 20)
        Me.TB_JumlahBeli.TabIndex = 11
        '
        'TB_JumlahBayar
        '
        Me.TB_JumlahBayar.Location = New System.Drawing.Point(563, 78)
        Me.TB_JumlahBayar.Name = "TB_JumlahBayar"
        Me.TB_JumlahBayar.ReadOnly = True
        Me.TB_JumlahBayar.Size = New System.Drawing.Size(290, 20)
        Me.TB_JumlahBayar.TabIndex = 12
        '
        'TB_Diskon
        '
        Me.TB_Diskon.Location = New System.Drawing.Point(563, 130)
        Me.TB_Diskon.Name = "TB_Diskon"
        Me.TB_Diskon.ReadOnly = True
        Me.TB_Diskon.Size = New System.Drawing.Size(290, 20)
        Me.TB_Diskon.TabIndex = 14
        '
        'TB_TotalBayar
        '
        Me.TB_TotalBayar.Location = New System.Drawing.Point(563, 156)
        Me.TB_TotalBayar.Name = "TB_TotalBayar"
        Me.TB_TotalBayar.ReadOnly = True
        Me.TB_TotalBayar.Size = New System.Drawing.Size(290, 20)
        Me.TB_TotalBayar.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(450, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total Bayar"
        '
        'BTN_Transaction
        '
        Me.BTN_Transaction.Location = New System.Drawing.Point(496, 194)
        Me.BTN_Transaction.Name = "BTN_Transaction"
        Me.BTN_Transaction.Size = New System.Drawing.Size(109, 23)
        Me.BTN_Transaction.TabIndex = 17
        Me.BTN_Transaction.Text = "Transaksi Baru"
        Me.BTN_Transaction.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(620, 194)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(109, 23)
        Me.BTN_Save.TabIndex = 18
        Me.BTN_Save.Text = "Simpan"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Location = New System.Drawing.Point(744, 194)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(109, 23)
        Me.BTN_Delete.TabIndex = 19
        Me.BTN_Delete.Text = "Hapus"
        Me.BTN_Delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamacustomerDataGridViewTextBoxColumn1, Me.JenisbarangDataGridViewTextBoxColumn1, Me.HargaDataGridViewTextBoxColumn1, Me.JumlahbeliDataGridViewTextBoxColumn1, Me.JumlahbayarDataGridViewTextBoxColumn1, Me.PembelianDataGridViewTextBoxColumn1, Me.DiskonDataGridViewTextBoxColumn1, Me.TotalbayarDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.PelangganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 179)
        Me.DataGridView1.TabIndex = 23
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
        'NamacustomerDataGridViewTextBoxColumn
        '
        Me.NamacustomerDataGridViewTextBoxColumn.Name = "NamacustomerDataGridViewTextBoxColumn"
        '
        'JenisbarangDataGridViewTextBoxColumn
        '
        Me.JenisbarangDataGridViewTextBoxColumn.Name = "JenisbarangDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'JumlahbeliDataGridViewTextBoxColumn
        '
        Me.JumlahbeliDataGridViewTextBoxColumn.Name = "JumlahbeliDataGridViewTextBoxColumn"
        '
        'JumlahbayarDataGridViewTextBoxColumn
        '
        Me.JumlahbayarDataGridViewTextBoxColumn.Name = "JumlahbayarDataGridViewTextBoxColumn"
        '
        'PembelianDataGridViewTextBoxColumn
        '
        Me.PembelianDataGridViewTextBoxColumn.Name = "PembelianDataGridViewTextBoxColumn"
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        '
        'TotalbayarDataGridViewTextBoxColumn
        '
        Me.TotalbayarDataGridViewTextBoxColumn.Name = "TotalbayarDataGridViewTextBoxColumn"
        '
        'CB_JenisBarang
        '
        Me.CB_JenisBarang.FormattingEnabled = True
        Me.CB_JenisBarang.Location = New System.Drawing.Point(125, 103)
        Me.CB_JenisBarang.Name = "CB_JenisBarang"
        Me.CB_JenisBarang.Size = New System.Drawing.Size(290, 21)
        Me.CB_JenisBarang.TabIndex = 21
        '
        'CB_Pembelian
        '
        Me.CB_Pembelian.FormattingEnabled = True
        Me.CB_Pembelian.Location = New System.Drawing.Point(563, 103)
        Me.CB_Pembelian.Name = "CB_Pembelian"
        Me.CB_Pembelian.Size = New System.Drawing.Size(290, 21)
        Me.CB_Pembelian.TabIndex = 22
        '
        'PelangganTableAdapter
        '
        Me.PelangganTableAdapter.ClearBeforeFill = True
        '
        'NamacustomerDataGridViewTextBoxColumn1
        '
        Me.NamacustomerDataGridViewTextBoxColumn1.DataPropertyName = "nama_customer"
        Me.NamacustomerDataGridViewTextBoxColumn1.HeaderText = "Nama Customer"
        Me.NamacustomerDataGridViewTextBoxColumn1.Name = "NamacustomerDataGridViewTextBoxColumn1"
        '
        'JenisbarangDataGridViewTextBoxColumn1
        '
        Me.JenisbarangDataGridViewTextBoxColumn1.DataPropertyName = "jenis_barang"
        Me.JenisbarangDataGridViewTextBoxColumn1.HeaderText = "Jenis Barang"
        Me.JenisbarangDataGridViewTextBoxColumn1.Name = "JenisbarangDataGridViewTextBoxColumn1"
        '
        'HargaDataGridViewTextBoxColumn1
        '
        Me.HargaDataGridViewTextBoxColumn1.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn1.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn1.Name = "HargaDataGridViewTextBoxColumn1"
        '
        'JumlahbeliDataGridViewTextBoxColumn1
        '
        Me.JumlahbeliDataGridViewTextBoxColumn1.DataPropertyName = "jumlah_beli"
        Me.JumlahbeliDataGridViewTextBoxColumn1.HeaderText = "Jumlah Beli"
        Me.JumlahbeliDataGridViewTextBoxColumn1.Name = "JumlahbeliDataGridViewTextBoxColumn1"
        '
        'JumlahbayarDataGridViewTextBoxColumn1
        '
        Me.JumlahbayarDataGridViewTextBoxColumn1.DataPropertyName = "jumlah_bayar"
        Me.JumlahbayarDataGridViewTextBoxColumn1.HeaderText = "Jumlah Bayar"
        Me.JumlahbayarDataGridViewTextBoxColumn1.Name = "JumlahbayarDataGridViewTextBoxColumn1"
        '
        'PembelianDataGridViewTextBoxColumn1
        '
        Me.PembelianDataGridViewTextBoxColumn1.DataPropertyName = "pembelian"
        Me.PembelianDataGridViewTextBoxColumn1.HeaderText = "Pembelian"
        Me.PembelianDataGridViewTextBoxColumn1.Name = "PembelianDataGridViewTextBoxColumn1"
        '
        'DiskonDataGridViewTextBoxColumn1
        '
        Me.DiskonDataGridViewTextBoxColumn1.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn1.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn1.Name = "DiskonDataGridViewTextBoxColumn1"
        '
        'TotalbayarDataGridViewTextBoxColumn1
        '
        Me.TotalbayarDataGridViewTextBoxColumn1.DataPropertyName = "total_bayar"
        Me.TotalbayarDataGridViewTextBoxColumn1.HeaderText = "Total Bayar"
        Me.TotalbayarDataGridViewTextBoxColumn1.Name = "TotalbayarDataGridViewTextBoxColumn1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 422)
        Me.Controls.Add(Me.CB_Pembelian)
        Me.Controls.Add(Me.CB_JenisBarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.BTN_Transaction)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TB_TotalBayar)
        Me.Controls.Add(Me.TB_Diskon)
        Me.Controls.Add(Me.TB_JumlahBayar)
        Me.Controls.Add(Me.TB_JumlahBeli)
        Me.Controls.Add(Me.TB_Harga)
        Me.Controls.Add(Me.TB_Nama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_Nama As TextBox
    Friend WithEvents TB_Harga As TextBox
    Friend WithEvents TB_JumlahBeli As TextBox
    Friend WithEvents TB_JumlahBayar As TextBox
    Friend WithEvents TB_Diskon As TextBox
    Friend WithEvents TB_TotalBayar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BTN_Transaction As Button
    Friend WithEvents BTN_Save As Button
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents NamacustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisbarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PembelianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalbayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CB_JenisBarang As ComboBox
    Friend WithEvents CB_Pembelian As ComboBox
    Friend WithEvents PelangganBindingSource As BindingSource
    Friend WithEvents PelangganTableAdapter As Database1DataSetTableAdapters.PelangganTableAdapter
    Friend WithEvents NamacustomerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JenisbarangDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbeliDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbayarDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PembelianDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalbayarDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
