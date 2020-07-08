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
    public partial class ListFoods : UserControl
    {
        private Form1 form;

        public ListFoods()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Views.Foods f = new Views.Foods();
                this.flowLayoutPanel1.Controls.Add(f);
                
            }
        }
        public ListFoods(Form1 form)
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Views.Foods f = new Views.Foods();
                this.flowLayoutPanel1.Controls.Add(f);

            }
            this.form = form;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListFoods_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(form.Location.X + 150, form.Location.Y + 26);
            overlay.Show();
            FormFood formFood = new FormFood();
            formFood.ShowDialog();
            overlay.Dispose();
        }
    }
}
