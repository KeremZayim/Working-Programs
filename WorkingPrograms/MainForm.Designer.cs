
namespace WorkingPrograms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerYenileme = new System.Windows.Forms.Timer(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSecileniKopyala = new System.Windows.Forms.Button();
            this.lbProgramlar = new System.Windows.Forms.ListBox();
            this.switchYenileme = new MaterialSkin.Controls.MaterialSwitch();
            this.btnYenile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerYenileme
            // 
            this.timerYenileme.Enabled = true;
            this.timerYenileme.Interval = 10000;
            this.timerYenileme.Tick += new System.EventHandler(this.timerYenile);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(230, 480);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 55);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.Kaydet);
            // 
            // btnSecileniKopyala
            // 
            this.btnSecileniKopyala.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnSecileniKopyala.Location = new System.Drawing.Point(12, 480);
            this.btnSecileniKopyala.Name = "btnSecileniKopyala";
            this.btnSecileniKopyala.Size = new System.Drawing.Size(110, 55);
            this.btnSecileniKopyala.TabIndex = 1;
            this.btnSecileniKopyala.Text = "Seçileni Kopyala";
            this.btnSecileniKopyala.UseVisualStyleBackColor = true;
            this.btnSecileniKopyala.Click += new System.EventHandler(this.SecileniKopyala);
            // 
            // lbProgramlar
            // 
            this.lbProgramlar.FormattingEnabled = true;
            this.lbProgramlar.Location = new System.Drawing.Point(12, 9);
            this.lbProgramlar.Name = "lbProgramlar";
            this.lbProgramlar.Size = new System.Drawing.Size(324, 420);
            this.lbProgramlar.TabIndex = 2;
            // 
            // switchYenileme
            // 
            this.switchYenileme.AutoSize = true;
            this.switchYenileme.BackColor = System.Drawing.Color.DarkOrange;
            this.switchYenileme.Checked = true;
            this.switchYenileme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchYenileme.Depth = 0;
            this.switchYenileme.Location = new System.Drawing.Point(80, 436);
            this.switchYenileme.Margin = new System.Windows.Forms.Padding(0);
            this.switchYenileme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchYenileme.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchYenileme.Name = "switchYenileme";
            this.switchYenileme.Ripple = true;
            this.switchYenileme.Size = new System.Drawing.Size(192, 37);
            this.switchYenileme.TabIndex = 3;
            this.switchYenileme.Text = "Otomatik Yenileme";
            this.switchYenileme.UseVisualStyleBackColor = false;
            this.switchYenileme.CheckedChanged += new System.EventHandler(this.switchYenileme_CheckedChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.Location = new System.Drawing.Point(128, 480);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(96, 55);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.YenileButonu);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kopyala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Kopyala);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "by Kerem Zayim";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switchYenileme);
            this.Controls.Add(this.lbProgramlar);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSecileniKopyala);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Programlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerYenileme;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSecileniKopyala;
        private System.Windows.Forms.ListBox lbProgramlar;
        private MaterialSkin.Controls.MaterialSwitch switchYenileme;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

