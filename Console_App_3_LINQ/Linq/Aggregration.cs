using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class Aggregation
    {
        List<int> numbers = SampleData.Numbers;
        List<Employee> employees = SampleData.Employees;

        // 1. Count()
        // Returns the total number of elements in the collection.
        public void CountExample()
        {
            var result = numbers.Count();

            Console.WriteLine($"Total Numbers : {result}");

            var employeeCount = employees.Count();

            Console.WriteLine($"Total Employees : {employeeCount}");

            var itEmployees = employees.Count(e => e.Department == "IT");

            Console.WriteLine($"IT Employees : {itEmployees}");
        }

        // 2. LongCount()
        // Returns the total number of elements as a long value.
        public void LongCountExample()
        {
            var result = numbers.LongCount();

            Console.WriteLine(result);
        }

        // 3. Sum()
        // Returns the sum of numeric values.
        public void SumExample()
        {
            var total = numbers.Sum();

            Console.WriteLine($"Sum of Numbers : {total}");

            var totalSalary = employees.Sum(e => e.Salary);

            Console.WriteLine($"Total Salary : {totalSalary}");
        }

        // 4. Average()
        // Returns the average of numeric values.
        public void AverageExample()
        {
            var average = numbers.Average();

            Console.WriteLine($"Average : {average}");

            var averageSalary = employees.Average(e => e.Salary);

            Console.WriteLine($"Average Salary : {averageSalary}");
        }

        // 5. Min()
        // Returns the smallest value from the collection.
        public void MinExample()
        {
            var result = numbers.Min();

            Console.WriteLine($"Minimum Number : {result}");

            var youngest = employees.Min(e => e.Age);

            Console.WriteLine($"Youngest Employee Age : {youngest}");
        }

        // 6. Max()
        // Returns the largest value from the collection.
        public void MaxExample()
        {
            var result = numbers.Max();

            Console.WriteLine($"Maximum Number : {result}");

            var highestSalary = employees.Max(e => e.Salary);

            Console.WriteLine($"Highest Salary : {highestSalary}");
        }

        // 7. Aggregate()
        // Performs a custom aggregation on the collection.
        public void AggregateExample()
        {
            var sum = numbers.Aggregate((x, y) => x + y);

            Console.WriteLine($"Sum using Aggregate : {sum}");

            var sentence = SampleData.Names.Aggregate((x, y) => x + ", " + y);

            Console.WriteLine(sentence);
        }
    }
}