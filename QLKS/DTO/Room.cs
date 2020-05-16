using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Room
    {
        public Room(int id, string name, int idCategoryRoom, string status)
        {
            this.Id = id;
            this.Name = name;
            this.IdCategoryRoom = idCategoryRoom;
            this.Status = status;
        }
        public Room(DataRow row)
        {
            this.Id =(int) row["id"];
            this.Name = row["name"].ToString();
            this.IdCategoryRoom = (int)row["idCatagoryRoom"];
            this.Status = row["status"].ToString();
        }
        private int id;
        private string name;
        private int idCategoryRoom;
        private string status;

       
        public string Name { get => name; set => name = value; }
        public int IdCategoryRoom { get => idCategoryRoom; set => idCategoryRoom = value; }
        public string Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }

        public static implicit operator int(Room v)
        {
            throw new NotImplementedException();
        }
    }
}
