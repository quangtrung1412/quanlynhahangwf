using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlynhahang.Models;

namespace Quanlynhahang.Views
{
    public partial class Table : UserControl
    {
        public Desk Desk { get; set; }

        public Table()
        {
            InitializeComponent();
        }
        public Table(Desk d)
        {
            InitializeComponent();
            DeskName.Text = d.Name;
            Desk = d;
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

        
        
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Table))
            {
                return false;
            }
            Table other = (Table)obj;
            if (Desk.Id != other.Desk.Id)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            int hash = 0;
            hash += (Desk.Id != null ? Desk.Id.GetHashCode() : 0);
            return hash;
        }
    }
}
