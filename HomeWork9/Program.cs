using System;
using System.Collections.Generic;

namespace HomeWork9
{
    internal class Program
    {
        public delegate int GetSalaryMethod(Employee employee);
        public static int GetSalary(Employee employee)
        {
            return (employee.Exp + 1) * 1000;
        }
        static void Main(string[] args)
        {
            
            //Employee emp = new Employee("d", 2, 2, true);
            List<Employee> employeeList = new List<Employee>
            {
                new Employee() { Name = "Dasha", Age = 18, Exp = 2, CheckOfEducation = false },
                new Employee() { Name = "Dima", Age = 23, Exp = 3, CheckOfEducation = true },
                new Employee() { Name = "Volodya", Age = 32, Exp = 7, CheckOfEducation = false },
                new Employee() { Name = "Nikita", Age = 22, Exp = 4, CheckOfEducation = true }
            };
            Console.WriteLine("Просто статический метод ПринтСэлэри:");
            
            Employee.PrintSalary(employeeList);

            Console.WriteLine("------------------------------------------------------");
            
            Console.WriteLine("Статический метод,с делегатом:");
            //GetSalaryMethod salaryDelegate = new GetSalaryMethod(Employee.GetSalary); 2й способ
            GetSalaryMethod salaryDeleagate = GetSalary;
            Employee.PrintSalary(employeeList, salaryDeleagate);
            Console.WriteLine("------------------Test-------------------");
            Employee.PrintListOfSalary(employeeList, salaryDeleagate);

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Метод без реализации лямбды:");
            salaryDeleagate = GetSalary;
            Employee.PrintSalary(employeeList, salaryDeleagate);

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Использование лямбды уже со своим условием (стрелочки рулят)");
            Employee.PrintSalary(employeeList, (employee) => (employee.Exp + 1) * 3000);
           


            
        }
    }
}
