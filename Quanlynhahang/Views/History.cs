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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
            for(int i= 0; i < 10; i++)
            {
                Views.HisItem hi = new HisItem();
                this.flowLayoutPanel1.Controls.Add(hi);
                hi.Location = new Point(0, 0);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
