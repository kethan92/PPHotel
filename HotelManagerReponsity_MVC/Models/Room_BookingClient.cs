using HotelManagerReponsity_MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HotelManagerReponsity_MVC.Models
{
    public class Room_BookingClient
    {
        private string Base_URL = "http://localhost:54788/api/";
        [HttpGet]
        public IEnumerable<Room_Booking> getRoom_Booking(RoomBookingOfBookingViewModel model)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("Room_Booking?date_booking_from=" +
                    model.Date_From+ "&date_booking_to=" + model.Date_To).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<Room_Booking>>().Result;
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