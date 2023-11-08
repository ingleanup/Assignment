using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCRUD
{
    public interface IWorkerRepository
    {
      //  Worker GetWorker(int Id);
        IEnumerable<Worker> GetAllWorkers();
        //Worker Add(Worker worker);
        //Worker Update(Worker workerchanges);
        //Worker Delete(int Id);
    }
}
