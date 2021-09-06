using CSharpFinal.Models;
using CSharpFinal.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal.Repository
{
    class CustomerService : IService<Customer>
    {
        private List<Customer> Customers = new List<Customer>();
        public CustomerService()
        {
            Customers.Add(new Customer() { Id = 1, Identification = " AZE123456", Name = " Elmar", SurName = " Atakishiyev",  Phone = " 123456", CheckInDate = DateTime.Now,Email = " elmar@gmail.com", });
            Customers.Add(new Customer() { Id = 2, Identification = " AZE321654", Name = " Ali", SurName = " Abbasov",  Phone = " 321456", CheckInDate = DateTime.Now,Email = " ali@gmail.com", });

        }
        public Customer Create(Customer model)
        {
            Customers.Add(model);
            return model;
        }
       

        public bool Delete(int id)
        {
            Customer customer = Customers.Find(c => c.Id == id);
            if (customer == null)
            {
                return false;
            }
            Customers.Remove(customer);
            return true;
        }

        public Customer Get(int id)
        {
            return Customers.Find(c => c.Id == id);
        }

        public Customer SearchById(string identification)
        {
            return Customers.Find(c => c.Identification == identification);
        }
        public List<Customer> GetAll()
        {
            return Customers;
        }

        public Customer Update(int id, Customer model)
        {
            Customer customer = Customers.Find(c => c.Id == id);
            customer = model;
            return model;
        }
    }
}
