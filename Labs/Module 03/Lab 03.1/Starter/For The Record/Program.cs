using System;
using System.Collections.Generic;
using Wincubate.CS9.Data;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

foreach (var employee in all)
{
    Console.WriteLine(employee);
}

// TODO: Use pattern matching to find all StudentProgrammer mentored
//       by a SoftwareEngineer
//       - own first name is at least 4 letters
//       - mentor has not written between 100000 and 400000 lines of code

//IEnumerable<StudentProgrammer> search = ...;

// TODO: Create a list of these StudentProgrammers where they have
//       changed mentor to Bo Rammstein

// IEnumerable<StudentProgrammer> haveNewMentor = ...;
