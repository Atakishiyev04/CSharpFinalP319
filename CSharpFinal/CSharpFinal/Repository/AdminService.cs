using CSharpFinal.Models;
using CSharpFinal.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Repository
{
     class AdminService : IService<Admin>
    {
        static List<Admin> Admins = new List<Admin>()
        {
            new Admin(1,"Emin","Qurbanov","emin@gmail.com","123456","emin@gmail.com","123",DateTime.Now),
            new Admin(2,"Nicat","Agayev","nicat@gmail.com","123456","nicat@gmail.com","345",DateTime.Now)
        };
        

        

       

        public Admin Create(Admin model)
        {
            Admins.Add(model);
            return model;
        }

        public bool Delete(int id)
        {
            Admin admin = Admins.Find(u => u.Id == id);
            if (admin == null)
            {
                return false;
            }

            Admins.Remove(admin);
            return true;
        }

        public Admin Get(int id)
        {
            return Admins.Find(u => u.Id == id);
        }

        public List<Admin> GetAll()
        {
            return Admins;
        }

        public Admin Update(int id, Admin model)
        {
            Admin admin = Admins.Find(u => u.Id == id);
            admin = model;
            return model;
        }
    }
}
