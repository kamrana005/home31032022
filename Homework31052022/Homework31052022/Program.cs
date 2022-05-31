using System;

namespace Homework31052022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iscilerin sayini daxil edin:");
            string counstr=Console.ReadLine();
            int count=Convert.ToInt32(counstr);

            Employee[] employees = new Employee[count];
            for(int i = 0; i < count; i++)
            {
                

                Console.WriteLine($"{i + 1}.iscinin adi:");
                string fullname = Console.ReadLine();


                Console.WriteLine($"{i + 1}.iscinin yasi:");
                string agestr=Console.ReadLine();
                int age =Convert.ToInt32(agestr);

                Console.WriteLine($"{i + 1}.iscinin maasi:");
                string salarystr = Console.ReadLine();
                double salary = Convert.ToInt64(salarystr);

                Console.WriteLine($"{i + 1}.iscinin vezifesi:");
                string position = Console.ReadLine();

                employees[i] = new Employee
                {
                    FullName = fullname,
                    Age = age,
                    Salary = salary,
                    Position = position
                };

            }
                
                

        }
    }
}
