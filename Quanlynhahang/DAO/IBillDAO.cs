﻿using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO
{
    interface IBillDAO
    {
        List<Bill> GetAllBill(DateTime from ,DateTime to);
        List<BillDetail> GetAllBillDetail();

    }
}
