﻿using System;
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
        public Table(string id , string name , int status)
        {
            InitializeComponent();
        }
        public void TableClick(EventHandler e)
        {
            this.Click += e;
            this.pictureBox1.Click += e;
        }
    }
}
