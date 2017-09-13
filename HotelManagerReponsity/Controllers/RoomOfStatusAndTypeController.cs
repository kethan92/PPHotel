using HotelManagerReponsity.Models;
using HotelManagerReponsity.Reponsity;
using HotelManagerReponsity.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace HotelManagerReponsity.Controllers
{
    public class RoomOfStatusAndTypeController : ApiController
    {
        private IRoomRepository _roomRepository;
        private IRoom_StatusRepository _roomStatusRepository;
        private IRoom_TypeRepository _roomTypeRepository;

        public RoomOfStatusAndTypeController()
        {
            _roomRepository = new RoomRepository();
            _roomStatusRepository = new Room_StatusRepository();
            _roomTypeRepository = new Room_TypeRepository();
        }
        //Get api/RoomOfStatusAndType
        [HttpGet]
        public HttpResponseMessage GetRoomOfStatusAndType()
        {
            var query = from a in _roomRepository.GetAll().Include("_roomStatusRepository.GetAll()")
                        .Include("_roomTypeRepository.GetAll()")
                        select new RoomOfStatusAndType
                        {
                            RoomNumber = a.RoomNumber,
                            nameRoom = a.nameRoom,
                            RoomStatus_id = a.RoomStatus_id,
                            RoomType_id = a.Room_Type.room_Type_Code,
                            status = a.Room_Status.status,
                            room_Type_Description=a.Room_Type.room_Type_Description,
                            prince = a.Room_Type.prince
                        };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, query);
            return response;
        }
        //Get api/RoomOfStatusAndType?room_Type_Description
        [HttpGet]
        public HttpResponseMessage GetRoomOfStatusAndType(string room_Type_Description)
        {
            var query = from a in _roomRepository.GetAll().Include("_roomStatusRepository.GetAll()")
                        .Include("_roomTypeRepository.GetAll()").Where(x=>x.Room_Type.room_Type_Description.Equals(room_Type_Description))
                        select new RoomOfStatusAndType
                        {
                            RoomNumber = a.RoomNumber,
                            nameRoom = a.nameRoom,
                            RoomStatus_id = a.RoomStatus_id,
                            RoomType_id = a.Room_Type.room_Type_Code,
                            status = a.Room_Status.status,
                            room_Type_Description = a.Room_Type.room_Type_Description,
                            prince = a.Room_Type.prince
                        };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, query);
            return response;
        }
        [HttpGet]
        [ResponseType(typeof(RoomOfStatusAndType))]
        public IQueryable<RoomOfStatusAndType> GetRoomOfStatusAndType(int RoomNumber)
        {
            var query = from a in _roomRepository.GetAll().Include("_roomStatusRepository.GetAll()")
                        .Include("_roomTypeRepository.GetAll()").Where(x => x.RoomNumber==(RoomNumber))
                        select new RoomOfStatusAndType
                        {
                            RoomNumber = a.RoomNumber,
                            nameRoom = a.nameRoom,
                            RoomStatus_id = a.RoomStatus_id,
                            RoomType_id = a.Room_Type.room_Type_Code,
                            status = a.Room_Status.status,
                            room_Type_Description = a.Room_Type.room_Type_Description,
                            prince = a.Room_Type.prince
                        };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, query);
            return query;
           
        }
       
    }
}
