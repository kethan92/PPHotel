using HotelManagerReponsity_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HotelManagerReponsity_MVC.Models
{
    public class Room_TypeClient
    {
        private string Base_URL = "http://localhost:54788/api/";
        public IEnumerable<RoomOfStatusAndType> searchRoomOfRoom_Type(room_Type_DescriptionViewModel model)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("RoomOfStatusAndType?room_Type_Description=" + model.room_Type_Description).Result;
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