using ConsoleApp5;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new()
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





        while (true)
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
                    Console.WriteLine("9-е задание: Минимальная зарплата в каком-то отделе");
                    Console.WriteLine("10-е задание: Максимальная зарплата в каком-то отделе");
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

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}