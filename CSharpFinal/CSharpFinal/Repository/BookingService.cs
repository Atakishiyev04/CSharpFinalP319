using CSharpFinal.Models;
using CSharpFinal.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Repository
{
    class BookingService 
    {

        private List<Booking> Bookings = new List<Booking>(); 

        public bool CreateBooking(int Rid,int Cid,int Aid,DateTime enddate)
        {
            Booking booking = new Booking()
            {
                Id = Bookings.Count + 1,
                RoomId = Rid,
                CustomerId = Cid,
                AdminId = Aid,
                StartDate = DateTime.Now,
                EndDate = enddate,
                IsAvailable = false

            };
            Bookings.Add(booking);

            return true;

        }
        

        

        internal void CreateBooking(string identification, int id1, int id2, DateTime endDate)
        {
            throw new NotImplementedException();
        }

       

        internal object Get(object customerId)
        {
            throw new NotImplementedException();
        }
        public List<Booking> GetAll()
        {
            new Booking(1, 1, 1, 1, DateTime.Now,DateTime.Now.ToString("dd.MM.yyyy"), true);
            new Booking(2, 2, 2, 3, DateTime.Now,DateTime.Now.ToString("dd.MM.yyyy"), true);
            return Bookings;
        }
    }
}
