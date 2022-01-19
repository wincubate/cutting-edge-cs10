using System;
using System.Collections.Generic;
using Wincubate.CS8.Data;

namespace Wincubate.CS8.Slide14
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository repository = new EmployeeRepository();
            IEnumerable<Employee> all = repository.GetAll();

            foreach (Employee employee in all)
            {
                string? description = Evaluate(employee);
                Console.WriteLine($"{employee.FullName} - {description}");
            }
        }

        static string? Evaluate(Employee employee) =>
            employee switch
            {
                SoftwareEngineer { Level: Level.Lead, FirstName: "Jesper" } => $"You suck..:!",
                SoftwareEngineer { Level: Level.Lead } => $"{employee.FullName} does great work",
                SoftwareArchitect { Level: Level.Chief } => $"You da boss, {employee.FullName}",
                _ => $"Well done making the company thrive... :-)"
            };

        static void HailTheKing(Employee employee)
        {
            if (employee is SoftwareEngineer { Level: Level.Chief, FullName: "Uncle Bob" })
            {
                Console.WriteLine("All hail to the king");
            }
        }
    }
}
