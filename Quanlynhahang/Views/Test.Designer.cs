namespace Quanlynhahang.Views
{
    partial class Test
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
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Empty;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Empty;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(184, 98);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(((long)(0)));
            this.guna2DateTimePicker1.MinDate = new System.DateTime(((long)(0)));
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(75, 23);
            this.guna2DateTimePicker1.TabIndex = 0;
            this.guna2DateTimePicker1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2DateTimePicker1.Value = new System.DateTime(((long)(0)));
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.Empty;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.Empty;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(185, 184);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(((long)(0)));
            this.guna2DateTimePicker2.MinDate = new System.DateTime(((long)(0)));
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(179, 100);
            this.guna2DateTimePicker2.TabIndex = 1;
            this.guna2DateTimePicker2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2DateTimePicker2.Value = new System.DateTime(((long)(0)));
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
    }
}