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
        public Form1()
        {
            InitializeComponent();
            
            
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
            this.panelDisplay.Controls.Add(hm);
            hm.Location = new Point(0, 0);
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Views.Home hm = new Views.Home();
            hm.Hide();
            Views.ListTable lt = new Views.ListTable();
            lt.Show();
            lt.BringToFront();
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
    }
}
