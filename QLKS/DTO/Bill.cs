using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Bill
    {
        public Bill(int id, int idPhieuDangKy, int idSevice, int count)
        {
            this.Id = id;
            this.IdPhieuDangKy = idPhieuDangKy;
            this.IdSevice = idSevice;
            this.Count = count;
        }
        public Bill(DataRow row)
        {
            this.Id =(int) row["Id"];
            this.IdPhieuDangKy = (int)row["idPhieuDangKy"];
            this.IdSevice = (int)row["idSevice"];
            this.Count = (int)row["cout"];
        }
        private int id;
        private int idPhieuDangKy;
        private int idSevice;
        private int count;

        public int Id { get => id; set => id = value; }
        public int IdPhieuDangKy { get => idPhieuDangKy; set => idPhieuDangKy = value; }
        public int IdSevice { get => idSevice; set => idSevice = value; }
        public int Count { get => count; set => count = value; }
    }
}
