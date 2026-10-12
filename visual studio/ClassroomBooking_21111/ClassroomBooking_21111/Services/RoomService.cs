using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomBooking_21111.Models;

namespace ClassroomBooking_21111.Services
{
    public class RoomService
    {
        public readonly List<Room> rooms = new List<Room>
        {
            new Room {Id = 1, Number = "301", ComputerCount = 15, IsAvilable = true},
            new Room {Id = 2, Number = "302", ComputerCount = 10, IsAvilable = true},
            new Room {Id = 3, Number = "305", ComputerCount = 12, IsAvilable = false}
        };
        public List<Room> GetRooms() 
        { 
            return rooms; 
        }
    }
}
