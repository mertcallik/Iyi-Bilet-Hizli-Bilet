namespace Mert9.hafta.Areas.Admin
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.KryptonGroupBox GroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btncikisyap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTurlar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTasitlar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPersoneller = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBiletler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnMusteriler = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Adminlbl1 = new System.Windows.Forms.Label();
            this.dgAdmin = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxSearchMusteri = new System.Windows.Forms.TextBox();
            this.tbxSearchBilet = new System.Windows.Forms.TextBox();
            this.tbxSearchPersonel = new System.Windows.Forms.TextBox();
            this.tbxSearchTasit = new System.Windows.Forms.TextBox();
            this.tbxSearchTur = new System.Windows.Forms.TextBox();
            this.tbxTurKalkisNoktasi = new System.Windows.Forms.TextBox();
            this.tbxTurHedefNoktasi = new System.Windows.Forms.TextBox();
            this.turDtpicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnaddturbyadmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.turaddgbx = new System.Windows.Forms.GroupBox();
            this.personeladdbox = new System.Windows.Forms.GroupBox();
            this.tbxpersonelsalary = new System.Windows.Forms.TextBox();
            this.tbxPersonelAdi = new System.Windows.Forms.TextBox();
            this.btnaddpersonelbyadmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbxPersonelSoyadi = new System.Windows.Forms.TextBox();
            this.dtptbxpersonebirthdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.tasitgbx = new System.Windows.Forms.GroupBox();
            this.tbxtasitplate = new System.Windows.Forms.TextBox();
            this.btnaddtasitbyadmin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbxtasittype = new System.Windows.Forms.TextBox();
            this.btnsil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            GroupBox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(GroupBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(GroupBox.Panel)).BeginInit();
            GroupBox.Panel.SuspendLayout();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.turaddgbx.SuspendLayout();
            this.personeladdbox.SuspendLayout();
            this.tasitgbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            GroupBox.CaptionOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            GroupBox.Location = new System.Drawing.Point(8, 0);
            GroupBox.Name = "GroupBox";
            GroupBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            // 
            // GroupBox.Panel
            // 
            GroupBox.Panel.Controls.Add(this.btncikisyap);
            GroupBox.Panel.Controls.Add(this.btnTurlar);
            GroupBox.Panel.Controls.Add(this.btnTasitlar);
            GroupBox.Panel.Controls.Add(this.btnPersoneller);
            GroupBox.Panel.Controls.Add(this.btnBiletler);
            GroupBox.Panel.Controls.Add(this.btnMusteriler);
            GroupBox.Size = new System.Drawing.Size(126, 403);
            GroupBox.TabIndex = 12;
            GroupBox.Values.Heading = "Admin";
            // 
            // btncikisyap
            // 
            this.btncikisyap.Location = new System.Drawing.Point(10, 330);
            this.btncikisyap.Margin = new System.Windows.Forms.Padding(0);
            this.btncikisyap.Name = "btncikisyap";
            this.btncikisyap.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btncikisyap.Size = new System.Drawing.Size(100, 30);
            this.btncikisyap.TabIndex = 24;
            this.btncikisyap.Tag = "";
            this.btncikisyap.Values.Text = "Çıkış Yap";
            this.btncikisyap.Click += new System.EventHandler(this.btncikisyap_Click);
            // 
            // btnTurlar
            // 
            this.btnTurlar.Location = new System.Drawing.Point(10, 270);
            this.btnTurlar.Margin = new System.Windows.Forms.Padding(0);
            this.btnTurlar.Name = "btnTurlar";
            this.btnTurlar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTurlar.Size = new System.Drawing.Size(100, 30);
            this.btnTurlar.TabIndex = 21;
            this.btnTurlar.Values.Text = "Turlar";
            this.btnTurlar.Click += new System.EventHandler(this.btnTurlar_Click);
            // 
            // btnTasitlar
            // 
            this.btnTasitlar.Location = new System.Drawing.Point(10, 210);
            this.btnTasitlar.Margin = new System.Windows.Forms.Padding(0);
            this.btnTasitlar.Name = "btnTasitlar";
            this.btnTasitlar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTasitlar.Size = new System.Drawing.Size(100, 30);
            this.btnTasitlar.TabIndex = 20;
            this.btnTasitlar.Values.Text = "Tasitlar";
            this.btnTasitlar.Click += new System.EventHandler(this.btnTasitlar_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(10, 150);
            this.btnPersoneller.Margin = new System.Windows.Forms.Padding(0);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPersoneller.Size = new System.Drawing.Size(100, 30);
            this.btnPersoneller.TabIndex = 19;
            this.btnPersoneller.Values.Text = "Personeller";
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnBiletler
            // 
            this.btnBiletler.Location = new System.Drawing.Point(10, 90);
            this.btnBiletler.Margin = new System.Windows.Forms.Padding(0);
            this.btnBiletler.Name = "btnBiletler";
            this.btnBiletler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBiletler.Size = new System.Drawing.Size(100, 30);
            this.btnBiletler.TabIndex = 18;
            this.btnBiletler.Values.Text = "Biletler";
            this.btnBiletler.Click += new System.EventHandler(this.btnBiletler_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(10, 30);
            this.btnMusteriler.Margin = new System.Windows.Forms.Padding(0);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnMusteriler.Size = new System.Drawing.Size(100, 30);
            this.btnMusteriler.TabIndex = 17;
            this.btnMusteriler.Values.Text = "Müşteriler";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed")));
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking")));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // Adminlbl1
            // 
            this.Adminlbl1.AutoSize = true;
            this.Adminlbl1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Adminlbl1.Location = new System.Drawing.Point(800, 10);
            this.Adminlbl1.Margin = new System.Windows.Forms.Padding(0);
            this.Adminlbl1.Name = "Adminlbl1";
            this.Adminlbl1.Size = new System.Drawing.Size(123, 23);
            this.Adminlbl1.TabIndex = 9;
            this.Adminlbl1.Text = "İyi Bilet Hızli Bilet";
            // 
            // dgAdmin
            // 
            this.dgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdmin.Location = new System.Drawing.Point(134, 57);
            this.dgAdmin.Name = "dgAdmin";
            this.dgAdmin.RowHeadersWidth = 51;
            this.dgAdmin.RowTemplate.Height = 24;
            this.dgAdmin.Size = new System.Drawing.Size(894, 346);
            this.dgAdmin.TabIndex = 10;
            this.dgAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdmin_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(774, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbxSearchMusteri
            // 
            this.tbxSearchMusteri.Location = new System.Drawing.Point(499, 29);
            this.tbxSearchMusteri.Name = "tbxSearchMusteri";
            this.tbxSearchMusteri.Size = new System.Drawing.Size(150, 22);
            this.tbxSearchMusteri.TabIndex = 13;
            this.tbxSearchMusteri.Text = "Search Müşteri Name";
            this.tbxSearchMusteri.TextChanged += new System.EventHandler(this.tbxSearchMusteri_TextChanged_1);
            // 
            // tbxSearchBilet
            // 
            this.tbxSearchBilet.Location = new System.Drawing.Point(499, 28);
            this.tbxSearchBilet.Name = "tbxSearchBilet";
            this.tbxSearchBilet.Size = new System.Drawing.Size(150, 22);
            this.tbxSearchBilet.TabIndex = 14;
            this.tbxSearchBilet.Text = "Search Bilet Id";
            this.tbxSearchBilet.Visible = false;
            this.tbxSearchBilet.TextChanged += new System.EventHandler(this.tbxSearchBilet_TextChanged_1);
            // 
            // tbxSearchPersonel
            // 
            this.tbxSearchPersonel.Location = new System.Drawing.Point(499, 28);
            this.tbxSearchPersonel.Name = "tbxSearchPersonel";
            this.tbxSearchPersonel.Size = new System.Drawing.Size(150, 22);
            this.tbxSearchPersonel.TabIndex = 15;
            this.tbxSearchPersonel.Text = "Search Personel Name";
            this.tbxSearchPersonel.Visible = false;
            this.tbxSearchPersonel.TextChanged += new System.EventHandler(this.tbxSearchPersonel_TextChanged_1);
            // 
            // tbxSearchTasit
            // 
            this.tbxSearchTasit.Location = new System.Drawing.Point(499, 29);
            this.tbxSearchTasit.Name = "tbxSearchTasit";
            this.tbxSearchTasit.Size = new System.Drawing.Size(150, 22);
            this.tbxSearchTasit.TabIndex = 16;
            this.tbxSearchTasit.Text = "Search Tasit by Plate";
            this.tbxSearchTasit.Visible = false;
            this.tbxSearchTasit.TextChanged += new System.EventHandler(this.tbxSearchTasit_TextChanged_1);
            // 
            // tbxSearchTur
            // 
            this.tbxSearchTur.Location = new System.Drawing.Point(499, 28);
            this.tbxSearchTur.Name = "tbxSearchTur";
            this.tbxSearchTur.Size = new System.Drawing.Size(150, 22);
            this.tbxSearchTur.TabIndex = 17;
            this.tbxSearchTur.Text = "Search Tur Id";
            this.tbxSearchTur.Visible = false;
            this.tbxSearchTur.TextChanged += new System.EventHandler(this.tbxSearchTur_TextChanged);
            // 
            // tbxTurKalkisNoktasi
            // 
            this.tbxTurKalkisNoktasi.Location = new System.Drawing.Point(175, 21);
            this.tbxTurKalkisNoktasi.Name = "tbxTurKalkisNoktasi";
            this.tbxTurKalkisNoktasi.Size = new System.Drawing.Size(150, 22);
            this.tbxTurKalkisNoktasi.TabIndex = 19;
            this.tbxTurKalkisNoktasi.Text = "Kalkış Noktası";
            // 
            // tbxTurHedefNoktasi
            // 
            this.tbxTurHedefNoktasi.Location = new System.Drawing.Point(352, 21);
            this.tbxTurHedefNoktasi.Name = "tbxTurHedefNoktasi";
            this.tbxTurHedefNoktasi.Size = new System.Drawing.Size(150, 22);
            this.tbxTurHedefNoktasi.TabIndex = 20;
            this.tbxTurHedefNoktasi.Text = "Hedef Noktası";
            // 
            // turDtpicker
            // 
            this.turDtpicker.Location = new System.Drawing.Point(532, 21);
            this.turDtpicker.Name = "turDtpicker";
            this.turDtpicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.turDtpicker.Size = new System.Drawing.Size(191, 25);
            this.turDtpicker.TabIndex = 21;
            // 
            // btnaddturbyadmin
            // 
            this.btnaddturbyadmin.Location = new System.Drawing.Point(754, 18);
            this.btnaddturbyadmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnaddturbyadmin.Name = "btnaddturbyadmin";
            this.btnaddturbyadmin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnaddturbyadmin.Size = new System.Drawing.Size(119, 30);
            this.btnaddturbyadmin.TabIndex = 22;
            this.btnaddturbyadmin.Values.Text = "Tur Ekle";
            this.btnaddturbyadmin.Click += new System.EventHandler(this.btnaddturbyadmin_Click);
            // 
            // turaddgbx
            // 
            this.turaddgbx.Controls.Add(this.tbxTurKalkisNoktasi);
            this.turaddgbx.Controls.Add(this.btnaddturbyadmin);
            this.turaddgbx.Controls.Add(this.tbxTurHedefNoktasi);
            this.turaddgbx.Controls.Add(this.turDtpicker);
            this.turaddgbx.Location = new System.Drawing.Point(152, 407);
            this.turaddgbx.Name = "turaddgbx";
            this.turaddgbx.Size = new System.Drawing.Size(876, 76);
            this.turaddgbx.TabIndex = 23;
            this.turaddgbx.TabStop = false;
            this.turaddgbx.Text = "Yeni Tur Düzenle";
            this.turaddgbx.Visible = false;
            // 
            // personeladdbox
            // 
            this.personeladdbox.Controls.Add(this.tbxpersonelsalary);
            this.personeladdbox.Controls.Add(this.tbxPersonelAdi);
            this.personeladdbox.Controls.Add(this.btnaddpersonelbyadmin);
            this.personeladdbox.Controls.Add(this.tbxPersonelSoyadi);
            this.personeladdbox.Controls.Add(this.dtptbxpersonebirthdate);
            this.personeladdbox.Location = new System.Drawing.Point(152, 408);
            this.personeladdbox.Name = "personeladdbox";
            this.personeladdbox.Size = new System.Drawing.Size(876, 87);
            this.personeladdbox.TabIndex = 24;
            this.personeladdbox.TabStop = false;
            this.personeladdbox.Text = "Personel Ekle";
            this.personeladdbox.Visible = false;
            // 
            // tbxpersonelsalary
            // 
            this.tbxpersonelsalary.Location = new System.Drawing.Point(364, 18);
            this.tbxpersonelsalary.Name = "tbxpersonelsalary";
            this.tbxpersonelsalary.Size = new System.Drawing.Size(150, 22);
            this.tbxpersonelsalary.TabIndex = 23;
            this.tbxpersonelsalary.Text = "Maaş";
            // 
            // tbxPersonelAdi
            // 
            this.tbxPersonelAdi.Location = new System.Drawing.Point(20, 18);
            this.tbxPersonelAdi.Name = "tbxPersonelAdi";
            this.tbxPersonelAdi.Size = new System.Drawing.Size(150, 22);
            this.tbxPersonelAdi.TabIndex = 19;
            this.tbxPersonelAdi.Text = "Personel Adı";
            // 
            // btnaddpersonelbyadmin
            // 
            this.btnaddpersonelbyadmin.Location = new System.Drawing.Point(754, 18);
            this.btnaddpersonelbyadmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnaddpersonelbyadmin.Name = "btnaddpersonelbyadmin";
            this.btnaddpersonelbyadmin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnaddpersonelbyadmin.Size = new System.Drawing.Size(119, 30);
            this.btnaddpersonelbyadmin.TabIndex = 22;
            this.btnaddpersonelbyadmin.Values.Text = "Personeli Ekle";
            this.btnaddpersonelbyadmin.Click += new System.EventHandler(this.btnaddpersonelbyadmin_Click);
            // 
            // tbxPersonelSoyadi
            // 
            this.tbxPersonelSoyadi.Location = new System.Drawing.Point(187, 18);
            this.tbxPersonelSoyadi.Name = "tbxPersonelSoyadi";
            this.tbxPersonelSoyadi.Size = new System.Drawing.Size(150, 22);
            this.tbxPersonelSoyadi.TabIndex = 20;
            this.tbxPersonelSoyadi.Text = "Personel Soyadi";
            // 
            // dtptbxpersonebirthdate
            // 
            this.dtptbxpersonebirthdate.Location = new System.Drawing.Point(544, 18);
            this.dtptbxpersonebirthdate.Name = "dtptbxpersonebirthdate";
            this.dtptbxpersonebirthdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtptbxpersonebirthdate.Size = new System.Drawing.Size(171, 25);
            this.dtptbxpersonebirthdate.TabIndex = 21;
            // 
            // tasitgbx
            // 
            this.tasitgbx.Controls.Add(this.tbxtasitplate);
            this.tasitgbx.Controls.Add(this.btnaddtasitbyadmin);
            this.tasitgbx.Controls.Add(this.tbxtasittype);
            this.tasitgbx.Location = new System.Drawing.Point(152, 407);
            this.tasitgbx.Name = "tasitgbx";
            this.tasitgbx.Size = new System.Drawing.Size(876, 87);
            this.tasitgbx.TabIndex = 25;
            this.tasitgbx.TabStop = false;
            this.tasitgbx.Text = "Taşıt Ekle";
            this.tasitgbx.Visible = false;
            // 
            // tbxtasitplate
            // 
            this.tbxtasitplate.Location = new System.Drawing.Point(20, 18);
            this.tbxtasitplate.Name = "tbxtasitplate";
            this.tbxtasitplate.Size = new System.Drawing.Size(150, 22);
            this.tbxtasitplate.TabIndex = 19;
            this.tbxtasitplate.Text = "Taşıt Plate";
            // 
            // btnaddtasitbyadmin
            // 
            this.btnaddtasitbyadmin.Location = new System.Drawing.Point(754, 18);
            this.btnaddtasitbyadmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnaddtasitbyadmin.Name = "btnaddtasitbyadmin";
            this.btnaddtasitbyadmin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnaddtasitbyadmin.Size = new System.Drawing.Size(119, 30);
            this.btnaddtasitbyadmin.TabIndex = 22;
            this.btnaddtasitbyadmin.Values.Text = "Taşıt Ekle";
            this.btnaddtasitbyadmin.Click += new System.EventHandler(this.btnaddtasitbyadmin_Click);
            // 
            // tbxtasittype
            // 
            this.tbxtasittype.Location = new System.Drawing.Point(196, 18);
            this.tbxtasittype.Name = "tbxtasittype";
            this.tbxtasittype.Size = new System.Drawing.Size(150, 22);
            this.tbxtasittype.TabIndex = 20;
            this.tbxtasittype.Text = "Taşıtın Türü";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(137, 22);
            this.btnsil.Margin = new System.Windows.Forms.Padding(0);
            this.btnsil.Name = "btnsil";
            this.btnsil.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnsil.Size = new System.Drawing.Size(141, 30);
            this.btnsil.TabIndex = 23;
            this.btnsil.Values.Text = "Seçili Kolonu Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1038, 511);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.tasitgbx);
            this.Controls.Add(this.personeladdbox);
            this.Controls.Add(this.tbxSearchTur);
            this.Controls.Add(this.turaddgbx);
            this.Controls.Add(this.tbxSearchTasit);
            this.Controls.Add(this.tbxSearchPersonel);
            this.Controls.Add(this.tbxSearchBilet);
            this.Controls.Add(this.tbxSearchMusteri);
            this.Controls.Add(GroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgAdmin);
            this.Controls.Add(this.Adminlbl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(GroupBox.Panel)).EndInit();
            GroupBox.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(GroupBox)).EndInit();
            GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.turaddgbx.ResumeLayout(false);
            this.turaddgbx.PerformLayout();
            this.personeladdbox.ResumeLayout(false);
            this.personeladdbox.PerformLayout();
            this.tasitgbx.ResumeLayout(false);
            this.tasitgbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label Adminlbl1;
        private System.Windows.Forms.DataGridView dgAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMusteriler;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBiletler;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btncikisyap;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTurlar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTasitlar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPersoneller;
        private System.Windows.Forms.TextBox tbxSearchMusteri;
        private System.Windows.Forms.TextBox tbxSearchBilet;
        private System.Windows.Forms.TextBox tbxSearchPersonel;
        private System.Windows.Forms.TextBox tbxSearchTasit;
        private System.Windows.Forms.TextBox tbxSearchTur;
        private System.Windows.Forms.TextBox tbxTurKalkisNoktasi;
        private System.Windows.Forms.TextBox tbxTurHedefNoktasi;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker turDtpicker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddturbyadmin;
        private System.Windows.Forms.GroupBox turaddgbx;
        private System.Windows.Forms.GroupBox personeladdbox;
        private System.Windows.Forms.TextBox tbxPersonelAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddpersonelbyadmin;
        private System.Windows.Forms.TextBox tbxPersonelSoyadi;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtptbxpersonebirthdate;
        private System.Windows.Forms.TextBox tbxpersonelsalary;
        private System.Windows.Forms.GroupBox tasitgbx;
        private System.Windows.Forms.TextBox tbxtasitplate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddtasitbyadmin;
        private System.Windows.Forms.TextBox tbxtasittype;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnsil;
    }
}