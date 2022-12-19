namespace AppXemPhim
{
    partial class MoviePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vieNameLabel = new System.Windows.Forms.Label();
            this.orgNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vieNameLabel
            // 
            this.vieNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vieNameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.vieNameLabel.Location = new System.Drawing.Point(3, 303);
            this.vieNameLabel.Name = "vieNameLabel";
            this.vieNameLabel.Size = new System.Drawing.Size(238, 25);
            this.vieNameLabel.TabIndex = 1;
            this.vieNameLabel.Text = "Tựa đề ";
            // 
            // orgNameLabel
            // 
            this.orgNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgNameLabel.ForeColor = System.Drawing.Color.Ivory;
            this.orgNameLabel.Location = new System.Drawing.Point(3, 328);
            this.orgNameLabel.Name = "orgNameLabel";
            this.orgNameLabel.Size = new System.Drawing.Size(238, 20);
            this.orgNameLabel.TabIndex = 2;
            this.orgNameLabel.Text = "Original name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppXemPhim.Resource1.testthumbnail;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // xemButton
            // 
            this.xemButton.BackColor = System.Drawing.Color.IndianRed;
            this.xemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xemButton.ForeColor = System.Drawing.Color.White;
            this.xemButton.Location = new System.Drawing.Point(133, 351);
            this.xemButton.Name = "xemButton";
            this.xemButton.Size = new System.Drawing.Size(108, 39);
            this.xemButton.TabIndex = 3;
            this.xemButton.Text = "Xem ngay";
            this.xemButton.UseVisualStyleBackColor = false;
            this.xemButton.Click += new System.EventHandler(this.xemButton_Click);
            // 
            // MoviePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.xemButton);
            this.Controls.Add(this.orgNameLabel);
            this.Controls.Add(this.vieNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MoviePanel";
            this.Size = new System.Drawing.Size(244, 395);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label vieNameLabel;
        public System.Windows.Forms.Label orgNameLabel;
        public System.Windows.Forms.Button xemButton;
    }
}
