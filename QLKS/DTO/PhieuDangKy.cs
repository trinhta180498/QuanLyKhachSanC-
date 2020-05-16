using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class PhieuDangKy
    {
        public PhieuDangKy(int id, string name, int tuoi, string cMND, string sdt, DateTime? dateCheckIn, DateTime? dateCheckOut,int idRoom,int statu)
        {
            this.Id = id;
            this.Name = name;
            this.Tuoi = tuoi;
            this.CMND = cMND;
            this.Sdt = sdt;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.IdRoom = idRoom;
            this.Statu = statu;
        }
        public PhieuDangKy(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["name"].ToString();
            this.Tuoi = (int)row["tuoi"];
            this.CMND = row["CNND"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];

            var dateCheckOutTest= row["dateCheckIn"];
            if (dateCheckOutTest.ToString() != " ") ;
                this.DateCheckOut = (DateTime?)dateCheckOutTest;
            this.IdRoom = (int)row["idRoom"];
            this.Statu = (int)row["statu"];
        }
        private int id;
        private string name;
        private int tuoi;
        private string cMND;
        private string sdt;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int idRoom;
        private int statu;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        
        public int IdRoom { get => idRoom; set => idRoom = value; }
        public int Statu { get => statu; set => statu = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
    }
}
