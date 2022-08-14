using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9
{
    internal class Employee
    {
        private int _age;
        private int _exp;
        //public Employee(string name, int age, int exp, bool checkOfEducation)
        //{
        //    Age = age;
        //    Exp = exp;
        //    Name = name;
        //    CheckOfEducation = checkOfEducation;
        //}

        public string Name { get; set; }
        public int  Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }
        public int  Exp
        { 
            get
            {
                return _exp;
            }
            set
            {
                if (value < 0)
                {
                    _exp = 0;
                }
                else
                {
                    _exp = value;
                }
            }
        }
        public bool  CheckOfEducation { get; set; }
        public static int GetSalary(Employee employee)
        { 
           if (employee.CheckOfEducation)
            {
                return (employee.Exp + 1) * 1250;
            }
           else
            {
                return (employee.Exp + 1) * 1000;
            }
        }

        public static void PrintSalary(List<Employee> employeers)
        {
            foreach (Employee employee in employeers)
            {
                if (employee.CheckOfEducation)
                {
                    Console.WriteLine($"ЗП С ВЫШКОЙ:{employee.Name} - {(employee.Exp + 1) * 1250}");
                }
                else
                {
                    Console.WriteLine($"ЗП Без вышки:{employee.Name} - {(employee.Exp + 1) * 1000}");
                }
            }
        }







        public static void PrintListOfSalary(List<Employee> employers, Program.GetSalaryMethod delegateSalary)
        {
            foreach (var employee in employers)
            {
                int salary = delegateSalary(employee);
                Console.WriteLine($"{employee.Name} - {salary}");
            }

        }

        public static void PrintSalary(List<Employee> employees, Program.GetSalaryMethod delegateSalary)
        {
            foreach (var employee in employees)
            {
                int salary = delegateSalary(employee);
                Console.WriteLine($"{employee.Name} - {salary}");
            }
        }

    }
}
