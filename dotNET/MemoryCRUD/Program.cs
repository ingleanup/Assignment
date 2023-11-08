using System.ComponentModel.DataAnnotations;

namespace MemoryCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            MockWorkerRepository db = new MockWorkerRepository();
            Worker a = db.Add(new Worker {Id=4, Name = "Harry Potter", Email = "Harry@verbos.com", Department = Dept.HR });
            Worker b = db.Add(new Worker { Id = 5, Name = "Rolex", Email = "Rolex@Sir.com", Department = Dept.HR });
            Display(db);
        }

        static void Display(MockWorkerRepository db)
        {
            foreach (Worker a in db.GetAllWorkers())
                Console.WriteLine(": {0} {1} {2} {3}", a.Id, a.Name, a.Email, a.Department);
        }
    }
}