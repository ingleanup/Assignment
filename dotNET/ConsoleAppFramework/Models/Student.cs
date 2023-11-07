using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Photo {  get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public int? GradeId { get; set; }
        public Grade? Grade { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2},{3}, {4}, {5},{6} ",StudentId, FirstName, LastName, DateOfBirth,  Height, Weight, GradeId,Photo,Address,Email);
        }
    }
}
