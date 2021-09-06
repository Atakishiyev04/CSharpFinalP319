using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Models
{
    class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }

        public Admin(int id,string name,string surname,string phone,string email,string username,string password,DateTime createdtime)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Username = username;
            Password = password;
            CreatedDate = createdtime;
        }
    }
}
