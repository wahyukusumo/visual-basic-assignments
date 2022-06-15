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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxMenu = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPaket = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HargaMakanan = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HargaMinuman = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_Water = New System.Windows.Forms.CheckBox()
        Me.CB_IceTea = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_MakanDiTempat = New System.Windows.Forms.RadioButton()
        Me.RB_Delivery = New System.Windows.Forms.RadioButton()
        Me.HargaFasilitas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.InputJumlahBeli = New System.Windows.Forms.TextBox()
        Me.JumlahTotalBayar = New System.Windows.Forms.TextBox()
        Me.InputUangBayar = New System.Windows.Forms.TextBox()
        Me.JumlahKembalian = New System.Windows.Forms.TextBox()
        Me.ButtonNewTransaction = New System.Windows.Forms.Button()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.ListMenu = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Shojumaru", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Cafe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Paket"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Daftar Menu"
        '
        'ComboBoxMenu
        '
        Me.ComboBoxMenu.FormattingEnabled = True
        Me.ComboBoxMenu.Location = New System.Drawing.Point(110, 69)
        Me.ComboBoxMenu.Name = "ComboBoxMenu"
        Me.ComboBoxMenu.Size = New System.Drawing.Size(322, 23)
        Me.ComboBoxMenu.TabIndex = 4
        '
        'ComboBoxPaket
        '
        Me.ComboBoxPaket.FormattingEnabled = True
        Me.ComboBoxPaket.Location = New System.Drawing.Point(110, 101)
        Me.ComboBoxPaket.Name = "ComboBoxPaket"
        Me.ComboBoxPaket.Size = New System.Drawing.Size(322, 23)
        Me.ComboBoxPaket.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Harga"
        '
        'HargaMakanan
        '
        Me.HargaMakanan.Location = New System.Drawing.Point(110, 246)
        Me.HargaMakanan.Name = "HargaMakanan"
        Me.HargaMakanan.ReadOnly = True
        Me.HargaMakanan.Size = New System.Drawing.Size(322, 23)
        Me.HargaMakanan.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HargaMinuman)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CB_Water)
        Me.GroupBox1.Controls.Add(Me.CB_IceTea)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 152)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Minuman"
        '
        'HargaMinuman
        '
        Me.HargaMinuman.Location = New System.Drawing.Point(81, 112)
        Me.HargaMinuman.Name = "HargaMinuman"
        Me.HargaMinuman.ReadOnly = True
        Me.HargaMinuman.Size = New System.Drawing.Size(100, 23)
        Me.HargaMinuman.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Harga"
        '
        'CB_Water
        '
        Me.CB_Water.AutoSize = True
        Me.CB_Water.Location = New System.Drawing.Point(18, 61)
        Me.CB_Water.Name = "CB_Water"
        Me.CB_Water.Size = New System.Drawing.Size(72, 19)
        Me.CB_Water.TabIndex = 1
        Me.CB_Water.Text = "Air Putih"
        Me.CB_Water.UseVisualStyleBackColor = True
        '
        'CB_IceTea
        '
        Me.CB_IceTea.AutoSize = True
        Me.CB_IceTea.Location = New System.Drawing.Point(18, 35)
        Me.CB_IceTea.Name = "CB_IceTea"
        Me.CB_IceTea.Size = New System.Drawing.Size(93, 19)
        Me.CB_IceTea.TabIndex = 0
        Me.CB_IceTea.Text = "Es Teh Manis"
        Me.CB_IceTea.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_MakanDiTempat)
        Me.GroupBox2.Controls.Add(Me.RB_Delivery)
        Me.GroupBox2.Controls.Add(Me.HargaFasilitas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(232, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 152)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fasilitas"
        '
        'RB_MakanDiTempat
        '
        Me.RB_MakanDiTempat.AutoSize = True
        Me.RB_MakanDiTempat.Location = New System.Drawing.Point(16, 61)
        Me.RB_MakanDiTempat.Name = "RB_MakanDiTempat"
        Me.RB_MakanDiTempat.Size = New System.Drawing.Size(117, 19)
        Me.RB_MakanDiTempat.TabIndex = 5
        Me.RB_MakanDiTempat.TabStop = True
        Me.RB_MakanDiTempat.Text = "Makan Di Tempat"
        Me.RB_MakanDiTempat.UseVisualStyleBackColor = True
        '
        'RB_Delivery
        '
        Me.RB_Delivery.AutoSize = True
        Me.RB_Delivery.Location = New System.Drawing.Point(16, 35)
        Me.RB_Delivery.Name = "RB_Delivery"
        Me.RB_Delivery.Size = New System.Drawing.Size(67, 19)
        Me.RB_Delivery.TabIndex = 4
        Me.RB_Delivery.TabStop = True
        Me.RB_Delivery.Text = "Delivery"
        Me.RB_Delivery.UseVisualStyleBackColor = True
        '
        'HargaFasilitas
        '
        Me.HargaFasilitas.Location = New System.Drawing.Point(81, 112)
        Me.HargaFasilitas.Name = "HargaFasilitas"
        Me.HargaFasilitas.ReadOnly = True
        Me.HargaFasilitas.Size = New System.Drawing.Size(100, 23)
        Me.HargaFasilitas.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Jumlah Beli"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 511)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total Bayar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 477)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Uang Bayar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(232, 511)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Kembali"
        '
        'InputJumlahBeli
        '
        Me.InputJumlahBeli.Location = New System.Drawing.Point(93, 474)
        Me.InputJumlahBeli.Name = "InputJumlahBeli"
        Me.InputJumlahBeli.Size = New System.Drawing.Size(100, 23)
        Me.InputJumlahBeli.TabIndex = 16
        Me.InputJumlahBeli.Text = "1"
        '
        'JumlahTotalBayar
        '
        Me.JumlahTotalBayar.Location = New System.Drawing.Point(93, 508)
        Me.JumlahTotalBayar.Name = "JumlahTotalBayar"
        Me.JumlahTotalBayar.ReadOnly = True
        Me.JumlahTotalBayar.Size = New System.Drawing.Size(100, 23)
        Me.JumlahTotalBayar.TabIndex = 17
        '
        'InputUangBayar
        '
        Me.InputUangBayar.Location = New System.Drawing.Point(313, 474)
        Me.InputUangBayar.Name = "InputUangBayar"
        Me.InputUangBayar.Size = New System.Drawing.Size(100, 23)
        Me.InputUangBayar.TabIndex = 18
        '
        'JumlahKembalian
        '
        Me.JumlahKembalian.Location = New System.Drawing.Point(313, 508)
        Me.JumlahKembalian.Name = "JumlahKembalian"
        Me.JumlahKembalian.ReadOnly = True
        Me.JumlahKembalian.Size = New System.Drawing.Size(100, 23)
        Me.JumlahKembalian.TabIndex = 19
        '
        'ButtonNewTransaction
        '
        Me.ButtonNewTransaction.Location = New System.Drawing.Point(196, 574)
        Me.ButtonNewTransaction.Name = "ButtonNewTransaction"
        Me.ButtonNewTransaction.Size = New System.Drawing.Size(123, 23)
        Me.ButtonNewTransaction.TabIndex = 20
        Me.ButtonNewTransaction.Text = "Transaksi Baru"
        Me.ButtonNewTransaction.UseVisualStyleBackColor = True
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(338, 574)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuit.TabIndex = 21
        Me.ButtonQuit.Text = "Keluar"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'ListMenu
        '
        Me.ListMenu.FormattingEnabled = True
        Me.ListMenu.ItemHeight = 15
        Me.ListMenu.Location = New System.Drawing.Point(110, 135)
        Me.ListMenu.Name = "ListMenu"
        Me.ListMenu.Size = New System.Drawing.Size(322, 94)
        Me.ListMenu.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 611)
        Me.Controls.Add(Me.ListMenu)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.ButtonNewTransaction)
        Me.Controls.Add(Me.JumlahKembalian)
        Me.Controls.Add(Me.InputUangBayar)
        Me.Controls.Add(Me.JumlahTotalBayar)
        Me.Controls.Add(Me.InputJumlahBeli)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HargaMakanan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxPaket)
        Me.Controls.Add(Me.ComboBoxMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxMenu As ComboBox
    Friend WithEvents ComboBoxPaket As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents HargaMakanan As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HargaMinuman As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_Water As CheckBox
    Friend WithEvents CB_IceTea As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RB_MakanDiTempat As RadioButton
    Friend WithEvents RB_Delivery As RadioButton
    Friend WithEvents HargaFasilitas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents InputJumlahBeli As TextBox
    Friend WithEvents JumlahTotalBayar As TextBox
    Friend WithEvents InputUangBayar As TextBox
    Friend WithEvents JumlahKembalian As TextBox
    Friend WithEvents ButtonNewTransaction As Button
    Friend WithEvents ButtonQuit As Button
    Friend WithEvents ListMenu As ListBox
End Class
