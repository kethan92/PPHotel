using HotelManagerReponsity_MVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagerReponsity_MVC.ViewModel
{
    public class RoomBookingOfBookingViewModel
    {
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }
        
    }
}