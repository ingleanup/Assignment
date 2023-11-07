using ConsoleAppFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    internal class DbService
    {
        private static readonly SchoolContext db = new SchoolContext();
        public void Display()
        {
            foreach (var r in db.Student.ToList<Student>())
                Console.WriteLine(r);

        }

        public void Adddata(Student s)
        {
            // Student student = new Student() { FirstName = "Mona", LastName = "Thak", DateOfBirth = new DateTime(1999, 12, 12, 0, 0, 0), Photo = "images/s.png", Height = 5, Weight = 50, GradeId = 2 };
            db.Add<Student>(s);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            Student s = db.Student.SingleOrDefault<Student>((Stu) => Stu.StudentId == id);
            if (s != null)
            {
                db.Remove<Student>(s);
                db.SaveChanges();
            }
        }

        public List<Student> Customquery(string name)
        {
            FormattableString sql = $"SELECT * FROM Student WHERE FirstName ={name}";
            var studentlist = db.Student.FromSql(sql).ToList();
            return studentlist;


        }

        public void Liqdemo()
        {
            var r= db.Student.Join(db.Grade,(sg)=> sg.GradeId, (gi) => gi.Id, (r, g) => new { Name = r.FirstName, Gradename = g.GradeName });
            foreach (var result in r)
            {
                Console.Write(result.Gradename + " ");
                Console.WriteLine(result.Name);

            }
        }
    }
}
