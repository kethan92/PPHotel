using HotelManagerReponsity.Models;
using HotelManagerReponsity.Reponsity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelManagerReponsity.Controllers
{
    public class Room_BookingController : ApiController
    {
        private RoomManagerEntities db = new RoomManagerEntities();

        private IRoom_BookingRepository _roomBookingRepository;
      //  private IRoom_StatusRepository _roomStatusRepository;
       // private IRoom_TypeRepository _roomTypeRepository;

        public Room_BookingController()
        {
            _roomBookingRepository = new Room_BookingRepository();
          //  _roomStatusRepository = new Room_StatusRepository();
           // _roomTypeRepository = new Room_TypeRepository();
        }
        // GET: api/Rooms
        public HttpResponseMessage GetRoom_Booking()
        {
            var query = _roomBookingRepository.GetAll();

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, query);
            return response;
        }
        // GET: api/Rooms?date_from=??&&date_to=??
        public HttpResponseMessage GetRoom_Booking(DateTime date_from,DateTime date_to)
        {
            var query = _roomBookingRepository.getRoom(date_from,date_to);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, query);
            return response;
        }
    }
}
