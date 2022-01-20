using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.CS7.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IList<Employee> _employees;

        public EmployeeRepository()
        {
            Employee bora = new SoftwareArchitect
            {
                FirstName = "Bo",
                LastName = "Rammstein",
                Level = SoftwareArchitectLevel.Senior,
                VisioDrawingsProduced = 87
            };
            Employee jlm = new SoftwareEngineer
            {
                FirstName = "Jørgen",
                LastName = "Leth Mortensen",
                Level = SoftwareEngineerLevel.Senior,
                CodeLinesProduced = 299992
            };
            Employee jth = new SoftwareEngineer
            {
                FirstName = "Jørgen",
                LastName = "Thestrup",
                Level = SoftwareEngineerLevel.Senior,
                CodeLinesProduced = 411119
            };
            Employee uh = new SoftwareArchitect
            {
                FirstName = "Ulrik",
                LastName = "Holm",
                Level = SoftwareArchitectLevel.Senior,
                VisioDrawingsProduced = 42
            };
            Employee lula = new SoftwareEngineer
            {
                FirstName = "Luna",
                LastName = "Ladefoged",
                Level = SoftwareEngineerLevel.Chief,
                CodeLinesProduced = 90800
            };
            Employee mtt = new ProjectManager
            {
                FirstName = "Miles",
                LastName = "Ton Taka",
                Level = ProjectManagerLevel.Senior,
                Team = "Banzai Raccoons"
            };
            Employee nasp = new ProjectManager
            {
                FirstName = "Naja",
                LastName = "Split",
                Level = ProjectManagerLevel.Chief,
                Team = "Punching Pumpkins"
            };
            Employee pne = new StudentProgrammer
            {
                FirstName = "Peter",
                LastName = "Nefa",
                MentoredBy = jth
            };
            Employee apaa = new StudentProgrammer
            {
                FirstName = "Anders",
                LastName = "Paaske",
                MentoredBy = bora
            };
            Employee nby = new StudentProgrammer
            {
                FirstName = "Nora",
                LastName = "Byskov",
                MentoredBy = lula
            };
            Employee jegu = new SoftwareEngineer
            {
                FirstName = "Jesper",
                LastName = "Gulmann Henriksen",
                Level = SoftwareEngineerLevel.Lead,
                CodeLinesProduced = 176
            };

            _employees = new List<Employee>
            {
                bora, jlm, jth, uh, lula, mtt, nasp, pne, apaa, nby, jegu
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees.ToList();
        }

        //public void Add( Employee employee )
        //{
        //    if (employee == null)
        //    {
        //        throw new ArgumentNullException("employee");
        //    }

        //    _employees.Add(employee);
        //}

        public void Add( Employee employee ) =>
            _employees.Add(employee ?? throw new ArgumentNullException(nameof(employee)));
    }
}
