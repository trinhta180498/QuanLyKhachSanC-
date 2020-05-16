using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class CategoryRoom
    {
        public CategoryRoom(int id,string name, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public CategoryRoom(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private int id;
        private string name;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
    }
}
