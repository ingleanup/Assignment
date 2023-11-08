using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCRUD
{
    public class MockWorkerRepository : IWorkerRepository
    {
        private static List<Worker> _workerList;

        public MockWorkerRepository()
        {
            _workerList = new List<Worker>()
            {
                new Worker() { Id = 1, Name = "John Wick", Department = Dept.HR, Email = "John@illkillthemall.com" },
                new Worker() { Id = 2, Name = "Bruce Wayne", Department = Dept.ADV, Email = "Bruce@iboughtthebank.com" },
                new Worker() { Id = 3, Name = "Jon Snow", Department = Dept.MKT, Email = "Jon@winteriscoming.com" },
            };
        }

        public Worker Add(Worker worker)
        {
            worker.Id = _workerList.Max(e => e.Id) + 1;
            _workerList.Add(worker);
            return worker;
        }

       /* public Worker Delete(int Id)
        {
            throw new NotImplementedException();
        }*/

       

       public IEnumerable<Worker> GetAllWorkers()
       {
            return _workerList;
       }

      

        /* public Worker GetWorker(int Id)
         {
             throw new NotImplementedException();
         }

         public Worker Update(Worker workerchanges)
         {
             throw new NotImplementedException();
         }*/

    }
}
