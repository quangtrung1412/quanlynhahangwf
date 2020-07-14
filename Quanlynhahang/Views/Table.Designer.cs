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
            this.components = new System.ComponentModel.Container();
            this.DeskName = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MctOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeState = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MctOption.SuspendLayout();
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
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.State.ForeColor = System.Drawing.Color.Lime;
            this.State.Location = new System.Drawing.Point(28, 144);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(86, 23);
            this.State.TabIndex = 1;
            this.State.Text = "Bàn trống";
            // 
            // Option
            // 
            this.Option.BackColor = System.Drawing.Color.White;
            this.Option.Image = global::Quanlynhahang.Properties.Resources.icons8_menu_vertical_601;
            this.Option.Location = new System.Drawing.Point(115, 0);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(20, 25);
            this.Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Option.TabIndex = 2;
            this.Option.TabStop = false;
            this.Option.Click += new System.EventHandler(this.Option_Click);
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
            // MctOption
            // 
            this.MctOption.AutoSize = false;
            this.MctOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MctOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeState});
            this.MctOption.Name = "contextMenuStrip1";
            this.MctOption.Size = new System.Drawing.Size(105, 30);
            // 
            // ChangeState
            // 
            this.ChangeState.AutoSize = false;
            this.ChangeState.Name = "ChangeState";
            this.ChangeState.Size = new System.Drawing.Size(135, 24);
            this.ChangeState.Text = "bàn bận";
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.Option);
            this.Controls.Add(this.State);
            this.Controls.Add(this.DeskName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(135, 180);
            ((System.ComponentModel.ISupportInitialize)(this.Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MctOption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DeskName;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.PictureBox Option;
        private System.Windows.Forms.ContextMenuStrip MctOption;
        private System.Windows.Forms.ToolStripMenuItem ChangeState;
    }
}
