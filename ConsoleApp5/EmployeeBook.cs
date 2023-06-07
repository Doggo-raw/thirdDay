using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class EmployeeBook
    {
        private List<Employee> employees = new()
        {
            new Employee("Жуков Антон Павлович", 1, 12000),
            new Employee("Миклашевский Данила Сергеевич ", 1, 15000),
            new Employee("Кузнецова Ульяна Максимовна", 2, 17000),
            new Employee("Комаров Иван Романович", 2, 1200),
            new Employee("Титова Александра Матвеевна", 3, 4200),
            new Employee("Антонов Никита Платонович", 3, 5000),
            new Employee("Ламтюгина Олеся Ивановна", 4, 8000),
            new Employee("Косых Иван Андреевич", 4, 80000),
            new Employee("Орехов Владислав Владиславович", 5, 17500),
            new Employee("Голубев Богдан Даниилович", 5, 100)
        };
        List<Employee> deletedemployee = new List<Employee>()
        {

        };

        public void EmployeeBookMain()
        {
            void EmployeeInfo()
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                        $"{emp.Department} получает зарплату в размере" +
                        $" {emp.Salary}");
                }
            }
            void EmployeeSalary()
            {
                double sum = 0;
                foreach (Employee emp in employees)
                {
                    sum += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплаты в месяц: {sum}");
            }
            void MinSalary()
            {
                Console.WriteLine($"Человек с самой минимальной зарплатой {employees.Min(e => e.Salary + "рублей: " + e.Fio)} ");
            }
            void MaxSalary()
            {
                Console.WriteLine($"Человек с самой максимальной зарплатой {employees.Max(e => e.Salary + "рублей: " + e.Fio)} ");
            }
            void AvgSalary()
            {
                Console.WriteLine($"Среднее значение зарплат: {employees.Average(e => e.Salary)}");
            }
            void EmlployeeFio()
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ФИО сотрудника: {emp._id} {emp.Fio}");
                }
            }
            void SalaryPrecent()
            {
                Console.WriteLine("Введите процент на который увеличится зарплата работников: ");
                double percent = double.Parse(Console.ReadLine());
                double salary;
                foreach (var emp in employees)
                {
                    salary = emp.Salary + (emp.Salary / percent);
                    Console.WriteLine($"Теперь зарплата сотрудника {emp.Fio} составляет: {salary} рублей");
                }
            }
            void DepartmentEmployee()
            {
                Console.WriteLine("Введите номер отдела:");
                double departmentID = double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == departmentID)
                    {
                        Console.WriteLine($"Сотрудник {emp.Fio} из {emp.Department} отдела получает: {emp.Salary}");
                    }
                }
            }
            void DepartamentSalaryMin()
            {
                Console.WriteLine("Введите номер отдела");
                double department = double.Parse(Console.ReadLine());
                var employeesInDepartment = employees.Where(e => e.Department == department);
                if (employeesInDepartment.Any())
                {
                    var employeeWithMinSalary = employeesInDepartment.OrderBy(e => e.Salary).First();
                    Console.WriteLine($"Человек с самой минимальной зарплатой в отделе {department}: {employeeWithMinSalary.Fio} - {employeeWithMinSalary.Salary} рублей");
                }
                else
                {
                    Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
                }
            }
            void DepartamentSalaryMax()
            {
                Console.WriteLine("Введите номер отдела"); double department = double.Parse(Console.ReadLine());
                var employeesInDepartment = employees.Where(e => e.Department == department); if (employeesInDepartment.Any())
                {
                    var employeeWithMaxSalary = employeesInDepartment.OrderBy(e => e.Salary).Last();
                    Console.WriteLine($"Человек с самой максимальной зарплатой в отделе {department}: {employeeWithMaxSalary.Fio} - {employeeWithMaxSalary.Salary} рублей");
                }
                else
                {
                    Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
                }
            }
            void DepartmentSalaryAvg()
            {
                Console.WriteLine("Введите номер отдела");
                int departmentNumber = int.Parse(Console.ReadLine());
                var filteredEmployees = employees.Where(e => e.Department == departmentNumber);
                double departmentSalaryAvg = filteredEmployees.Average(e => e.Salary);
                Console.WriteLine($"Среднее значение зарплат для отдела {departmentNumber}: {departmentSalaryAvg}");
            }
            void IndexSalary()
            {
                Console.WriteLine("Введите номер отдела");
                int DepartmentOID = int.Parse(Console.ReadLine());
                Console.WriteLine("На сколько вы хотите поднять зарплату сотрудники");
                double SalaryPrecent = double.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == DepartmentOID)
                    {
                        emp.Salary *= 1 + (SalaryPrecent / 100);
                        Console.WriteLine($"Зарплата сотрудника {emp.Fio} равна {emp.Salary} рублей ");
                    }
                }
            }
            void GetInfoAllEmployeesWithDepartment()
            {
                Console.WriteLine("Введите номер отдела ");
                int selectdepartment = int.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == selectdepartment)
                    {
                        Console.WriteLine($"В данном отделе присутствует {emp.Fio} -- зарплата {emp.Salary} -- табельный номер {emp._id}");
                    }
                }
            }
            void Selectless()
            {
                Console.WriteLine("Введите число");
                int selectless = int.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary < selectless)
                    {
                        Console.WriteLine($"ФИО {emp.Fio} -- Зарплата сотрудника {emp.Salary}-- табельный номер сотрудника {emp._id} ");
                    }
                }
            }
            void Selectabove()
            {
                Console.WriteLine("Введите число");
                int selectless = int.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary >= selectless)
                    {
                        Console.WriteLine($"ФИО {emp.Fio} -- Зарплата сотрудника {emp.Salary}-- табельный номер сотрудника {emp._id} ");
                    }
                }
            }
            void AddNewEmployee()
            {
                if (employees.Count < employees.Capacity)
                {
                    Console.WriteLine(" есть свободная ячейка");
                    Console.WriteLine("Введите ФИО сотрудника"); string NameNewEmployee = Console.ReadLine();
                    Console.WriteLine("Введите департамент сотрудника");
                    int DepartmentNewEmployee = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите зарплату сотрудника");
                    double SalaryNewEmployee = Convert.ToDouble(Console.ReadLine());
                    var IDlast = employees.OrderBy(e => e._id).Last();
                    int idselect = IDlast._id;
                    idselect += 1;
                    employees.Add(new(NameNewEmployee, DepartmentNewEmployee, SalaryNewEmployee));
                    foreach (var emp in employees)
                    {
                        Console.WriteLine($"ФИО сотрудника - {emp.Fio}, Департамент - {emp.Department}, Зарплата - {emp.Salary} руб, Id - {emp._id},");
                    }
                }
                else
                {
                    Console.WriteLine("Список полный, нет свободных ячеек!");
                }
            }
            void DeleteEmployee()
            {
                Console.WriteLine("Введите ID сотрудника которого хотите удалить");
                int index = int.Parse(Console.ReadLine());
                index -= 1; deletedemployee.Add(employees[index]);
                foreach (var delemp in deletedemployee)
                {
                    Console.WriteLine($"Фио удаленного сотрудника {delemp.Fio}, департамент {delemp.Department}, Зарплата {delemp.Salary},ID {delemp._id}");
                }
                index += 1;
                foreach (var emp in employees)
                {
                    if (emp._id == index)
                    {
                        employees.Remove(emp);
                        break;
                    }
                }
                if (employees.Count > 0)
                {
                    Console.WriteLine("Список сотрудников после удаления:");
                    foreach (var emp in employees)
                    {
                        Console.WriteLine($"{emp._id}, {emp.Fio}, {emp.Department}, {emp.Salary} руб.");
                    }
                }
                else
                {
                    Console.WriteLine("Список сотрудников пуст.");
                }
            }
            void ChangeSalary()
            {
                Console.WriteLine("Введите ID сотрудника которому хотите поменять зарплату");
                int indexchangesalary = int.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp._id == indexchangesalary)
                    {
                        Console.WriteLine($"Введите новую зарплату сотруднику {emp.Fio}");
                        double newsalary = Convert.ToDouble(Console.ReadLine());
                        emp.Salary = newsalary;
                        Console.WriteLine($"новая зарплата сотрудника {emp.Fio} равна  - {emp.Salary} ");
                    }
                }
            }
            void ChangeDepartment()
            {
                Console.WriteLine("Введите ID сотрудника которому хотите поменять отдел");
                int indexchangedepartment = int.Parse(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp._id == indexchangedepartment)
                    {
                        Console.WriteLine($"Введите новый отдел сотруднику {emp.Fio}");
                        int newdepartment = int.Parse(Console.ReadLine());
                        emp.Department = newdepartment;
                        Console.WriteLine($"новый отдел сотрудника {emp.Fio} теперь - {emp.Department} ");
                    }
                }
            } while (true)
            {
                Console.WriteLine("Напишите 20, чтобы узнать информацию о всех заданиях");

                int number_mission = Convert.ToInt32(Console.ReadLine());
                switch (number_mission)
                {
                    case 20:
                        Console.WriteLine("1-е задание: Все данные сотрудников");
                        Console.WriteLine("2-е задание: Сумма затрат на зп в месяц");
                        Console.WriteLine("3-е задание: Сотрудник с минимальной зарплатой");
                        Console.WriteLine("4-е задание: Сотрудник с максимальной зарплатой");
                        Console.WriteLine("5-е задание: Среднее значение зарплат");
                        Console.WriteLine("6-е задание: ФИО всех сотрудников");
                        Console.WriteLine("7-е задание: На какой процент вы хотите увеличить зарплату");
                        Console.WriteLine("8-е задание: Узнать зарплаты сотрудников в определённом отделе");
                        Console.WriteLine("9-е задание: Минимальная зарплата в определенном отделе");
                        Console.WriteLine("10-е задание: Максимальная зарплата в определенном отделе");
                        Console.WriteLine("11-е задание: Средняя зарплата в определенном отделе");
                        Console.WriteLine("12-е задание: Увеличение зарплаты в % в определенном отделе");
                        Console.WriteLine("13-е задание: Информация о сотрудниках в определенном отделе");
                        Console.WriteLine("14-е задание: Зарплата ниже числа");
                        Console.WriteLine("15-е задание: Зарплата выше числа");
                        Console.WriteLine("16-e задание: Добавить сотрудника");
                        Console.WriteLine("17-e задание: Удалить сотрудника");
                        Console.WriteLine("18-e задание: Изменить зарплату сотрудника");
                        Console.WriteLine("19-e задание: Изменить департамент сотрудника");
                        break;
                }

                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmployeeInfo();
                        break;
                    case 2:
                        EmployeeSalary();
                        break;
                    case 3:
                        MinSalary();
                        break;
                    case 4:
                        MaxSalary();
                        break;
                    case 5:
                        AvgSalary();
                        break;
                    case 6:
                        EmlployeeFio();
                        break;
                    case 7:
                        SalaryPrecent();
                        break;
                    case 8:
                        DepartmentEmployee();
                        break;
                    case 9:
                        DepartamentSalaryMin();
                        break;
                    case 10:
                        DepartamentSalaryMax();
                        break;
                    case 11:
                        DepartmentSalaryAvg();
                        break;
                    case 12:
                        IndexSalary();
                        break;
                    case 13:
                        GetInfoAllEmployeesWithDepartment();
                        break;
                    case 14:
                        Selectless();
                        break;
                    case 15:
                        Selectabove();
                        break;
                    case 16:
                        AddNewEmployee();
                        break;
                    case 17:
                        DeleteEmployee();
                        break;
                    case 18:
                        ChangeSalary();
                        break;
                    case 19:
                        ChangeDepartment();
                        break;


                }                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }

