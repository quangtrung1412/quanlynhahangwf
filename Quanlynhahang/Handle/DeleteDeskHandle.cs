using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang.Handle
{
    public class DeleteDeskHandle
    {
        private ListTable listTable;
        private Desk d;

        public DeleteDeskHandle(ListTable listTable , Desk d)
        {
            this.listTable = listTable;
            this.d = d;
        }
        public void Handle(object sender , EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa món ăn :" + d.Name, "Xóa", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                bool bl = new DeskDAO().DeleteDesk(d.Id);
                listTable.LisTableRefresh();
            }
        }
    }
}
