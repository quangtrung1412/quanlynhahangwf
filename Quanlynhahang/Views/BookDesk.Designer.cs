namespace Quanlynhahang.Views
{
    partial class BookDesk
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NrQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnAddBillDetail = new Guna.UI2.WinForms.Guna2Button();
            this.CbFood = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbTypeFood = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgBillDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnPay = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBillDetail)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.guna2ControlBox1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 32);
            this.panel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(310, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gọi món";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.NrQuantity);
            this.panel3.Controls.Add(this.BtnAddBillDetail);
            this.panel3.Controls.Add(this.CbFood);
            this.panel3.Controls.Add(this.CbTypeFood);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 172);
            this.panel3.TabIndex = 4;
            // 
            // NrQuantity
            // 
            this.NrQuantity.Location = new System.Drawing.Point(138, 138);
            this.NrQuantity.Name = "NrQuantity";
            this.NrQuantity.Size = new System.Drawing.Size(120, 22);
            this.NrQuantity.TabIndex = 6;
            // 
            // BtnAddBillDetail
            // 
            this.BtnAddBillDetail.CheckedState.Parent = this.BtnAddBillDetail;
            this.BtnAddBillDetail.CustomImages.Parent = this.BtnAddBillDetail;
            this.BtnAddBillDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddBillDetail.ForeColor = System.Drawing.Color.White;
            this.BtnAddBillDetail.HoverState.Parent = this.BtnAddBillDetail;
            this.BtnAddBillDetail.Location = new System.Drawing.Point(391, 120);
            this.BtnAddBillDetail.Name = "BtnAddBillDetail";
            this.BtnAddBillDetail.ShadowDecoration.Parent = this.BtnAddBillDetail;
            this.BtnAddBillDetail.Size = new System.Drawing.Size(136, 40);
            this.BtnAddBillDetail.TabIndex = 5;
            this.BtnAddBillDetail.Text = "Thêm";
            this.BtnAddBillDetail.Click += new System.EventHandler(this.BtnAddBillDetail_Click);
            // 
            // CbFood
            // 
            this.CbFood.BackColor = System.Drawing.Color.Transparent;
            this.CbFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbFood.FocusedState.Parent = this.CbFood;
            this.CbFood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbFood.HoverState.Parent = this.CbFood;
            this.CbFood.ItemHeight = 30;
            this.CbFood.ItemsAppearance.Parent = this.CbFood;
            this.CbFood.Location = new System.Drawing.Point(314, 61);
            this.CbFood.Name = "CbFood";
            this.CbFood.ShadowDecoration.Parent = this.CbFood;
            this.CbFood.Size = new System.Drawing.Size(213, 36);
            this.CbFood.TabIndex = 4;
            // 
            // CbTypeFood
            // 
            this.CbTypeFood.BackColor = System.Drawing.Color.Transparent;
            this.CbTypeFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbTypeFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTypeFood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTypeFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbTypeFood.FocusedState.Parent = this.CbTypeFood;
            this.CbTypeFood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbTypeFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbTypeFood.HoverState.Parent = this.CbTypeFood;
            this.CbTypeFood.ItemHeight = 30;
            this.CbTypeFood.ItemsAppearance.Parent = this.CbTypeFood;
            this.CbTypeFood.Location = new System.Drawing.Point(314, 10);
            this.CbTypeFood.Name = "CbTypeFood";
            this.CbTypeFood.ShadowDecoration.Parent = this.CbTypeFood;
            this.CbTypeFood.Size = new System.Drawing.Size(213, 36);
            this.CbTypeFood.TabIndex = 4;
            this.CbTypeFood.SelectedIndexChanged += new System.EventHandler(this.CbTypeFood_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Empty;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Empty;
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(0, 0);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(134, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Món ăn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(134, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục :";
            // 
            // dgBillDetail
            // 
            this.dgBillDetail.AllowUserToDeleteRows = false;
            this.dgBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgBillDetail.Location = new System.Drawing.Point(0, 30);
            this.dgBillDetail.Name = "dgBillDetail";
            this.dgBillDetail.RowHeadersWidth = 51;
            this.dgBillDetail.RowTemplate.Height = 24;
            this.dgBillDetail.Size = new System.Drawing.Size(700, 313);
            this.dgBillDetail.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên món ăn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(700, 32);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(310, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hóa đơn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtTotal);
            this.panel4.Controls.Add(this.dgBillDetail);
            this.panel4.Controls.Add(this.BtnPay);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(0, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 512);
            this.panel4.TabIndex = 5;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(471, 387);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(186, 31);
            this.TxtTotal.TabIndex = 2;
            this.TxtTotal.Text = "0";
            // 
            // BtnPay
            // 
            this.BtnPay.CheckedState.Parent = this.BtnPay;
            this.BtnPay.CustomImages.Parent = this.BtnPay;
            this.BtnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPay.ForeColor = System.Drawing.Color.White;
            this.BtnPay.HoverState.Parent = this.BtnPay;
            this.BtnPay.Location = new System.Drawing.Point(521, 449);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.ShadowDecoration.Parent = this.BtnPay;
            this.BtnPay.Size = new System.Drawing.Size(136, 40);
            this.BtnPay.TabIndex = 5;
            this.BtnPay.Text = "Thanh toán";
            this.BtnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(327, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền :";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(655, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // BookDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 728);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookDesk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookDesk";
            this.Load += new System.EventHandler(this.BookDesk_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBillDetail)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown NrQuantity;
        private Guna.UI2.WinForms.Guna2Button BtnAddBillDetail;
        private Guna.UI2.WinForms.Guna2ComboBox CbFood;
        private Guna.UI2.WinForms.Guna2ComboBox CbTypeFood;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgBillDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtTotal;
        private Guna.UI2.WinForms.Guna2Button BtnPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}