/*Q.Create a class Employee having private instance member
• id - id is readonly property and generated by your application
• name- write getter setter
• salary- write getter setter
• net salary
• Write method who’s job is to deduct TDS 10% and return tax amount and set netsalary instance 
member after deducting tax.
• Declare TDS as static variable.
• Your application should create only 3 object if you try to create 4th object it should throw exception.
• Give appropriate validation like salary can not be 0 or negative, maximum
• Salary allowed is 50000 if you try to set more then 50000 it should give some error message.
• When you run your application it should print name of company*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee
    {
        static int id;
        public string Name
        { get; set; }
        public double Salary
        { get; set; }
        double netsalary;
        static double tds = 0.1;

        static Employee()
            {
            Console.WriteLine("New Company");
            }
        public Employee(string name, double salary)
        {
            id = ++id;
            if (id <= 3)
            {
                Name = name;
                if (salary <= 50000)
                {
                    Salary = salary;
                }
                else
                {
                    throw new Exception("Salary out of Range");
                }
            }
            else 
            {
                throw new Exception("No More Entries Possible");
            }
        }

        public double CalSalary()
        {
            netsalary = Salary -Salary*tds; 
            return netsalary;
        }
        
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Rohit", 48000);
            Console.WriteLine(e1.Name + "\t" + e1.CalSalary());

            Employee e2 = new Employee("Sanket", 50000);
            Console.WriteLine(e2.Name + "\t" + e2.CalSalary());

            Employee e3 = new Employee("Virat", 28000);
            Console.WriteLine(e3.Name + "\t" + e3.CalSalary());

            Employee e4 = new Employee("Anil", 38000);
            Console.WriteLine(e4.Name + "\t" + e4.CalSalary());
        }
    }
}
