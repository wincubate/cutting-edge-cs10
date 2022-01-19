namespace Wincubate.CS10.Data;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll();
    void Add(Employee employee);
}
