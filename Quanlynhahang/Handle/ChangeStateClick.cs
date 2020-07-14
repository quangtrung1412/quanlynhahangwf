using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class ChangeStateClick
    {
        private ListTable listTable;
        private Desk d;

        public ChangeStateClick(ListTable listTable,Desk d)
        {
            this.listTable = listTable;
            this.d = d; 
        }
        public void Handle(object sender,EventArgs e)
        {

        }
    }
}
