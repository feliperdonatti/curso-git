using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cap6ExercicoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered ?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listOfEmployees = new List<Employee>();

            for(int i = 0; i <=n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id:");
                int employeeId = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee emp = new Employee(employeeId, name, salary);

                listOfEmployees.Add(emp);
            }

            Console.Write("Enter the employee Id that will have salary increase:");
            int id = int.Parse(Console.ReadLine());
            Employee employee = listOfEmployees.Find(x => x.Id == id);

            if (employee != null)
            {
                Console.Write("Enter the percentage:");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percent);
            } else
            {
                Console.WriteLine("This id does not exist");
            }


        }
    }
}
