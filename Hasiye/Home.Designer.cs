namespace Hasiye
{
    partial class Home
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNow = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.Location = new System.Drawing.Point(229, 116);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(293, 76);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haşiye";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNow
            // 
            this.labelNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNow.AutoSize = true;
            this.labelNow.Location = new System.Drawing.Point(689, 63);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(16, 13);
            this.labelNow.TabIndex = 1;
            this.labelNow.Text = "...";
            // 
            // labelMinute
            // 
            this.labelMinute.BackColor = System.Drawing.Color.Green;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMinute.Location = new System.Drawing.Point(379, 206);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(135, 32);
            this.labelMinute.TabIndex = 2;
            this.labelMinute.Text = "3 Dakika";
            this.labelMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecond
            // 
            this.labelSecond.BackColor = System.Drawing.Color.Green;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSecond.Location = new System.Drawing.Point(238, 206);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(135, 32);
            this.labelSecond.TabIndex = 2;
            this.labelSecond.Text = "20 Saniye";
            this.labelSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 340);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTime);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSecond;
    }
}

