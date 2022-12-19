namespace AppXemPhim.FormList
{
    partial class NewPlayList
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
            this.XemNgayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // XemNgayButton
            // 
            this.XemNgayButton.BackColor = System.Drawing.Color.IndianRed;
            this.XemNgayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XemNgayButton.ForeColor = System.Drawing.Color.White;
            this.XemNgayButton.Location = new System.Drawing.Point(215, 278);
            this.XemNgayButton.Name = "XemNgayButton";
            this.XemNgayButton.Size = new System.Drawing.Size(75, 39);
            this.XemNgayButton.TabIndex = 3;
            this.XemNgayButton.Text = "Lưu";
            this.XemNgayButton.UseVisualStyleBackColor = false;
            this.XemNgayButton.Click += new System.EventHandler(this.XemNgayButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập tên playlist mới";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(28, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(449, 35);
            this.textBox2.TabIndex = 5;
            // 
            // NewPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(503, 340);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.XemNgayButton);
            this.Controls.Add(this.label1);
            this.Name = "NewPlayList";
            this.Text = "NewPlayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XemNgayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}