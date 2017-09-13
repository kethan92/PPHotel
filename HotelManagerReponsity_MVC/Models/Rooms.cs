using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagerReponsity_MVC.Models
{
    public class Rooms
    {
        public int RoomNumber { get; set; }
        public string nameRoom { get; set; }
        public Nullable<int> RoomStatus_id { get; set; }
        public int RoomType_id { get; set; }

        public Rooms(int RoomNumber,string nameRoom,Nullable<int> RoomStatus_id,int RoomType_id)
        {
            this.RoomNumber = RoomNumber;
            this.nameRoom = nameRoom;
            this.RoomStatus_id = RoomStatus_id;
            this.RoomType_id = RoomType_id;
        }
    }
}