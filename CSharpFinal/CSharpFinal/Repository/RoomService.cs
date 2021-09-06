using CSharpFinal.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Repository
{
    class RoomService : IService<Room>
    {
        static List<Room> Rooms = new List<Room>()
        {
            new Room(1,"1",true),
            new Room(2,"2",false)
        };
        
        
      
        public bool IsAvailableMethod(Room room)
        {
            if (room.IsAvailable == true)
            {
                Console.WriteLine("This Room Is Available");
            }
            else
            {
                Console.WriteLine("This Room is Busy");
            }
            return false;

        }
        public bool AvailableRoom(Room room)
        {
            if (room.IsAvailable == true)
            {
                Console.WriteLine(Rooms);
            }
            return false;

        }




        public Room Create(Room model)
        {
            Rooms.Add(model);
            return model;
        }

        public bool Delete(int id)
        {
            Room room = Rooms.Find(r => r.Id == id);
            if (room == null)
            {
                return false;
            }
            Rooms.Remove(room);
            return true;
        }

        public Room Get(int id)
        {
            return Rooms.Find(c => c.Id == id);
        }

        public List<Room> GetAll()
        {
            return Rooms;
        }

        public Room Update(int id, Room model)
        {
            Room room = Rooms.Find(c => c.Id == id);
            room = model;
            return model;
        }

       
    }
}
