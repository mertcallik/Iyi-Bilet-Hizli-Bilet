
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace Mert9.hafta
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxgirisemail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnregister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbxgirissifre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnlogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "İyi Bilet Hızli Bilet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 163);
            this.label2.MaximumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "İyi Bilet Hızlı Bilet Giriş Ekranı";
            // 
            // tbxgirisemail
            // 
            this.tbxgirisemail.Location = new System.Drawing.Point(37, 241);
            this.tbxgirisemail.Name = "tbxgirisemail";
            this.tbxgirisemail.Size = new System.Drawing.Size(379, 45);
            this.tbxgirisemail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbxgirisemail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxgirisemail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxgirisemail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxgirisemail.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbxgirisemail.StateCommon.Border.Rounding = 20;
            this.tbxgirisemail.StateCommon.Border.Width = 1;
            this.tbxgirisemail.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tbxgirisemail.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxgirisemail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbxgirisemail.TabIndex = 4;
            this.tbxgirisemail.Text = "E-Mail";
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(217, 380);
            this.btnregister.Name = "btnregister";
            this.btnregister.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(174)))));
            this.btnregister.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnregister.OverrideDefault.Back.ColorAngle = 45F;
            this.btnregister.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.btnregister.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.btnregister.OverrideDefault.Border.ColorAngle = 45F;
            this.btnregister.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregister.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregister.OverrideDefault.Border.Rounding = 20;
            this.btnregister.OverrideDefault.Border.Width = 1;
            this.btnregister.Palette = this.kryptonPalette1;
            this.btnregister.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnregister.Size = new System.Drawing.Size(155, 43);
            this.btnregister.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnregister.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnregister.StateCommon.Back.ColorAngle = 45F;
            this.btnregister.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnregister.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnregister.StateCommon.Border.ColorAngle = 45F;
            this.btnregister.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregister.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregister.StateCommon.Border.Rounding = 20;
            this.btnregister.StateCommon.Border.Width = 1;
            this.btnregister.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnregister.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnregister.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnregister.StatePressed.Back.ColorAngle = 135F;
            this.btnregister.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnregister.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnregister.StatePressed.Border.ColorAngle = 135F;
            this.btnregister.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregister.StatePressed.Border.Rounding = 20;
            this.btnregister.StatePressed.Border.Width = 1;
            this.btnregister.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnregister.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnregister.StateTracking.Back.ColorAngle = 45F;
            this.btnregister.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnregister.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnregister.StateTracking.Border.ColorAngle = 45F;
            this.btnregister.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnregister.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnregister.StateTracking.Border.Rounding = 20;
            this.btnregister.StateTracking.Border.Width = 1;
            this.btnregister.TabIndex = 5;
            this.btnregister.Values.Text = "Hadi Bize Katıl";
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // tbxgirissifre
            // 
            this.tbxgirissifre.Location = new System.Drawing.Point(37, 307);
            this.tbxgirissifre.Name = "tbxgirissifre";
            this.tbxgirissifre.Size = new System.Drawing.Size(379, 45);
            this.tbxgirissifre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbxgirissifre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxgirissifre.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbxgirissifre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbxgirissifre.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbxgirissifre.StateCommon.Border.Rounding = 20;
            this.tbxgirissifre.StateCommon.Border.Width = 1;
            this.tbxgirissifre.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.tbxgirissifre.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxgirissifre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbxgirissifre.TabIndex = 6;
            this.tbxgirissifre.Text = "Şifre";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(41, 380);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnlogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnlogin.OverrideDefault.Back.ColorAngle = 45F;
            this.btnlogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnlogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.btnlogin.OverrideDefault.Border.ColorAngle = 45F;
            this.btnlogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnlogin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnlogin.OverrideDefault.Border.Rounding = 20;
            this.btnlogin.OverrideDefault.Border.Width = 1;
            this.btnlogin.Palette = this.kryptonPalette1;
            this.btnlogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnlogin.Size = new System.Drawing.Size(124, 43);
            this.btnlogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnlogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnlogin.StateCommon.Back.ColorAngle = 45F;
            this.btnlogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnlogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnlogin.StateCommon.Border.ColorAngle = 45F;
            this.btnlogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnlogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnlogin.StateCommon.Border.Rounding = 20;
            this.btnlogin.StateCommon.Border.Width = 1;
            this.btnlogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnlogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnlogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnlogin.StatePressed.Back.ColorAngle = 135F;
            this.btnlogin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnlogin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnlogin.StatePressed.Border.ColorAngle = 135F;
            this.btnlogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnlogin.StatePressed.Border.Rounding = 20;
            this.btnlogin.StatePressed.Border.Width = 1;
            this.btnlogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnlogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnlogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnlogin.StateTracking.Back.ColorAngle = 45F;
            this.btnlogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnlogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnlogin.StateTracking.Border.ColorAngle = 45F;
            this.btnlogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnlogin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnlogin.StateTracking.Border.Rounding = 20;
            this.btnlogin.StateTracking.Border.Width = 1;
            this.btnlogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Values.Text = "Giriş Yap";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel
            // 
            this.kryptonLabel.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel.Name = "kryptonLabel";
            this.kryptonLabel.Size = new System.Drawing.Size(90, 25);
            this.kryptonLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kryptonLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbxgirissifre);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.tbxgirisemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "İyi Bilet Hızlı Bilet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxgirisemail;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnregister;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbxgirissifre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KryptonLabel kryptonLabel;
    }
}

