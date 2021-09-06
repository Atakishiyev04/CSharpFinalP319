using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Models
{
    class Booking
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private DateTime now;
        private string v5;
        private bool v6;

        public int Id { get; set; }
        public int AdminId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsAvailable { get; set; }

        public Booking(int id,int adminid,int customerid,int roomid,DateTime startdate,DateTime enddate,bool isavailable)
        {
            Id = id;
            AdminId = adminid;
            CustomerId = customerid;
            RoomId = roomid;
            StartDate = startdate;
            EndDate = enddate;
            IsAvailable = isavailable;

        }
        public Booking()
        {

        }

        public Booking(int v1, int v2, int v3, int v4, DateTime now, string v5, bool v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.now = now;
            this.v5 = v5;
            this.v6 = v6;
        }
    }
}
