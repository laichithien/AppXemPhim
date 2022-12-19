namespace AppXemPhim.FormList
{
    partial class _01_Home
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
            this.catalog = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // catalog
            // 
            this.catalog.BackColor = System.Drawing.Color.Silver;
            this.catalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalog.Location = new System.Drawing.Point(0, 0);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(1009, 537);
            this.catalog.TabIndex = 0;
            // 
            // _01_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 537);
            this.Controls.Add(this.catalog);
            this.Name = "_01_Home";
            this.Text = "_01_Home";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel catalog;
    }
}