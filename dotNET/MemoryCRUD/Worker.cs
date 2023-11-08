using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCRUD
{
    public class Worker
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept Department { get; set; }
    }
    public enum Dept { HR, ADV, MKT }
}
