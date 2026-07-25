using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class Conversion
    {
        List<Employee> employees = SampleData.Employees;

        // 1. ToList()
        // Converts the sequence into a List<T>.
        // Executes the query immediately and stores the result in memory.
        public void ToListExample()
        {
            var result = employees
                .Where(e => e.Salary > 50000)
                .ToList(); // Materializes the query into a List.

            Console.WriteLine("Employees with Salary > 50000:");

            foreach (var emp in result)
            {
                Console.WriteLine(emp.Name);
            }
        }

        // 2. ToArray()
        // Converts the sequence into an array.
        // Executes the query immediately and returns a fixed-size collection.
        public void ToArrayExample()
        {
            var result = employees
                .Select(e => e.Name)
                .ToArray(); // Materializes the query into an array.

            Console.WriteLine("Employee Names:");

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }

        // 3. ToDictionary()
        // Converts the sequence into a Dictionary<TKey,TValue>.
        // The selected key must be UNIQUE, otherwise an exception is thrown.
        public void ToDictionaryExample()
        {
            var result = employees.ToDictionary(e => e.Id);

            Console.WriteLine("Employee Dictionary:");

            foreach (var item in result)
            {
                Console.WriteLine($"Key : {item.Key}, Value : {item.Value.Name}");
            }

            // Example:
            // 1 -> John
            // 2 -> Jane
        }

        // 4. ToLookup()
        // Groups elements by a key and returns an ILookup<TKey,TValue>.
        // Unlike ToDictionary(), duplicate keys are allowed.
        public void ToLookupExample()
        {
            var result = employees.ToLookup(e => e.Department);

            Console.WriteLine("Employees Grouped by Department:");

            foreach (var group in result)
            {
                Console.WriteLine($"\nDepartment : {group.Key}");

                foreach (var emp in group)
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }

        // 5. AsEnumerable()
        // Treats the collection as IEnumerable<T>.
        // Used when you want the remaining query to execute in memory (LINQ to Objects).
        public void AsEnumerableExample()
        {
            var result = employees
                .AsEnumerable()
                .Where(e => e.Age > 28);

            Console.WriteLine("Employees Age > 28:");

            foreach (var emp in result)
            {
                Console.WriteLine(emp.Name);
            }
        }

        // 6. AsQueryable()
        // Treats the collection as IQueryable<T>.
        // Commonly used with Entity Framework so queries can be translated into SQL.
        public void AsQueryableExample()
        {
            var result = employees
                .AsQueryable()
                .Where(e => e.Salary >= 50000);

            Console.WriteLine("Salary >= 50000:");

            foreach (var emp in result)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}

/*
=========================================================
                    CONVERSION NOTES
=========================================================

1. ToList()
✔ Converts IEnumerable<T> to List<T>.
✔ Executes the query immediately.
✔ Returns List<T>.
✔ Most commonly used conversion operator.

---------------------------------------------------------

2. ToArray()
✔ Converts IEnumerable<T> to T[].
✔ Executes the query immediately.
✔ Array size is fixed.

---------------------------------------------------------

3. ToDictionary()
✔ Converts data into Key-Value pairs.
✔ Returns Dictionary<TKey,TValue>.
✔ Keys MUST be unique.
✔ Duplicate keys throw an exception.
✔ Best for fast lookups.

Example:
1 -> John
2 -> Jane

---------------------------------------------------------

4. ToLookup()
✔ Similar to Dictionary but allows duplicate keys.
✔ Returns ILookup<TKey,TValue>.
✔ Read-only collection.
✔ Best for one-to-many relationships.

Example:

IT
   John
   Jill

HR
   Jane
   James

---------------------------------------------------------

5. AsEnumerable()
✔ Converts the source to IEnumerable<T>.
✔ Remaining operations execute using LINQ to Objects.
✔ Useful when you want processing to happen in memory.

---------------------------------------------------------

6. AsQueryable()
✔ Converts the source to IQueryable<T>.
✔ Deferred execution.
✔ Mostly used with Entity Framework.
✔ Allows the query to be translated into SQL.
✔ Useful for dynamic query building.

---------------------------------------------------------

Interview Differences

ToList() vs ToArray()

List<T>
✔ Dynamic size
✔ Most commonly used

T[]
✔ Fixed size
✔ Better when an array is required

---------------------------------------------------------

ToDictionary() vs ToLookup()

Dictionary
✔ Unique keys only
✔ Mutable

Lookup
✔ Duplicate keys allowed
✔ Read-only
✔ One key -> Multiple values

---------------------------------------------------------

AsEnumerable() vs AsQueryable()

AsEnumerable()
✔ In-memory (LINQ to Objects)

AsQueryable()
✔ Database queries (EF Core)
✔ SQL translation

=========================================================
*/