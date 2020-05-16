using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class PhieuDangKyDAO
    {
        private static PhieuDangKyDAO instance;

        public static PhieuDangKyDAO Instance
        {
            get { if (instance == null) instance = new PhieuDangKyDAO(); return instance; }
            private set => instance = value;
        }
        private PhieuDangKyDAO() { }
        public int GetUncheckPhieuDKByRoomID(int id)
        {
            string sql = "select * from PhieuDangKy where idRoom=" + id + " and statu=0";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            if(data.Rows.Count>0)
            {
                PhieuDangKy pdk = new PhieuDangKy(data.Rows[0]);
                return pdk.Id;
            }
            return -1;
        }
    }
}
