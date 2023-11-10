using Microsoft.EntityFrameworkCore;

namespace WB_SQLServer.Models
{
    public class Appdbcontaxcts : DbContext
    {
        public Appdbcontaxcts(DbContextOptions<Appdbcontaxcts> options)
             : base(options)
        {
        }

        public DbSet<Employeee> Employees { get; set; }
    }

}
