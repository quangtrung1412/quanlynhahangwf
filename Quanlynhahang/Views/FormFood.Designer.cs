﻿namespace Quanlynhahang.Views
{
    partial class FormFood
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
            this.cbFoodType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnChangeFoodImage = new Guna.UI2.WinForms.Guna2Button();
            this.pbFoodImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2Button();
            this.txtUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFoodName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFoodType
            // 
            this.cbFoodType.BackColor = System.Drawing.Color.Transparent;
            this.cbFoodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFoodType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFoodType.FocusedState.Parent = this.cbFoodType;
            this.cbFoodType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFoodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFoodType.HoverState.Parent = this.cbFoodType;
            this.cbFoodType.ItemHeight = 38;
            this.cbFoodType.ItemsAppearance.Parent = this.cbFoodType;
            this.cbFoodType.Location = new System.Drawing.Point(226, 105);
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.ShadowDecoration.Parent = this.cbFoodType;
            this.cbFoodType.Size = new System.Drawing.Size(267, 44);
            this.cbFoodType.TabIndex = 20;
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.Transparent;
            this.numPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numPrice.DisabledState.Parent = this.numPrice;
            this.numPrice.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numPrice.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numPrice.FocusedState.Parent = this.numPrice;
            this.numPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numPrice.Location = new System.Drawing.Point(226, 313);
            this.numPrice.Name = "numPrice";
            this.numPrice.ShadowDecoration.Parent = this.numPrice;
            this.numPrice.Size = new System.Drawing.Size(266, 44);
            this.numPrice.TabIndex = 19;
            // 
            // btnChangeFoodImage
            // 
            this.btnChangeFoodImage.CheckedState.Parent = this.btnChangeFoodImage;
            this.btnChangeFoodImage.CustomImages.Parent = this.btnChangeFoodImage;
            this.btnChangeFoodImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeFoodImage.ForeColor = System.Drawing.Color.White;
            this.btnChangeFoodImage.HoverState.Parent = this.btnChangeFoodImage;
            this.btnChangeFoodImage.Location = new System.Drawing.Point(343, 407);
            this.btnChangeFoodImage.Name = "btnChangeFoodImage";
            this.btnChangeFoodImage.ShadowDecoration.Parent = this.btnChangeFoodImage;
            this.btnChangeFoodImage.Size = new System.Drawing.Size(104, 36);
            this.btnChangeFoodImage.TabIndex = 18;
            this.btnChangeFoodImage.Text = "Thay đổi";
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.Image = global::Quanlynhahang.Properties.Resources.foodpicture;
            this.pbFoodImage.Location = new System.Drawing.Point(226, 372);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFoodImage.ShadowDecoration.Parent = this.pbFoodImage;
            this.pbFoodImage.Size = new System.Drawing.Size(100, 100);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodImage.TabIndex = 17;
            this.pbFoodImage.TabStop = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.CheckedState.Parent = this.btnAddFood;
            this.btnAddFood.CustomImages.Parent = this.btnAddFood;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.HoverState.Parent = this.btnAddFood;
            this.btnAddFood.Location = new System.Drawing.Point(313, 488);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.ShadowDecoration.Parent = this.btnAddFood;
            this.btnAddFood.Size = new System.Drawing.Size(180, 45);
            this.btnAddFood.TabIndex = 16;
            this.btnAddFood.Text = "Cập nhật";
            // 
            // txtUnit
            // 
            this.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnit.DefaultText = "";
            this.txtUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnit.DisabledState.Parent = this.txtUnit;
            this.txtUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnit.FocusedState.Parent = this.txtUnit;
            this.txtUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnit.HoverState.Parent = this.txtUnit;
            this.txtUnit.Location = new System.Drawing.Point(226, 242);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.PlaceholderText = "";
            this.txtUnit.SelectedText = "";
            this.txtUnit.ShadowDecoration.Parent = this.txtUnit;
            this.txtUnit.Size = new System.Drawing.Size(267, 44);
            this.txtUnit.TabIndex = 13;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodName.DefaultText = "";
            this.txtFoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodName.DisabledState.Parent = this.txtFoodName;
            this.txtFoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodName.FocusedState.Parent = this.txtFoodName;
            this.txtFoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodName.HoverState.Parent = this.txtFoodName;
            this.txtFoodName.Location = new System.Drawing.Point(226, 174);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.PlaceholderText = "";
            this.txtFoodName.SelectedText = "";
            this.txtFoodName.ShadowDecoration.Parent = this.txtFoodName;
            this.txtFoodName.Size = new System.Drawing.Size(267, 44);
            this.txtFoodName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hình ảnh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn vị :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên món ăn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại món ăn :";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(585, 45);
            this.lbTitle.TabIndex = 21;
            this.lbTitle.Text = "Thêm Thức Ăn";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(527, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 22;
            // 
            // FormFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 570);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cbFoodType);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.btnChangeFoodImage);
            this.Controls.Add(this.pbFoodImage);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFood";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFood";
            this.Load += new System.EventHandler(this.FormFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbFoodType;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPrice;
        private Guna.UI2.WinForms.Guna2Button btnChangeFoodImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFoodImage;
        private Guna.UI2.WinForms.Guna2Button btnAddFood;
        private Guna.UI2.WinForms.Guna2TextBox txtUnit;
        private Guna.UI2.WinForms.Guna2TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}