using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_3_LINQ.Linq
{
    public class Projection
    {
        List<int> nums = new()
        {
            1,2,3,4,5,6,7,8,9,10
        };

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        };

        List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "John" },
            new Employee { Id = 2, Name = "Jane" },
            new Employee { Id = 3, Name = "Jack" },
            new Employee { Id = 4, Name = "Jill" },
            new Employee { Id = 5, Name = "James" }
        };

        // 1. Select()
        // Projects each element into a new form.
        public void SelectExample()
        {
            var result = nums.Select(x => x * x);

            Console.WriteLine("Square of Numbers:");

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            var result2 = employees.Select(e => e.Name);

            Console.WriteLine("\nEmployee Names:");

            foreach (var i in result2)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Anonymous Object
        // Projects selected properties into an anonymous object.
        public void AnonymousObject()
        {
            var result = employees.Select(e => new
            {
                e.Id,
                IsValid = e.Id > 2
            });

            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, IsValid: {item.IsValid}");
            }
        }

        class Student
        {
            public string? Name { get; set; }
            public List<string>? Subjects { get; set; }
        }

        // 3. SelectMany()
        // Flattens nested collections into a single sequence.
        public void SelectManyExample()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Name = "John",
                    Subjects = new List<string>{"Math","Science"}
                },
                new Student
                {
                    Name = "Alice",
                    Subjects = new List<string>{"English","History"}
                }
            };

            var subjects = students.SelectMany(s => s.Subjects ?? new List<string>());

            Console.WriteLine("All Subjects:");

            foreach (var s in subjects)
            {
                Console.WriteLine(s);
            }
        }
    }
}