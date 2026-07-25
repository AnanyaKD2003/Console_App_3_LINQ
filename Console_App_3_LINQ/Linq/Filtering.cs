using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_3_LINQ.Linq
{
    public class Filtering
    {

        List<int> numbers = new List<int>()
        {
            10,20,30,40,50,60,70,80,90,100
        };

        List<int> nums = new List<int>()
        {
            1,2,2,3,3,3,4,5,5,6,6,7,7
        };

        List<string> names = new List<string>()
        {
            "John","Jane","Jack","Jill","James","Jenny"
        };

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public string Department { get; set; } = string.Empty;
            public int Salary { get; set; }
        }

        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "John", Age = 30, Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Jane", Age = 25, Department = "HR", Salary = 40000 },
            new Employee { Id = 3, Name = "Jack", Age = 35, Department = "Finance", Salary = 60000 },
            new Employee { Id = 4, Name = "Jill", Age = 28, Department = "IT", Salary = 55000 },
            new Employee { Id = 5, Name = "James", Age = 32, Department = "HR", Salary = 45000 },
            new Employee { Id = 6, Name = "Jenny", Age = 29, Department = "Finance", Salary = 65000 }
        };

        List<object> data = new()
        {
            1,
            "Tapan",
            2,
            3,
            "Ray",
            true,
            4,
            5
        };

        // 1. Where()
        // Returns all elements that satisfy the specified condition.
        public void WhereExample()
        {
            var result = employees.Where(x => x.Age > 25).ToList();

            foreach (var i in result)
            {
                Console.WriteLine($"Id: {i.Id}, Name: {i.Name}, Age: {i.Age}, Department: {i.Department}, Salary: {i.Salary}");
            }

            Console.WriteLine("Number Greater than 50 :: ");

            var result2 = numbers.Where(x => x > 50);

            foreach (var i in result2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nEven Number with Distinct ::");

            var result3 = nums.Where(x => x % 2 == 0).Distinct();

            foreach (var i in result3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nEmployee from IT Department :: ");

            var result4 = employees.Where(x => x.Department == "IT");

            foreach (var i in result4)
            {
                Console.WriteLine($"Id: {i.Id}, Name: {i.Name}, Age: {i.Age}, Department: {i.Department}, Salary: {i.Salary}");
            }

            Console.WriteLine("\nMultiple Conditions :: ");

            var result5 = employees.Where(x => x.Department == "IT" && x.Salary > 50000);

            foreach (var i in result5)
            {
                Console.WriteLine($"Id: {i.Id}, Name: {i.Name}, Age: {i.Age}, Department: {i.Department}, Salary: {i.Salary}");
            }

            Console.WriteLine("\nSearching Name with Contains ::");

            var result6 = names.Where(x => x.Contains("o"));

            foreach (var i in result6)
            {
                Console.WriteLine(i);
            }
        }

        // 2. OfType()
        // Returns only the elements of the specified type from a mixed collection.
        public void ofTypeExample()
        {
            var result = data.OfType<string>();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        // 3. Cast()
        // Casts all elements to the specified type. Throws an exception if a cast is invalid.
        public void castExample()
        {
            var result = data.OfType<string>().Cast<string>();

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}