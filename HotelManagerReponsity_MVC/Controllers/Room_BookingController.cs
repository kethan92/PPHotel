using HotelManagerReponsity.Models;
using HotelManagerReponsity_MVC.Models;
using HotelManagerReponsity_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

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
            RoomsClient room_client = new RoomsClient();
            var query = room_booking.getRoom_Booking(model);                                 
            
            var query_room=room_client.getAllRoomOfStatusAndType();
            var roomsList = from x in query_room
                       where !(query.Any(y => y.Room_id == x.RoomNumber))
                       select x;
          //  XDocument updatedResultsDocument = room_client.UpdateApplicationPools();
            TempData["roomsList"] = roomsList;
            ViewBag.roomsList = roomsList;
            // return View();

            return RedirectToAction("Index", "Home");
        }
    }
}