using OOPtask;
using OOPTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.Write($"Enter the name of employee {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write("Is this employee outsourced (yes/no)? ");
                string isOutsourcedInput = Console.ReadLine().ToLower();
                bool isOutsourced = isOutsourcedInput == "yes";

                Console.Write("Enter the number of hours worked: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Enter the value per hour: ");
                decimal valuePerHour = decimal.Parse(Console.ReadLine());

                decimal payment;
                decimal additionalCharge = 0;

                if (isOutsourced)
                {
                    Console.Write("Enter the additional charge: ");
                    additionalCharge = decimal.Parse(Console.ReadLine());


                    Employee employee;
                    if (isOutsourced)
                    {
                        employee = new Outsourced
                        {
                            Name = name,
                            Hours = hours,
                            ValuePerHour = valuePerHour,
                            AdditionalCharge = additionalCharge,

                        };
                    }

                    else
                    {
                        employee = new Employee
                        {
                            Name = name,
                            Hours = hours,
                            ValuePerHour = valuePerHour
                        };
                    }

                    employee.CalculatePayment();
                    payment = employee.Payment;
                    employees.Add(employee);
                }
                else
                {
                    Employee employee = new Employee
                    {
                        Name = name,
                        Hours = hours,
                        ValuePerHour = valuePerHour
                    };

                    employee.CalculatePayment();
                    payment = employee.Payment;

                    employees.Add(employee);
                }
            }

            Console.WriteLine("\nPayroll Report:");
            Console.WriteLine("----------------------");

            foreach (Employee employee in employees)
            {
                if (employee is Outsourced outsourcedEmployee)
                {
                    Console.WriteLine($"{employee.Name} : R$ {employee.Payment:F2}");
                }
                else
                {
                    Console.WriteLine($"{employee.Name}: R$ {employee.Payment:F2}");

                }
                Console.ReadLine();
            }
        }
    }
}
