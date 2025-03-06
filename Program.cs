using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng PartTimeEmployee
            PartTimeEmployee partTime = new PartTimeEmployee("Nguyen Van A", 50, 100);
            Console.WriteLine($"Part-time Employee: {partTime.getName()}, Salary: {partTime.calculateSalary()}");

            // Tạo đối tượng FullTimeEmployee
            FullTimeEmployee fullTime = new FullTimeEmployee("Tran Thi B", 60);
            Console.WriteLine($"Full-time Employee: {fullTime.getName()}, Salary: {fullTime.calculateSalary()}");
        }
    }
}