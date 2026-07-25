using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class Quantifiers
    {
        List<int> numbers = SampleData.Numbers;
        List<string> names = SampleData.Names;
        List<Employee> employees = SampleData.Employees;

        // 1. Any()
        public void AnyExample()
        {
            bool result = employees.Any(e => e.Salary > 60000);

            Console.WriteLine(result);
        }

        // 2. Any() - Empty Collection
        public void AnyEmptyExample()
        {
            List<int> nums = new();

            bool result = nums.Any();

            Console.WriteLine(result);
        }

        // 3. All()
        public void AllExample()
        {
            bool result = employees.All(e => e.Age >= 25);

            Console.WriteLine(result);
        }

        // 4. Contains()
        public void ContainsNumberExample()
        {
            bool result = numbers.Contains(50);

            Console.WriteLine(result);
        }

        // 5. Contains() with string
        public void ContainsStringExample()
        {
            bool result = names.Contains("John");

            Console.WriteLine(result);
        }

        // 6. Any() with string
        public void AnyStartsWithExample()
        {
            bool result = names.Any(x => x.StartsWith("J"));

            Console.WriteLine(result);
        }

        // 7. All() with Salary
        public void AllSalaryExample()
        {
            bool result = employees.All(e => e.Salary > 30000);

            Console.WriteLine(result);
        }
    }
}