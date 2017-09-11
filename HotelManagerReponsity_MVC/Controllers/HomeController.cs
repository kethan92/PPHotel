using HotelManagerReponsity_MVC.Models;
using HotelManagerReponsity_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagerReponsity_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            RoomsClient roomsclient = new RoomsClient();
            var model = roomsclient.getAllRoomOfStatusAndType();
            ViewBag.roomsList = model;
            return View();
        }
        [HttpPost]
        public ActionResult Index(room_Type_DescriptionViewModel listroom)
        {
            Room_TypeClient roomsType = new Room_TypeClient();
            var model = roomsType.searchRoomOfRoom_Type(listroom);
            ViewBag.roomsList = model;
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult DetailRoom(int id)
        {
            RoomsClient roomsclient = new RoomsClient();
            var model =new Models.RoomOfStatusAndType();
            IEnumerable<Models.RoomOfStatusAndType> query = roomsclient.getRoomOfStatusAndType(id);
            //model.nameRoom = query.nameRoom;
            //model.RoomNumber = query.RoomNumber;
            //model.RoomStatus_id = query.RoomStatus_id;
            //model.RoomType_id = query.RoomType_id;
            //model.room_Type_Description = query.room_Type_Description;
            //model.status = query.status;
            //model.room_Standard_Rate = query.room_Standard_Rate;
            //ViewBag.getRooms = query;

            return View(query);
        }
    }
}