using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            decimal salary = decimal.Parse(tokens[1]);
            string position = tokens[2];
            string department = tokens[3];

            if (tokens.Length == 4)
            {
                employees[i] = new Employee(name, salary, position, department);
            }
            else if (tokens.Length == 5)
            {
                int age;
                bool isAge = int.TryParse(tokens[4], out age);
                if (isAge)
                {
                    employees[i] = new Employee(name, salary, position, department, age);
                }
                else
                {
                    string email = tokens[4];
                    employees[i] = new Employee(name, salary, position, department, email);
                }
            }
            else
            {
                string email = tokens[4];
                int age = int.Parse(tokens[5]);
                employees[i] = new Employee(name, salary, position, department, email, age);
            }
        }   

        var dict = new Dictionary<string, decimal>();
        foreach (Employee employee in employees)
        {
            if (dict.ContainsKey(employee.department))
            {
                dict[employee.department] += employee.salary;
            }
            else
            {
                dict[employee.department] = employee.salary;
            }
        }

        decimal highestAverageSalary = decimal.MinValue;
        string highestPaidDepartment = "";

        foreach (string department in dict.Keys)
        {
            decimal averageSalary = dict[department] / employees.Count(e => e.department == department);
            if (averageSalary > highestAverageSalary)
            {
                highestAverageSalary = averageSalary;
                highestPaidDepartment = department;
            }
        }

        Console.WriteLine($"Highest Average Salary: {highestPaidDepartment}");
        foreach (Employee employee in employees.Where(e => e.department == highestPaidDepartment).OrderByDescending(e => e.salary))
        {
            Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
        }


    }
}

