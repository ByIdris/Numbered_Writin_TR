namespace Sayi_Yazi_Ile
{
    partial class Sayiyi_Yaziyla_Yaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sonuc = new System.Windows.Forms.RichTextBox();
            this.Sayi = new System.Windows.Forms.TextBox();
            this.Yaz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayıyı Giriniz:";
            // 
            // Sonuc
            // 
            this.Sonuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sonuc.Location = new System.Drawing.Point(10, 59);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(381, 85);
            this.Sonuc.TabIndex = 2;
            this.Sonuc.Text = "";
            this.Sonuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sonuc_KeyDown);
            this.Sonuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sonuc_KeyPress);
            // 
            // Sayi
            // 
            this.Sayi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sayi.Location = new System.Drawing.Point(109, 27);
            this.Sayi.MaxLength = 189;
            this.Sayi.Name = "Sayi";
            this.Sayi.Size = new System.Drawing.Size(178, 26);
            this.Sayi.TabIndex = 0;
            this.Sayi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sayi_KeyDown);
            this.Sayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sayi_KeyPress);
            // 
            // Yaz
            // 
            this.Yaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Yaz.Location = new System.Drawing.Point(293, 27);
            this.Yaz.Name = "Yaz";
            this.Yaz.Size = new System.Drawing.Size(98, 26);
            this.Yaz.TabIndex = 0;
            this.Yaz.Text = "Yaz";
            this.Yaz.UseVisualStyleBackColor = true;
            this.Yaz.Click += new System.EventHandler(this.Yaz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.biçimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Ust_Menu";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // biçimToolStripMenuItem
            // 
            this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaziTipiToolStripMenuItem});
            this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            this.biçimToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.biçimToolStripMenuItem.Text = "Biçim";
            // 
            // yaziTipiToolStripMenuItem
            // 
            this.yaziTipiToolStripMenuItem.Name = "yaziTipiToolStripMenuItem";
            this.yaziTipiToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.yaziTipiToolStripMenuItem.Text = "Yazi Tipi";
            this.yaziTipiToolStripMenuItem.Click += new System.EventHandler(this.yaziTipiToolStripMenuItem_Click);
            // 
            // Sayiyi_Yaziyla_Yaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 151);
            this.Controls.Add(this.Sayi);
            this.Controls.Add(this.Yaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(415, 190);
            this.Name = "Sayiyi_Yaziyla_Yaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayıyı Yazıyla Yazma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Sonuc;
        private System.Windows.Forms.TextBox Sayi;
        private System.Windows.Forms.Button Yaz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
    }
}

