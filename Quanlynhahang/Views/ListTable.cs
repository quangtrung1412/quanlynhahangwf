using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang.Views
{
    public partial class ListTable : UserControl
    {
        public ListTable()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Views.Table tb = new Views.Table();
                this.flowLayoutPanel1.Controls.Add(tb);
                tb.TableClick(handle);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void handle(object sender, EventArgs e)
        {
            
        }
    }
}
