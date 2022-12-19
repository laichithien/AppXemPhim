namespace AppXemPhim
{
    partial class MoviePanel2
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
            this.TenPhimTiengViet = new System.Windows.Forms.Label();
            this.TenPhimTiengAnh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TenPhimTiengViet
            // 
            this.TenPhimTiengViet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimTiengViet.ForeColor = System.Drawing.Color.Gold;
            this.TenPhimTiengViet.Location = new System.Drawing.Point(68, 9);
            this.TenPhimTiengViet.Name = "TenPhimTiengViet";
            this.TenPhimTiengViet.Size = new System.Drawing.Size(215, 15);
            this.TenPhimTiengViet.TabIndex = 1;
            this.TenPhimTiengViet.Text = "Tên phim tiếng Việt";
            // 
            // TenPhimTiengAnh
            // 
            this.TenPhimTiengAnh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimTiengAnh.ForeColor = System.Drawing.Color.AliceBlue;
            this.TenPhimTiengAnh.Location = new System.Drawing.Point(68, 33);
            this.TenPhimTiengAnh.Name = "TenPhimTiengAnh";
            this.TenPhimTiengAnh.Size = new System.Drawing.Size(124, 13);
            this.TenPhimTiengAnh.TabIndex = 2;
            this.TenPhimTiengAnh.Text = "Tên phim tiếng Anh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(198, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoviePanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TenPhimTiengAnh);
            this.Controls.Add(this.TenPhimTiengViet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MoviePanel2";
            this.Size = new System.Drawing.Size(290, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label TenPhimTiengViet;
        public System.Windows.Forms.Label TenPhimTiengAnh;
        public System.Windows.Forms.Button button1;
    }
}
