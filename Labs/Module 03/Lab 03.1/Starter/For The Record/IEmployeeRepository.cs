using System.Collections.Generic;

namespace Wincubate.CS9.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
    }
}
