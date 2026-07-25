using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class ElementOperators
    {
        List<int> numbers = SampleData.Numbers;
        List<Employee> employees = SampleData.Employees;

        // 1. First()
        // Returns the first element. Throws an exception if the collection is empty.
        public void FirstExample()
        {
            var result = numbers.First();

            Console.WriteLine(result);
        }

        // 2. FirstOrDefault()
        // Returns the first matching element or null if no match is found.
        public void FirstOrDefaultExample()
        {
            var result = employees.FirstOrDefault(e => e.Department == "Marketing");

            if (result == null)
                Console.WriteLine("No Employee Found");
            else
                Console.WriteLine(result.Name);
        }

        // 3. Last()
        // Returns the last element. Throws an exception if the collection is empty.
        public void LastExample()
        {
            var result = numbers.Last();

            Console.WriteLine(result);
        }

        // 4. LastOrDefault()
        // Returns the last matching element or null if no match is found.
        public void LastOrDefaultExample()
        {
            var result = employees.LastOrDefault(e => e.Department == "Finance");

            if (result == null)
                Console.WriteLine("No Employee Found");
            else
                Console.WriteLine(result.Name);
        }

        // 5. Single()
        // Returns the only matching element. Throws an exception if zero or multiple matches exist.
        public void SingleExample()
        {
            var result = employees.Single(e => e.Id == 3);

            Console.WriteLine(result.Name);
        }

        // 6. SingleOrDefault()
        // Returns the only matching element or null. Throws an exception if multiple matches exist.
        public void SingleOrDefaultExample()
        {
            var result = employees.SingleOrDefault(e => e.Id == 10);

            if (result == null)
                Console.WriteLine("Employee Not Found");
            else
                Console.WriteLine(result.Name);
        }

        // 7. ElementAt()
        // Returns the element at the specified index. Throws an exception if the index is invalid.
        public void ElementAtExample()
        {
            var result = numbers.ElementAt(4);

            Console.WriteLine(result);
        }

        // 8. ElementAtOrDefault()
        // Returns the element at the specified index or the default value if the index is invalid.
        public void ElementAtOrDefaultExample()
        {
            var result = numbers.ElementAtOrDefault(100);

            Console.WriteLine(result);
        }

        // 9. DefaultIfEmpty()
        // Returns the original collection or the specified default value if the collection is empty.
        public void DefaultIfEmptyExample()
        {
            List<int> nums = new();

            var result = nums.DefaultIfEmpty(-1);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}