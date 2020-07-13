namespace Quanlynhahang.Views
{
    partial class Table
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
            this.DeskName = new System.Windows.Forms.Label();
            this.DeskStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeskName
            // 
            this.DeskName.AutoSize = true;
            this.DeskName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DeskName.ForeColor = System.Drawing.Color.White;
            this.DeskName.Location = new System.Drawing.Point(31, 117);
            this.DeskName.Name = "DeskName";
            this.DeskName.Size = new System.Drawing.Size(75, 23);
            this.DeskName.TabIndex = 1;
            this.DeskName.Text = "Bàn số 1";
            // 
            // DeskStatus
            // 
            this.DeskStatus.AutoSize = true;
            this.DeskStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DeskStatus.ForeColor = System.Drawing.Color.Lime;
            this.DeskStatus.Location = new System.Drawing.Point(28, 144);
            this.DeskStatus.Name = "DeskStatus";
            this.DeskStatus.Size = new System.Drawing.Size(86, 23);
            this.DeskStatus.TabIndex = 1;
            this.DeskStatus.Text = "Bàn trống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quanlynhahang.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.DeskStatus);
            this.Controls.Add(this.DeskName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(135, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DeskName;
        private System.Windows.Forms.Label DeskStatus;
    }
}
