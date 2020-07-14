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
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }
        public Table(string id , string name , byte status)
        {
            InitializeComponent();
            DeskName.Text = name;

        }
        public void TableClick(EventHandler e)
        {
            this.Click += e;
            this.pictureBox1.Click += e;
        }

        private void Option_Click(object sender, EventArgs e)
        {
            MctOption.Show(this, 0, 20);
        }

      
        public void ChangeStateClick(EventHandler e)
        {
            this.ChangeState.Click += e;
        }
    }
}
