using HotelManagerReponsity_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HotelManagerReponsity_MVC.Models
{
    public class RoomsClient
    {
        private string Base_URL = "http://localhost:54788/api/";
        [HttpGet]
        public IEnumerable<RoomOfStatusAndType> getAllRoomOfStatusAndType()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("RoomOfStatusAndType").Result;
                if (response.IsSuccessStatusCode)
                {
                     return response.Content.ReadAsAsync<IEnumerable<RoomOfStatusAndType>>().Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        // get room/id
        [HttpGet]
        public IEnumerable<RoomOfStatusAndType> getRoomOfStatusAndType(int RomNumber)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("RoomOfStatusAndType?RoomNumber="+ RomNumber).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<RoomOfStatusAndType>>().Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        [HttpPut]
        public bool UpdateStatusRoom(Rooms rooms)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("Rooms/" + rooms.RoomNumber, rooms).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        // get room/id
        [HttpGet]
        public IEnumerable<RoomOfStatusAndType> getRoomOfStatusAndType(IEnumerable<Room_Booking> room_booking)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("RoomOfStatusAndType?room_booking=" + room_booking).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<RoomOfStatusAndType>>().Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}