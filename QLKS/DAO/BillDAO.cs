using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set => instance = value;
        }
        private BillDAO() { }
        public List<Bill> GetListBill(int id)
        {
            List<Bill> listBill = new List<Bill>();
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Bill where idPhieuDangKy="+ id);
            foreach (DataRow item in data.Rows)
            {
                Bill info = new Bill(item);
                listBill.Add(info);
            }

            return listBill;

        }
    }
}
