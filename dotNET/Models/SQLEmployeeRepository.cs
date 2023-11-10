using System.Collections.Generic;
using WB_SQLServer.Models;

public class SQLEmployeeRepository : IEmployeeRepository
{
    private readonly Appdbcontaxcts context;

    public SQLEmployeeRepository(Appdbcontaxcts context)
    {
        this.context = context;
    }
    public Employeee Add(Employeee employee)
    {
        context.Employees.Add(employee);
        context.SaveChanges();
        return employee;
    }

    public Employeee Delete(int Id)
    {
        Employeee employee = context.Employees.Find(Id);
        if (employee != null)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
        return employee;
    }
    public IEnumerable<Employeee> GetAllEmployee()
    {
        return context.Employees;
    }

    public Employeee GetEmployee(int Id)
    {
        return context.Employees.Find(Id);
    }

    public Employeee Update(Employeee employeeChanges)
    {
        var employee = context.Employees.Attach(employeeChanges);
        employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
       // context.Employees.Update();
        context.Update(employee);
        context.SaveChanges();
        return employeeChanges;
    }
}
