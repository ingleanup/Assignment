using ConsoleAppFramework.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace ConsoleAppFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DbService services=new DbService();
            services.Display();
            // Student student = new Student() { FirstName = "Mona", LastName = "Thak", DateOfBirth = new DateTime(1999, 12, 12, 0, 0, 0),/* Photo = "images/s.png",*/ Height = 5, Weight = 50, GradeId = 2 };
            //  services.Adddata(student);
            //services.Delete(14);
            //services.Liqdemo();
           /* Console.WriteLine("_______________");
            var i = services.Customquery("Raj");
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }*/


        }
    }
}