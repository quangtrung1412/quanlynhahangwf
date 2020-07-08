using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang.Views
{
    public partial class FormFood : Form
    {
        private Food food;

        public FormFood()
        {
            InitializeComponent();
        }
        public FormFood(Food food)
        {
            this.food = food;
            this.txtFoodName.Text = food.Name;
            this.numPrice.Value = food.Price;
          
        }
        private void FormFood_Load(object sender, EventArgs e)
        {

        }
    }
}
