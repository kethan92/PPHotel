﻿using HotelManagerReponsity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerReponsity.Reponsity
{
    public interface IRoom_BookingRepository:IRepository<Room_Bookings>
    {
        IEnumerable<Room_Bookings> getRoom(DateTime date_from, DateTime date_to);
    }
}
