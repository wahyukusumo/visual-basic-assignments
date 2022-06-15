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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Kode = New System.Windows.Forms.TextBox()
        Me.TB_Judul = New System.Windows.Forms.TextBox()
        Me.TB_Pengarang = New System.Windows.Forms.TextBox()
        Me.TB_Penerbit = New System.Windows.Forms.TextBox()
        Me.TB_Tahun = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Pencarian = New System.Windows.Forms.TextBox()
        Me.BTN_Search = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.KodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp4.Database1DataSet()
        Me.BukuTableAdapter = New WindowsApp4.Database1DataSetTableAdapters.BukuTableAdapter()
        Me.Database1DataSet1 = New WindowsApp4.Database1DataSet()
        Me.BukuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_Search)
        Me.GroupBox1.Controls.Add(Me.TB_Pencarian)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Kode Buku"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.PengarangDataGridViewTextBoxColumn, Me.PenerbitDataGridViewTextBoxColumn, Me.TahunDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BukuBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Buku"
        '
        'TB_Kode
        '
        Me.TB_Kode.Location = New System.Drawing.Point(120, 12)
        Me.TB_Kode.Name = "TB_Kode"
        Me.TB_Kode.Size = New System.Drawing.Size(172, 20)
        Me.TB_Kode.TabIndex = 3
        '
        'TB_Judul
        '
        Me.TB_Judul.Location = New System.Drawing.Point(120, 38)
        Me.TB_Judul.Name = "TB_Judul"
        Me.TB_Judul.Size = New System.Drawing.Size(172, 20)
        Me.TB_Judul.TabIndex = 4
        '
        'TB_Pengarang
        '
        Me.TB_Pengarang.Location = New System.Drawing.Point(120, 64)
        Me.TB_Pengarang.Name = "TB_Pengarang"
        Me.TB_Pengarang.Size = New System.Drawing.Size(172, 20)
        Me.TB_Pengarang.TabIndex = 5
        '
        'TB_Penerbit
        '
        Me.TB_Penerbit.Location = New System.Drawing.Point(120, 90)
        Me.TB_Penerbit.Name = "TB_Penerbit"
        Me.TB_Penerbit.Size = New System.Drawing.Size(172, 20)
        Me.TB_Penerbit.TabIndex = 6
        '
        'TB_Tahun
        '
        Me.TB_Tahun.Location = New System.Drawing.Point(120, 116)
        Me.TB_Tahun.Name = "TB_Tahun"
        Me.TB_Tahun.Size = New System.Drawing.Size(172, 20)
        Me.TB_Tahun.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pengarang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Penerbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tahun"
        '
        'TB_Pencarian
        '
        Me.TB_Pencarian.Location = New System.Drawing.Point(6, 19)
        Me.TB_Pencarian.Name = "TB_Pencarian"
        Me.TB_Pencarian.Size = New System.Drawing.Size(225, 20)
        Me.TB_Pencarian.TabIndex = 12
        '
        'BTN_Search
        '
        Me.BTN_Search.Location = New System.Drawing.Point(156, 45)
        Me.BTN_Search.Name = "BTN_Search"
        Me.BTN_Search.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Search.TabIndex = 12
        Me.BTN_Search.Text = "Cari"
        Me.BTN_Search.UseVisualStyleBackColor = True
        '
        'BTN_Clear
        '
        Me.BTN_Clear.Location = New System.Drawing.Point(314, 113)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(112, 23)
        Me.BTN_Clear.TabIndex = 12
        Me.BTN_Clear.Text = "Bersih"
        Me.BTN_Clear.UseVisualStyleBackColor = True
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(444, 113)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(112, 23)
        Me.BTN_Save.TabIndex = 13
        Me.BTN_Save.Text = "Simpan"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'KodeDataGridViewTextBoxColumn
        '
        Me.KodeDataGridViewTextBoxColumn.DataPropertyName = "kode"
        Me.KodeDataGridViewTextBoxColumn.HeaderText = "kode"
        Me.KodeDataGridViewTextBoxColumn.Name = "KodeDataGridViewTextBoxColumn"
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "judul"
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        '
        'PengarangDataGridViewTextBoxColumn
        '
        Me.PengarangDataGridViewTextBoxColumn.DataPropertyName = "pengarang"
        Me.PengarangDataGridViewTextBoxColumn.HeaderText = "pengarang"
        Me.PengarangDataGridViewTextBoxColumn.Name = "PengarangDataGridViewTextBoxColumn"
        '
        'PenerbitDataGridViewTextBoxColumn
        '
        Me.PenerbitDataGridViewTextBoxColumn.DataPropertyName = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.HeaderText = "penerbit"
        Me.PenerbitDataGridViewTextBoxColumn.Name = "PenerbitDataGridViewTextBoxColumn"
        '
        'TahunDataGridViewTextBoxColumn
        '
        Me.TahunDataGridViewTextBoxColumn.DataPropertyName = "tahun"
        Me.TahunDataGridViewTextBoxColumn.HeaderText = "tahun"
        Me.TahunDataGridViewTextBoxColumn.Name = "TahunDataGridViewTextBoxColumn"
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "Buku"
        Me.BukuBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuBindingSource1
        '
        Me.BukuBindingSource1.DataMember = "Buku"
        Me.BukuBindingSource1.DataSource = Me.Database1DataSet1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 341)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.BTN_Clear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Tahun)
        Me.Controls.Add(Me.TB_Penerbit)
        Me.Controls.Add(Me.TB_Pengarang)
        Me.Controls.Add(Me.TB_Judul)
        Me.Controls.Add(Me.TB_Kode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As Database1DataSetTableAdapters.BukuTableAdapter
    Friend WithEvents BTN_Search As Button
    Friend WithEvents TB_Pencarian As TextBox
    Friend WithEvents KodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PengarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenerbitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_Kode As TextBox
    Friend WithEvents TB_Judul As TextBox
    Friend WithEvents TB_Pengarang As TextBox
    Friend WithEvents TB_Penerbit As TextBox
    Friend WithEvents TB_Tahun As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Save As Button
    Friend WithEvents Database1DataSet1 As Database1DataSet
    Friend WithEvents BukuBindingSource1 As BindingSource
End Class
