using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class Sorting
    {
        List<int> numbers = SampleData.Numbers;
        List<string> names = SampleData.Names;
        List<Employee> employees = SampleData.Employees;

        // 1. OrderBy - Ascending Order
        // Sorts the elements in ascending order.
        public void OrderByExample()
        {
            var result = numbers.OrderBy(x => x);

            Console.WriteLine("Numbers in Ascending Order:");

            foreach (var num in result)
            {
                Console.WriteLine(num + " ");
            }
        }

        // 2. OrderByDescending - Descending Order
        // Sorts the elements in descending order.
        public void OrderByDescendingExample()
        {
            var result = numbers.OrderByDescending(x => x);

            Console.WriteLine("Numbers in Descending Order:");

            foreach (var num in result)
            {
                Console.WriteLine(num + " ");
            }
        }

        // 3. Sort Employees by their Age
        // Sorts employees in ascending order based on Age.
        public void SortEmployeesByAge()
        {
            var result = employees.OrderBy(e => e.Age);

            Console.WriteLine("Employees sorted by Age:");

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}");
            }
        }

        // 4. Sort Employees by their Salary in Descending Order
        // Sorts employees in descending order based on Salary.
        public void SortEmployeesBySalaryDescending()
        {
            var result = employees.OrderByDescending(x => x.Salary);

            Console.WriteLine("Employees sorted by Salary in Descending Order:");

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        // 5. Sort Names Alphabetically
        // Sorts names alphabetically in ascending order.
        public void SortNamesAlphabetically()
        {
            var result = names.OrderBy(x => x);

            Console.WriteLine("Names sorted Alphabetically:");

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        // 6. ThenBy - Sort Employees by Department and then by Age
        // Performs a secondary ascending sort after OrderBy().
        public void SortEmployeesByDepartmentThenByAge()
        {
            var result = employees
                .OrderBy(e => e.Department)
                .ThenBy(e => e.Age);

            Console.WriteLine("Employees sorted by Department and then by Age:");

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Age: {emp.Age}");
            }
        }

        // 7. ThenByDescending - Sort Employees by Department and then by Salary in Descending Order
        // Performs a secondary descending sort after OrderBy().
        public void SortEmployeesByDepartmentThenBySalaryDescending()
        {
            var result = employees
                .OrderBy(e => e.Department)
                .ThenByDescending(e => e.Salary);

            Console.WriteLine("Employees sorted by Department and then by Salary in Descending Order:");

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
        }

        // 8. Reverse - Reverse the Order of Numbers
        // Reverses the order of the elements in the sequence.
        public void ReverseNumbers()
        {
            var result = numbers.AsEnumerable().Reverse();

            Console.WriteLine("Numbers in Reverse Order:");

            foreach (var num in result)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}