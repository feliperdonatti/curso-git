using System;
using System.Collections.Generic;
using System.Text;

namespace Cap6ExercicoListas
{
    class Employee
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double IncreaseSalary(double percentage)
        {
            return Salary += Salary * (percentage / 100.0);
        }
    }
}
