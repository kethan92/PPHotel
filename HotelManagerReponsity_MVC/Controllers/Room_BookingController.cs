using HotelManagerReponsity.Models;
using HotelManagerReponsity_MVC.Models;
using HotelManagerReponsity_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagerReponsity_MVC.Controllers
{
    public class Room_BookingController : Controller
    {
        RoomManagerEntities db = new RoomManagerEntities();
        // GET: Room_Booking
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchRoom(RoomBookingOfBookingViewModel model)
        {
            Room_BookingClient room_booking = new Room_BookingClient();
            var query = room_booking.getRoom_Booking(model);                                 
            ViewBag.list = query;                      
            return View();
           // return RedirectToAction("Index", "Home");
        }
    }
}