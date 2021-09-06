using CSharpFinal.Models;
using CSharpFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            BookingService bookingservice = new BookingService();
            AdminService adminservice = new AdminService();
            CustomerService customerservice = new CustomerService();
            RoomService roomservice = new RoomService();

            byte loginAttempt = 0;
            Admin loggedinadmin;

            Console.WriteLine("Welcome to Hilton Hotel!");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();


            do
            {
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                loggedinadmin = adminservice.GetAll().Find(a => a.Username == username && a.Password == password);
                if (loggedinadmin == null)
                {
                    loginAttempt++;
                }
                else
                {
                    break;
                }

            } while (loginAttempt < 3);

            if (loggedinadmin !=null)
            {
                Console.WriteLine("1. Log In");
                Console.WriteLine("2. Available Room Search");
                Console.WriteLine("3. Booking");
                Console.WriteLine("4. Booking Details");
                Console.WriteLine("5. Check-in");
                Console.WriteLine("6. Check-out");
                Console.WriteLine("7. Room Information");
                Console.WriteLine("8. Customer Information");
                Console.WriteLine("9. Booking Reports");
                Console.WriteLine("0. Exit");

                byte choice = Convert.ToByte(Console.ReadLine());


               

                do
                {

                    switch (choice)
                    {
                        case 2:
                            Console.WriteLine();
                            foreach (var item in roomservice.GetAll())
                            {

                                Console.WriteLine("Room Number : "+ roomservice.Get(item.Id).Number, roomservice.Get(item.Id).Id, roomservice.AvailableRoom(item));
                            }
                            break;

                            
                        case 4:
                            Console.WriteLine();
                            foreach (var item in bookingservice.GetAll()) 
                            {
                                Console.WriteLine("Customer : " +customerservice.Get(item.CustomerId).Name + roomservice.Get(item.RoomId).Number + "Start Date :", item.StartDate.ToString("dd.MM.yyyy") + " End date" + item.EndDate.ToString("dd.MM.yyyy"));
                            }
                           
                            break;
                           
                        case 3:
                            Console.WriteLine("Enter your Id");
                            string ID = Console.ReadLine();
                            Customer customer = customerservice.SearchById(ID);

                            if (customer!=null)
                            {
                                Console.WriteLine("Enter Room Number:");
                                string roomnumber1 = Console.ReadLine();
                                Room room = roomservice.GetAll().Find(r => r.Number == roomnumber1);

                                Console.WriteLine("Enter start date(dd.mm.yyyy):");
                                DateTime startDate = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Enter end date(dd.mm.yyyy):");
                                DateTime endDate = Convert.ToDateTime(Console.ReadLine());

                                bookingservice.CreateBooking(customer.Identification, room.Id, loggedinadmin.Id, endDate);

                            }
                            else
                            {
                                Console.WriteLine("Enter your Identification:");
                                string CID = Console.ReadLine();

                                Console.WriteLine("Enter your name:");
                                string Cname = Console.ReadLine();

                                Console.WriteLine("Enter your surname:");
                                string Csurname = Console.ReadLine();

                                Console.WriteLine("Enter your phone:");
                                string Cphone = Console.ReadLine();

                                Console.WriteLine("Enter your email:");
                                string Cemail = Console.ReadLine();


                                Customer customer1 = new Customer()
                                {
                                    Id = customerservice.GetAll().Count + 1,
                                    Identification = CID,
                                    Name = Cname,
                                    SurName = Csurname,
                                    Phone = Cphone,
                                    Email = Cemail,
                                    CheckInDate = DateTime.Now
                                };

                                customerservice.Create(customer1);

                                Console.WriteLine("Enter Room Number:");
                                string roomnumber = Console.ReadLine();
                                Room room = roomservice.GetAll().Find(r => r.Number == roomnumber);

                                Console.WriteLine("Enter start date(dd.mm.yyyy):");
                                DateTime startDate = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Enter end date(dd.mm.yyyy):");
                                DateTime endDate = Convert.ToDateTime(Console.ReadLine());

                                bookingservice.CreateBooking(customer1.Identification,room.Id,  loggedinadmin.Id, endDate);

 
                            }
                            break;
                        case 8:
                            Console.WriteLine();
                            foreach (var item in customerservice.GetAll())
                            {


                                Console.WriteLine("Customer : "+ customerservice.Get(item.Id).Name + item.SurName + item.Identification + item.Phone);
                            }
                            break;
                        case 7:
                            Console.WriteLine();
                            foreach (var item in roomservice.GetAll())
                            {

                                Console.WriteLine("Room Number : " + roomservice.Get(item.Id).Number,roomservice.IsAvailableMethod(item));
                            }break; 

                        default:
                            break;
    
                    }
                    Console.WriteLine("1. Log In");
                    Console.WriteLine("2. Available Room Search");
                    Console.WriteLine("3. Booking");
                    Console.WriteLine("4. Booking Details");
                    Console.WriteLine("5. Check-in");
                    Console.WriteLine("6. Check-out");
                    Console.WriteLine("7. Room Information");
                    Console.WriteLine("8. Customer Information");
                    Console.WriteLine("9. Booking Reports");
                    Console.WriteLine("0. Exit");

                     choice = Convert.ToByte(Console.ReadLine());


                } while (choice != 0);

             
            }


        }
    }
}
