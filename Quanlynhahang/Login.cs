using Microsoft.VisualBasic.ApplicationServices;
using Quanlynhahang.Handle;
using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views.Register re = new Views.Register();
            panel1.Controls.Clear();
            this.panel1.Controls.Add(re);
            re.Location = new Point(0, 0);
            this.Refresh();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim().ToLower();
            string password = txtPass.Text.Trim();
            new LoginHandle(this).Handle(username, password);
        }
        public void ShowErrorLogin()
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }
        public void ShowErrorLoginInfo()
        {
            MessageBox.Show("Thông tin đăng nhập không đúng");
        }
        public void InitMainForm(Account acc) 
        {
            this.Hide();
            Form1 form = new Form1(acc);
            form.Show();
        }
    }
}
