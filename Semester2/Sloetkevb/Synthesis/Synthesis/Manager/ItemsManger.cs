using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using SynthesisAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SynthesisAssignment.Manager
{
    public class ItemsManger
    {
        IItemsDAL itemsDAL;

        public ItemsManger(IItemsDAL items)
        {
            this.itemsDAL = items;
        }

        public ItemsManger()
        {
        }

        public void AddItems(Items item)
        {
            itemsDAL.AddItem(item);
        }

        public void Deleteitem(Items item)
        {
            itemsDAL.DeleteItem(item);
        }

        public List<Items> ViewAllItmes()
        {
            List<Items> items = itemsDAL.ViewAllItems();
            return items;
        }

        public DataTable ViewItems()
        {
            itemsDAL.ViewAllItems();
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Name"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Quantity"), typeof(int)));
            dt.Columns.Add(new DataColumn(("PricePer2Hours"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Deposit"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Remark"), typeof(string)));
            dt.Columns.Add(new DataColumn(("LocationID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("City"), typeof(string)));
            foreach (Items i in itemsDAL.ViewAllItems())
            {
                var row = dt.NewRow();
                row["ID"] = i.ID;
                row["Name"] = i.Name;
                row["Quantity"] = i.Quantity;
                row["PricePer2Hours"] = i.CostPer2Hous;
                row["Deposit"] = i.Deposit;
                row["Remark"] = i.Remark;
                row["LocationID"] = i.Location.ID;
                row["City"] = i.Location.City;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public Items ShowInfo(int id)
        {
            foreach (Items item in itemsDAL.ViewAllItems())
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
