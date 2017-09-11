using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagerReponsity_MVC.Models
{
    public class Room_Booking
    {
        public Nullable<System.DateTime> date_booking_from { get; set; }
        public Nullable<System.DateTime> date_booking_to { get; set; }
        public Nullable<int> room_cout { get; set; }
        public int idBooking { get; set; }
        public int Room_id { get; set; }
    }
}