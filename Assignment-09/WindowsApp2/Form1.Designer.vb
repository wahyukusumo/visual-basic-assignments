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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahsewaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalbayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.PelangganTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.PelangganTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_Status = New System.Windows.Forms.ComboBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Calculate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_TotalBayar = New System.Windows.Forms.TextBox()
        Me.TextBox_JumlahBayar = New System.Windows.Forms.TextBox()
        Me.TextBox_Diskon = New System.Windows.Forms.TextBox()
        Me.TextBox_JumlahSewa = New System.Windows.Forms.TextBox()
        Me.TextBox_Harga = New System.Windows.Forms.TextBox()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button_Last = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_Prev = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button_First = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_Show_JumlahSewa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_Show_Nama = New System.Windows.Forms.TextBox()
        Me.TextBox_Show_TotalBayar = New System.Windows.Forms.TextBox()
        Me.TextBox_Show_Status = New System.Windows.Forms.TextBox()
        Me.TextBox_Show_JumlahBayar = New System.Windows.Forms.TextBox()
        Me.TextBox_Show_Harga = New System.Windows.Forms.TextBox()
        Me.TextBox_Show_Diskon = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.JumlahsewaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.JumlahbayarDataGridViewTextBoxColumn, Me.TotalbayarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PelangganBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 220)
        Me.DataGridView1.TabIndex = 0
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'JumlahsewaDataGridViewTextBoxColumn
        '
        Me.JumlahsewaDataGridViewTextBoxColumn.DataPropertyName = "jumlah_sewa"
        Me.JumlahsewaDataGridViewTextBoxColumn.HeaderText = "jumlah_sewa"
        Me.JumlahsewaDataGridViewTextBoxColumn.Name = "JumlahsewaDataGridViewTextBoxColumn"
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        '
        'JumlahbayarDataGridViewTextBoxColumn
        '
        Me.JumlahbayarDataGridViewTextBoxColumn.DataPropertyName = "jumlah_bayar"
        Me.JumlahbayarDataGridViewTextBoxColumn.HeaderText = "jumlah_bayar"
        Me.JumlahbayarDataGridViewTextBoxColumn.Name = "JumlahbayarDataGridViewTextBoxColumn"
        '
        'TotalbayarDataGridViewTextBoxColumn
        '
        Me.TotalbayarDataGridViewTextBoxColumn.DataPropertyName = "total_bayar"
        Me.TotalbayarDataGridViewTextBoxColumn.HeaderText = "total_bayar"
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
        'PelangganTableAdapter
        '
        Me.PelangganTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Status)
        Me.GroupBox1.Controls.Add(Me.Button_Save)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.Button_Calculate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_TotalBayar)
        Me.GroupBox1.Controls.Add(Me.TextBox_JumlahBayar)
        Me.GroupBox1.Controls.Add(Me.TextBox_Diskon)
        Me.GroupBox1.Controls.Add(Me.TextBox_JumlahSewa)
        Me.GroupBox1.Controls.Add(Me.TextBox_Harga)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 258)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data Pelanggan"
        '
        'ComboBox_Status
        '
        Me.ComboBox_Status.FormattingEnabled = True
        Me.ComboBox_Status.Location = New System.Drawing.Point(92, 51)
        Me.ComboBox_Status.Name = "ComboBox_Status"
        Me.ComboBox_Status.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox_Status.TabIndex = 16
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(219, 218)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 15
        Me.Button_Save.Text = "Simpan"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(9, 218)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 14
        Me.Button_Clear.Text = "Bersih"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Calculate
        '
        Me.Button_Calculate.Location = New System.Drawing.Point(138, 218)
        Me.Button_Calculate.Name = "Button_Calculate"
        Me.Button_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calculate.TabIndex = 2
        Me.Button_Calculate.Text = "Hitung"
        Me.Button_Calculate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Jumlah Bayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Diskon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jumlah Sewa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'TextBox_TotalBayar
        '
        Me.TextBox_TotalBayar.Location = New System.Drawing.Point(92, 182)
        Me.TextBox_TotalBayar.Name = "TextBox_TotalBayar"
        Me.TextBox_TotalBayar.ReadOnly = True
        Me.TextBox_TotalBayar.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_TotalBayar.TabIndex = 6
        '
        'TextBox_JumlahBayar
        '
        Me.TextBox_JumlahBayar.Location = New System.Drawing.Point(92, 156)
        Me.TextBox_JumlahBayar.Name = "TextBox_JumlahBayar"
        Me.TextBox_JumlahBayar.ReadOnly = True
        Me.TextBox_JumlahBayar.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_JumlahBayar.TabIndex = 5
        '
        'TextBox_Diskon
        '
        Me.TextBox_Diskon.Location = New System.Drawing.Point(92, 130)
        Me.TextBox_Diskon.Name = "TextBox_Diskon"
        Me.TextBox_Diskon.ReadOnly = True
        Me.TextBox_Diskon.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Diskon.TabIndex = 4
        '
        'TextBox_JumlahSewa
        '
        Me.TextBox_JumlahSewa.Location = New System.Drawing.Point(92, 78)
        Me.TextBox_JumlahSewa.Name = "TextBox_JumlahSewa"
        Me.TextBox_JumlahSewa.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_JumlahSewa.TabIndex = 3
        '
        'TextBox_Harga
        '
        Me.TextBox_Harga.Location = New System.Drawing.Point(92, 104)
        Me.TextBox_Harga.Name = "TextBox_Harga"
        Me.TextBox_Harga.ReadOnly = True
        Me.TextBox_Harga.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Harga.TabIndex = 2
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Location = New System.Drawing.Point(92, 26)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Nama.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button_Exit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button_Last)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button_Next)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Button_Prev)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Button_First)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_JumlahSewa)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_Nama)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_TotalBayar)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_Status)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_JumlahBayar)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_Harga)
        Me.GroupBox2.Controls.Add(Me.TextBox_Show_Diskon)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 258)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tampilan Data Pelanggan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Total Bayar"
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(356, 218)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exit.TabIndex = 4
        Me.Button_Exit.Text = "Keluar"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Jumlah Bayar"
        '
        'Button_Last
        '
        Me.Button_Last.Location = New System.Drawing.Point(254, 218)
        Me.Button_Last.Name = "Button_Last"
        Me.Button_Last.Size = New System.Drawing.Size(75, 23)
        Me.Button_Last.TabIndex = 3
        Me.Button_Last.Text = "Last"
        Me.Button_Last.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Diskon"
        '
        'Button_Next
        '
        Me.Button_Next.Location = New System.Drawing.Point(172, 218)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 2
        Me.Button_Next.Text = "Next"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Jumlah Sewa"
        '
        'Button_Prev
        '
        Me.Button_Prev.Location = New System.Drawing.Point(90, 218)
        Me.Button_Prev.Name = "Button_Prev"
        Me.Button_Prev.Size = New System.Drawing.Size(75, 23)
        Me.Button_Prev.TabIndex = 1
        Me.Button_Prev.Text = "Previous"
        Me.Button_Prev.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Harga"
        '
        'Button_First
        '
        Me.Button_First.Location = New System.Drawing.Point(8, 218)
        Me.Button_First.Name = "Button_First"
        Me.Button_First.Size = New System.Drawing.Size(75, 23)
        Me.Button_First.TabIndex = 0
        Me.Button_First.Text = "First"
        Me.Button_First.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Status"
        '
        'TextBox_Show_JumlahSewa
        '
        Me.TextBox_Show_JumlahSewa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "jumlah_sewa", True))
        Me.TextBox_Show_JumlahSewa.Location = New System.Drawing.Point(90, 104)
        Me.TextBox_Show_JumlahSewa.Name = "TextBox_Show_JumlahSewa"
        Me.TextBox_Show_JumlahSewa.ReadOnly = True
        Me.TextBox_Show_JumlahSewa.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_JumlahSewa.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Nama"
        '
        'TextBox_Show_Nama
        '
        Me.TextBox_Show_Nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "nama", True))
        Me.TextBox_Show_Nama.Location = New System.Drawing.Point(90, 26)
        Me.TextBox_Show_Nama.Name = "TextBox_Show_Nama"
        Me.TextBox_Show_Nama.ReadOnly = True
        Me.TextBox_Show_Nama.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_Nama.TabIndex = 16
        '
        'TextBox_Show_TotalBayar
        '
        Me.TextBox_Show_TotalBayar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "total_bayar", True))
        Me.TextBox_Show_TotalBayar.Location = New System.Drawing.Point(90, 182)
        Me.TextBox_Show_TotalBayar.Name = "TextBox_Show_TotalBayar"
        Me.TextBox_Show_TotalBayar.ReadOnly = True
        Me.TextBox_Show_TotalBayar.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_TotalBayar.TabIndex = 22
        '
        'TextBox_Show_Status
        '
        Me.TextBox_Show_Status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "status", True))
        Me.TextBox_Show_Status.Location = New System.Drawing.Point(90, 52)
        Me.TextBox_Show_Status.Name = "TextBox_Show_Status"
        Me.TextBox_Show_Status.ReadOnly = True
        Me.TextBox_Show_Status.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_Status.TabIndex = 17
        '
        'TextBox_Show_JumlahBayar
        '
        Me.TextBox_Show_JumlahBayar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "jumlah_bayar", True))
        Me.TextBox_Show_JumlahBayar.Location = New System.Drawing.Point(90, 156)
        Me.TextBox_Show_JumlahBayar.Name = "TextBox_Show_JumlahBayar"
        Me.TextBox_Show_JumlahBayar.ReadOnly = True
        Me.TextBox_Show_JumlahBayar.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_JumlahBayar.TabIndex = 21
        '
        'TextBox_Show_Harga
        '
        Me.TextBox_Show_Harga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "harga", True))
        Me.TextBox_Show_Harga.Location = New System.Drawing.Point(90, 78)
        Me.TextBox_Show_Harga.Name = "TextBox_Show_Harga"
        Me.TextBox_Show_Harga.ReadOnly = True
        Me.TextBox_Show_Harga.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_Harga.TabIndex = 18
        '
        'TextBox_Show_Diskon
        '
        Me.TextBox_Show_Diskon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "diskon", True))
        Me.TextBox_Show_Diskon.Location = New System.Drawing.Point(90, 130)
        Me.TextBox_Show_Diskon.Name = "TextBox_Show_Diskon"
        Me.TextBox_Show_Diskon.ReadOnly = True
        Me.TextBox_Show_Diskon.Size = New System.Drawing.Size(202, 20)
        Me.TextBox_Show_Diskon.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 519)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PelangganBindingSource As BindingSource
    Friend WithEvents PelangganTableAdapter As Database1DataSetTableAdapters.PelangganTableAdapter
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahsewaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahbayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalbayarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Calculate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_TotalBayar As TextBox
    Friend WithEvents TextBox_JumlahBayar As TextBox
    Friend WithEvents TextBox_Diskon As TextBox
    Friend WithEvents TextBox_JumlahSewa As TextBox
    Friend WithEvents TextBox_Harga As TextBox
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button_Last As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_Next As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button_Prev As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button_First As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_Show_JumlahSewa As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_Show_Nama As TextBox
    Friend WithEvents TextBox_Show_TotalBayar As TextBox
    Friend WithEvents TextBox_Show_Status As TextBox
    Friend WithEvents TextBox_Show_JumlahBayar As TextBox
    Friend WithEvents TextBox_Show_Harga As TextBox
    Friend WithEvents TextBox_Show_Diskon As TextBox
    Friend WithEvents ComboBox_Status As ComboBox
End Class
