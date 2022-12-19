namespace AppXemPhim.FormList
{
    partial class _04_PlayList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_04_PlayList));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.catalog = new System.Windows.Forms.FlowLayoutPanel();
            this.goiYPhanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(667, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 74);
            this.panel5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(88, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phim gợi ý";
            // 
            // catalog
            // 
            this.catalog.AutoScroll = true;
            this.catalog.BackColor = System.Drawing.Color.DimGray;
            this.catalog.Location = new System.Drawing.Point(1, 80);
            this.catalog.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(651, 418);
            this.catalog.TabIndex = 12;
            // 
            // goiYPhanel
            // 
            this.goiYPhanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goiYPhanel.AutoScroll = true;
            this.goiYPhanel.BackColor = System.Drawing.Color.DimGray;
            this.goiYPhanel.Location = new System.Drawing.Point(667, 80);
            this.goiYPhanel.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.goiYPhanel.Name = "goiYPhanel";
            this.goiYPhanel.Size = new System.Drawing.Size(324, 418);
            this.goiYPhanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(67, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phim đã xem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-71, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 39);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // _04_PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(993, 498);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.goiYPhanel);
            this.Controls.Add(this.label1);
            this.Name = "_04_PlayList";
            this.Text = "_04_PlayList";
            this.ClientSizeChanged += new System.EventHandler(this._04_PlayList_ClientSizeChanged);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel catalog;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel goiYPhanel;
        private System.Windows.Forms.Label label1;
    }
}