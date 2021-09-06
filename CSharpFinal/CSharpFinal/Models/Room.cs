using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal
{
    class Room
    {
        
        public int Id { get; set; }

        public string Number { get; set; }
        public  bool IsAvailable { get; set; }

        public Room(int id,string number,bool isavailable)
        {
            Id = id;
            Number = number;
            IsAvailable = isavailable;

        }

        
    }
}
