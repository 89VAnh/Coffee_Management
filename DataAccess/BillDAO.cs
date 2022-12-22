﻿using Anh_Coffee.BUS;
using Anh_Coffee.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anh_Coffee.DataAccess
{
    public class BillDAO
    {
        CoffeeManagementEntities db = new CoffeeManagementEntities();
        public void Add(Bill bill)
        {
            db.Bills.Add(bill);
            db.SaveChanges();
        }

        public Bill getBillByTableID(int tableID)
        {
            return db.Bills
                .SingleOrDefault(x => x.TableID == tableID && x.CheckOut == null);
        }

        public int getNewID()
        {
            if (db.Bills.Count() == 0) return 1;
            else return db.Bills.ToList().Last().ID + 1;
        }

        public void UpdateTable(int billID, int tableID)
        {
            Bill b = db.Bills.Find(billID);
            b.TableID = tableID;
            db.SaveChanges();
        }
    }
}