
namespace MerhabaGunlluk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Ac = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kadet = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_farklıKaydet = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_fontAyarları = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_renkAyarları = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSbtn_Yeni = new System.Windows.Forms.ToolStripButton();
            this.TSbtn_Ac = new System.Windows.Forms.ToolStripButton();
            this.TSbtn_Kaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Font = new System.Windows.Forms.ToolStripComboBox();
            this.TSCB_Size = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Color = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Bold = new System.Windows.Forms.ToolStripButton();
            this.TSMI_Italic = new System.Windows.Forms.ToolStripButton();
            this.TSMI_Underline = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Ac,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Ac
            // 
            this.TSMI_Ac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.toolStripSeparator1,
            this.TSMI_kadet,
            this.farklıKaydetToolStripMenuItem,
            this.TSMI_farklıKaydet,
            this.TSMI_kapat});
            this.TSMI_Ac.Name = "TSMI_Ac";
            this.TSMI_Ac.Size = new System.Drawing.Size(64, 24);
            this.TSMI_Ac.Text = "Dosya";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.aÇToolStripMenuItem.Text = "Ac";
            this.aÇToolStripMenuItem.Click += new System.EventHandler(this.aÇToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // TSMI_kadet
            // 
            this.TSMI_kadet.Name = "TSMI_kadet";
            this.TSMI_kadet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_kadet.Size = new System.Drawing.Size(188, 26);
            this.TSMI_kadet.Text = "Kaydet";
            this.TSMI_kadet.Click += new System.EventHandler(this.TSMI_kadet_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // TSMI_farklıKaydet
            // 
            this.TSMI_farklıKaydet.Name = "TSMI_farklıKaydet";
            this.TSMI_farklıKaydet.Size = new System.Drawing.Size(185, 6);
            // 
            // TSMI_kapat
            // 
            this.TSMI_kapat.Name = "TSMI_kapat";
            this.TSMI_kapat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TSMI_kapat.Size = new System.Drawing.Size(188, 26);
            this.TSMI_kapat.Text = "Kapat";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_fontAyarları,
            this.TSMI_renkAyarları});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // TSMI_fontAyarları
            // 
            this.TSMI_fontAyarları.Name = "TSMI_fontAyarları";
            this.TSMI_fontAyarları.Size = new System.Drawing.Size(179, 26);
            this.TSMI_fontAyarları.Text = "Font Ayarları";
            this.TSMI_fontAyarları.Click += new System.EventHandler(this.TSMI_fontAyarları_Click);
            // 
            // TSMI_renkAyarları
            // 
            this.TSMI_renkAyarları.Name = "TSMI_renkAyarları";
            this.TSMI_renkAyarları.Size = new System.Drawing.Size(179, 26);
            this.TSMI_renkAyarları.Text = "Renk Ayarları";
            this.TSMI_renkAyarları.Click += new System.EventHandler(this.TSMI_renkAyarları_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(888, 489);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSbtn_Yeni,
            this.TSbtn_Ac,
            this.TSbtn_Kaydet,
            this.toolStripSeparator2,
            this.TSMI_Font,
            this.TSCB_Size,
            this.toolStripSeparator3,
            this.TSMI_Color,
            this.toolStripSeparator4,
            this.TSMI_Bold,
            this.TSMI_Italic,
            this.TSMI_Underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(941, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSbtn_Yeni
            // 
            this.TSbtn_Yeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSbtn_Yeni.Image = ((System.Drawing.Image)(resources.GetObject("TSbtn_Yeni.Image")));
            this.TSbtn_Yeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtn_Yeni.Name = "TSbtn_Yeni";
            this.TSbtn_Yeni.Size = new System.Drawing.Size(29, 25);
            this.TSbtn_Yeni.Text = "toolStripButton1";
            // 
            // TSbtn_Ac
            // 
            this.TSbtn_Ac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSbtn_Ac.Image = ((System.Drawing.Image)(resources.GetObject("TSbtn_Ac.Image")));
            this.TSbtn_Ac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtn_Ac.Name = "TSbtn_Ac";
            this.TSbtn_Ac.Size = new System.Drawing.Size(29, 25);
            this.TSbtn_Ac.Text = "toolStripButton1";
            this.TSbtn_Ac.Click += new System.EventHandler(this.aÇToolStripMenuItem_Click);
            // 
            // TSbtn_Kaydet
            // 
            this.TSbtn_Kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSbtn_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSbtn_Kaydet.Image")));
            this.TSbtn_Kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtn_Kaydet.Name = "TSbtn_Kaydet";
            this.TSbtn_Kaydet.Size = new System.Drawing.Size(29, 25);
            this.TSbtn_Kaydet.Text = "toolStripButton1";
            this.TSbtn_Kaydet.Click += new System.EventHandler(this.TSMI_kadet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // TSMI_Font
            // 
            this.TSMI_Font.Name = "TSMI_Font";
            this.TSMI_Font.Size = new System.Drawing.Size(200, 28);
            this.TSMI_Font.SelectedIndexChanged += new System.EventHandler(this.TSMI_Font_SelectedIndexChanged);
            // 
            // TSCB_Size
            // 
            this.TSCB_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "28",
            "36",
            "48",
            "72"});
            this.TSCB_Size.Name = "TSCB_Size";
            this.TSCB_Size.Size = new System.Drawing.Size(75, 28);
            this.TSCB_Size.SelectedIndexChanged += new System.EventHandler(this.TSCB_Size_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // TSMI_Color
            // 
            this.TSMI_Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Color.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMI_Color.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Color.Image")));
            this.TSMI_Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Color.Name = "TSMI_Color";
            this.TSMI_Color.Size = new System.Drawing.Size(29, 25);
            this.TSMI_Color.Text = "A";
            this.TSMI_Color.Click += new System.EventHandler(this.TSMI_Color_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // TSMI_Bold
            // 
            this.TSMI_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSMI_Bold.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Bold.Image")));
            this.TSMI_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Bold.Name = "TSMI_Bold";
            this.TSMI_Bold.Size = new System.Drawing.Size(29, 25);
            this.TSMI_Bold.Text = "K";
            this.TSMI_Bold.Click += new System.EventHandler(this.TSMI_Bold_Click);
            // 
            // TSMI_Italic
            // 
            this.TSMI_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.TSMI_Italic.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Italic.Image")));
            this.TSMI_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Italic.Name = "TSMI_Italic";
            this.TSMI_Italic.Size = new System.Drawing.Size(29, 25);
            this.TSMI_Italic.Text = "I";
            this.TSMI_Italic.Click += new System.EventHandler(this.TSMI_Italic_Click);
            // 
            // TSMI_Underline
            // 
            this.TSMI_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSMI_Underline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.TSMI_Underline.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_Underline.Image")));
            this.TSMI_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSMI_Underline.Name = "TSMI_Underline";
            this.TSMI_Underline.Size = new System.Drawing.Size(29, 25);
            this.TSMI_Underline.Text = "A";
            this.TSMI_Underline.Click += new System.EventHandler(this.TSMI_Underline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 577);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ac;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kadet;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TSMI_farklıKaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kapat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSbtn_Yeni;
        private System.Windows.Forms.ToolStripButton TSbtn_Ac;
        private System.Windows.Forms.ToolStripButton TSbtn_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_fontAyarları;
        private System.Windows.Forms.ToolStripMenuItem TSMI_renkAyarları;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox TSMI_Font;
        private System.Windows.Forms.ToolStripComboBox TSCB_Size;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSMI_Color;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSMI_Bold;
        private System.Windows.Forms.ToolStripButton TSMI_Italic;
        private System.Windows.Forms.ToolStripButton TSMI_Underline;
    }
}

