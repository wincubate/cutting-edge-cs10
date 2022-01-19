using System;
using System.Collections.Generic;
using System.Linq;
using Wincubate.CS9.Data;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

foreach (var employee in all)
{
    Console.WriteLine(employee);
}
Console.WriteLine();

// TODO: Use pattern matching to find all StudentProgrammer mentored
//       by a SoftwareEngineer
//       - own first name is at least 4 letters
//       - mentor has not written between 100000 and 400000 lines of code
IEnumerable<StudentProgrammer> search = all
    .Where(e => e is StudentProgrammer
    {
        FirstName: { Length: >= 4 },
        MentoredBy: SoftwareEngineer
        {
            CodeLinesProduced: <= 100_000 or >= 400_000
        }
    })
    .Cast<StudentProgrammer>()
    ;

foreach (var employee in search)
{
    Console.WriteLine(employee);
}
Console.WriteLine();

// TODO: Create a list of these StudentProgrammers where they have
//       changed mentor to Bo Rammstein
Employee bora = new SoftwareArchitect("Bo", "Rammstein", Level.Senior, 87);
IEnumerable<StudentProgrammer> haveNewMentor = search
    .Select(sp => sp with { MentoredBy = bora });

foreach (var employee in haveNewMentor)
{
    Console.WriteLine(employee);
}
