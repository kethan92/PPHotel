using HotelManagerReponsity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagerReponsity.Reponsity
{
    public class Room_BookingRepository : Repository<Room_Bookings>, IRoom_BookingRepository
    {
        private RoomManagerEntities roomManagerEntities;
        //private UserRepository _userRepository;
        private DbSet<Room_Bookings> dbSet;
        public Room_BookingRepository()
        {
            roomManagerEntities = new RoomManagerEntities();
            //_userRepository = new UserRepository();
            dbSet = roomManagerEntities.Set<Room_Bookings>();
        }
        public IEnumerable<Room_Bookings> getRoom(DateTime date_from, DateTime date_to)
        {
           
            var query = dbSet.Where(
                x => (DateTime.Compare(x.date_booking_from.Value, date_from) <= 0
                && DateTime.Compare(x.date_booking_to.Value, date_from) >= 0) ||
                (DateTime.Compare(x.date_booking_from.Value, date_to) <= 0
                && DateTime.Compare(x.date_booking_to.Value, date_to) >= 0)).Select(x => x);
            return query;
        }

        
    }
}
