using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlynhahang.Models;
using Quanlynhahang.DAO.Implements;
using System.Diagnostics;
using System.IO;

namespace Quanlynhahang.Views
{
    public partial class Foods : UserControl
    {
        public Foods()
        {
            InitializeComponent();
        }
        public Foods(string id, string name, string unit, int price, string image)
        {
            InitializeComponent();
            string imagefolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Images\";
            LFoodId.Text = id;
            LFoodName.Text = name;
            LFoodUnit.Text = unit;
            LFoodPrice.Text = price + "";
            if(image!=null)
            {
                PFoodPicture.Image = Image.FromFile(imagefolder + image);
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Foods_Load(object sender, EventArgs e)
        {
            
        }
        public void BtnDeleteFoodClick(EventHandler e)
        {
            this.DeleteFood.Click += e;
        }
        public void BtnEditFoodClick(EventHandler e)
        {
            this.BtnEditFood.Click += e;
            
        }

        private void BtnEditFood_Click(object sender, EventArgs e)
        {
           
        }
    }
}
