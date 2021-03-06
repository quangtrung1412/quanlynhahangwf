﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang.Views
{
    public partial class Setting : UserControl
    {
        public Form1 form1;
        public Setting()
        {
            InitializeComponent();
        }
        public Setting(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
            txtName.Text = form1.Account.Name;
            txtEmail.Text = form1.Account.Email;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Views.AddTable at = new Views.AddTable();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(at);
            at.Location = new Point(0, 0);
            this.Refresh();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Views.AddFood af = new Views.AddFood();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(af);
            af.Location = new Point(0, 0);
            this.Refresh();
        }
    }
}
