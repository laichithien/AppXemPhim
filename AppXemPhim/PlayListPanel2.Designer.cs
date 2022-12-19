namespace AppXemPhim
{
    partial class PlayListPanel2
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
            this.label1 = new System.Windows.Forms.Label();
            this.XemNgayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Playlist";
            // 
            // XemNgayButton
            // 
            this.XemNgayButton.BackColor = System.Drawing.Color.IndianRed;
            this.XemNgayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XemNgayButton.ForeColor = System.Drawing.Color.White;
            this.XemNgayButton.Location = new System.Drawing.Point(368, 11);
            this.XemNgayButton.Name = "XemNgayButton";
            this.XemNgayButton.Size = new System.Drawing.Size(75, 39);
            this.XemNgayButton.TabIndex = 3;
            this.XemNgayButton.Text = "Xem";
            this.XemNgayButton.UseVisualStyleBackColor = false;
            this.XemNgayButton.Click += new System.EventHandler(this.XemNgayButton_Click);
            // 
            // PlayListPanel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.XemNgayButton);
            this.Controls.Add(this.label1);
            this.Name = "PlayListPanel2";
            this.Size = new System.Drawing.Size(446, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XemNgayButton;
    }
}
