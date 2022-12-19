namespace AppXemPhim.FormList
{
    partial class PlayScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayScreen));
            this.TenPhimTiengAnh = new System.Windows.Forms.Label();
            this.TenPhimTiengViet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goiYPhanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // TenPhimTiengAnh
            // 
            this.TenPhimTiengAnh.AutoSize = true;
            this.TenPhimTiengAnh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimTiengAnh.ForeColor = System.Drawing.Color.AliceBlue;
            this.TenPhimTiengAnh.Location = new System.Drawing.Point(2, 38);
            this.TenPhimTiengAnh.Name = "TenPhimTiengAnh";
            this.TenPhimTiengAnh.Size = new System.Drawing.Size(138, 20);
            this.TenPhimTiengAnh.TabIndex = 1;
            this.TenPhimTiengAnh.Text = "Tên phim tiếng Anh";
            // 
            // TenPhimTiengViet
            // 
            this.TenPhimTiengViet.AutoSize = true;
            this.TenPhimTiengViet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimTiengViet.ForeColor = System.Drawing.Color.Gold;
            this.TenPhimTiengViet.Location = new System.Drawing.Point(3, 10);
            this.TenPhimTiengViet.Name = "TenPhimTiengViet";
            this.TenPhimTiengViet.Size = new System.Drawing.Size(198, 28);
            this.TenPhimTiengViet.TabIndex = 2;
            this.TenPhimTiengViet.Text = "Tên phim tiếng Việt";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.TenPhimTiengViet);
            this.panel1.Controls.Add(this.TenPhimTiengAnh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 71);
            this.panel1.TabIndex = 3;
            // 
            // goiYPhanel
            // 
            this.goiYPhanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goiYPhanel.AutoScroll = true;
            this.goiYPhanel.BackColor = System.Drawing.Color.DimGray;
            this.goiYPhanel.Location = new System.Drawing.Point(657, 89);
            this.goiYPhanel.Name = "goiYPhanel";
            this.goiYPhanel.Size = new System.Drawing.Size(324, 397);
            this.goiYPhanel.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(657, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 71);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(88, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phim gợi ý";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 397);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(633, 391);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // PlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(993, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.goiYPhanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "PlayScreen";
            this.Text = "PlayScreen";
            this.ClientSizeChanged += new System.EventHandler(this.PlayScreen_ClientSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TenPhimTiengAnh;
        private System.Windows.Forms.Label TenPhimTiengViet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel goiYPhanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}