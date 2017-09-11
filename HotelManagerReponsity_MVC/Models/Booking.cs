using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagerReponsity_MVC.Models
{
    public class Booking
    {
        public int Booking_ID { get; set; }
        public Nullable<decimal> money { get; set; }
        public Nullable<int> Customer_id { get; set; }
    }
}