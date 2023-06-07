using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Employee
    {
        private string _fio;
        private int _department;
        private double _salary;
        public int _id;
        static public int _count = 1;

        public Employee(string fio, int department, double salary)
        {
            _department = department;
            _salary = salary;
            _fio = fio;
            _id = _count++;
        }
        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }
        public int Department
        {
            get => _department;
            set => _department = value;
        }
        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public double FindMinSalaryInDepartment(List<Employee> employees, int departmentId)
        {
            var departmentEmployees = employees.Where(e => e.Department == departmentId);
            if (departmentEmployees.Any())
            {
                return departmentEmployees.Min(e => e.Salary);
            }
            return 0;
        }
    }
}