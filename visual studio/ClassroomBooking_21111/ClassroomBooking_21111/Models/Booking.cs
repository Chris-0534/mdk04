using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomBooking_21111.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StaerTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
