using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class Form1 : Form
    {
        public Account Account { get; set; }
        public Form1()
        {
            InitializeComponent();
            
            
        }
        public Form1(Account acc)
        {
            InitializeComponent();
            Account = acc;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Views.Home hm = new Views.Home();
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(hm);
            hm.Location = new Point(0, 0);
            this.Refresh();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Views.ListTable lt = new Views.ListTable();
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(lt);
            lt.Location = new Point(0, 0);
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Views.Home hm = new Views.Home();
            this.panelDisplay.Controls.Add(hm);
            hm.Location = new Point(0, 0);
            this.Refresh();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Views.ListFoods lf = new Views.ListFoods(this);
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(lf);
            lf.Location = new Point(0, 0);
            this.Refresh();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Views.History hs = new Views.History();
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(hs);
            hs.Location = new Point(0, 0);
            this.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Views.Setting st = new Views.Setting();
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(st);
            st.Location = new Point(0, 0);
            this.Refresh();
        }
    }
}
