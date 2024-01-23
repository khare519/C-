using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Storing the list of employees 
            List<Employee> list = new List<Employee>();


            //Creating first employee
            Employee employee1 = new Employee { Id=1,Name="Satyam",Address="Lucknow"};  
            //employee1.Id = 1;
            //employee1.Name = "Satyam";
            //employee1.Address = "Lucknow";
            list.Add(employee1);

            //Creating second employee
            Employee employee2 = new Employee { Id=2,Name="Rahul",Address="Madhapur"};
            //employee2.Id = 2;
            //employee2.Name = "Rahul";
            //employee2.Address = "Madhapur";
            list.Add(employee2);

            //Creating third employee
            Employee employee3 = new Employee { Id=3,Name="Malik",Address="Hyderabad"};
            //employee3.Id = 3;
            //employee3.Name = "Malik";
            //employee3.Address = "Hyderabad";
            list.Add(employee3);

            //Creating fourth employee
            Employee employee4 = new Employee
            {
                Id = 4,
                Name = "Sharanya",
                Address = "Hyderabad"
            };
            list.Add(employee4);

            
           
            //printing the list of employees on the console
            foreach (Employee e in list)
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.Address}");
            }
            Console.ReadLine();

        }
    }
}
