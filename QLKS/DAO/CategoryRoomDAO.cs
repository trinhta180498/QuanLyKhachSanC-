using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class CategoryRoomDAO
    {
        private static CategoryRoomDAO instance;

        public static CategoryRoomDAO Instance
        {
            get { if (instance == null) instance = new CategoryRoomDAO(); return instance; }
            private set => instance = value;
        }
        private CategoryRoomDAO() { }
    }
}
