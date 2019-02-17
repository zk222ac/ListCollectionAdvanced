using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> emp = new List<Employee>()
            {
                new Employee("John Doe" , 5000),
                new Employee("Jane smith" , 7000),
                new Employee("Nick slick" , 8000),
                new Employee("Mildred Mintz" , 9000),
            };

            Console.WriteLine($"Capacity: {emp.Capacity}");
            Console.WriteLine($"Count: {emp.Count}");

            // List Exit and Find method
            // Exist --> return boolean
            // Find ---> return the found item

            if (emp.Exists(HighPay))
            {
                Console.WriteLine("Highly Paid Employee Found!");
            }

            // Find employee start with the name J
            Employee employee = emp.Find(x => x.Name.StartsWith("J"));
            // Retrieve all employees whose name start with J
            var allEmpStartWithJ = emp.FindAll(e => e.Name.StartsWith("J"));

            var checkEmployee = emp.Contains(new Employee("Nick slick", 8000));
            Console.WriteLine($"Find Employee whose name begins with J:{employee?.Name}");

            foreach (var allEmployee in allEmpStartWithJ)
            {
                Console.WriteLine(allEmployee);
            }

            Console.ReadKey();
            
        }

        static bool HighPay(Employee emp)
        {
            return emp.Salary >= 6500;
        }
    }
}
