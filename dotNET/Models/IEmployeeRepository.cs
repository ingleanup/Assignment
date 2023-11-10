namespace WB_SQLServer.Models
{
    public interface IEmployeeRepository
    {
        Employeee GetEmployee(int Id);
        IEnumerable<Employeee> GetAllEmployee();
        Employeee Add(Employeee employee);
        Employeee Update(Employeee employeeChanges);
        Employeee Delete(int Id);
    }

}
