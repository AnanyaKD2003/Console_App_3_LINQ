using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class Grouping
    {
        List<Employee> employees = SampleData.Employees;

        // 1. GroupBy()
        // Groups employees based on Department.
        public void GroupByDepartment()
        {
            var result = employees.GroupBy(e => e.Department);

            foreach (var group in result)
            {
                Console.WriteLine($"\nDepartment : {group.Key}");

                foreach (var employee in group)
                {
                    Console.WriteLine($"{employee.Name} - {employee.Salary}");
                }
            }
        }

        // 2. GroupBy + Count()
        // Counts the number of employees in each department.
        public void CountEmployeesByDepartment()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    EmployeeCount = g.Count()
                });

            Console.WriteLine("Employee Count by Department:");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Department} : {item.EmployeeCount}");
            }
        }

        // 3. GroupBy + Average()
        // Calculates the average salary for each department.
        public void AverageSalaryByDepartment()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                });

            Console.WriteLine("Average Salary by Department:");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Department} : {item.AverageSalary}");
            }
        }

        // 4. GroupBy + Sum()
        // Calculates the total salary for each department.
        public void TotalSalaryByDepartment()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    TotalSalary = g.Sum(e => e.Salary)
                });

            Console.WriteLine("Total Salary by Department:");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Department} : {item.TotalSalary}");
            }
        }

        // 5. GroupBy + Max()
        // Finds the highest salary in each department.
        public void HighestSalaryByDepartment()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    HighestSalary = g.Max(e => e.Salary)
                });

            Console.WriteLine("Highest Salary by Department:");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Department} : {item.HighestSalary}");
            }
        }

        // 6. GroupBy + Min()
        // Finds the lowest salary in each department.
        public void LowestSalaryByDepartment()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    LowestSalary = g.Min(e => e.Salary)
                });

            Console.WriteLine("Lowest Salary by Department:");

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Department} : {item.LowestSalary}");
            }
        }

        // 7. GroupBy with Multiple Keys
        // Groups employees by Department and Age.
        public void GroupByMultipleKeys()
        {
            var result = employees.GroupBy(e => new
            {
                e.Department,
                e.Age
            });

            Console.WriteLine("Employees Grouped by Department and Age:");

            foreach (var group in result)
            {
                Console.WriteLine($"\nDepartment : {group.Key.Department}, Age : {group.Key.Age}");

                foreach (var employee in group)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }

        // 8. GroupBy + Select()
        // Projects grouped data into an anonymous object.
        public void DepartmentSummary()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    EmployeeCount = g.Count(),
                    AverageSalary = g.Average(e => e.Salary)
                });

            Console.WriteLine("Department Summary:");

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"Department : {item.Department}, Employees : {item.EmployeeCount}, Average Salary : {item.AverageSalary}");
            }
        }

        // 9. Department Statistics
        // Returns multiple aggregate values for each department.
        public void DepartmentStatistics()
        {
            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    EmployeeCount = g.Count(),
                    TotalSalary = g.Sum(e => e.Salary),
                    AverageSalary = g.Average(e => e.Salary),
                    HighestSalary = g.Max(e => e.Salary),
                    LowestSalary = g.Min(e => e.Salary)
                });

            Console.WriteLine("Department Statistics:");

            foreach (var item in result)
            {
                Console.WriteLine($"\nDepartment : {item.Department}");
                Console.WriteLine($"Employees      : {item.EmployeeCount}");
                Console.WriteLine($"Total Salary   : {item.TotalSalary}");
                Console.WriteLine($"Average Salary : {item.AverageSalary}");
                Console.WriteLine($"Highest Salary : {item.HighestSalary}");
                Console.WriteLine($"Lowest Salary  : {item.LowestSalary}");
            }
        }
    }
}

/*
=========================================================
                GROUPING - INTERVIEW NOTES
=========================================================

✔ GroupBy()
• Groups elements based on a common key.
• Returns IEnumerable<IGrouping<TKey, TValue>>.
• Similar to SQL GROUP BY.

Example:
IT
    John
    Jill

HR
    Jane
    James

---------------------------------------------------------

✔ GroupBy() + Count()

• Counts the number of elements in each group.

Example:

IT -> 2
HR -> 2
Finance -> 2

---------------------------------------------------------

✔ GroupBy() + Average()

• Calculates the average value of each group.

Example:

IT -> 52500
HR -> 42500
Finance -> 62500

---------------------------------------------------------

✔ GroupBy() + Sum()

• Calculates the total value of each group.

Example:

IT -> 105000
HR -> 85000
Finance -> 125000

---------------------------------------------------------

✔ GroupBy() + Max()

• Finds the maximum value in each group.

Example:

IT -> 55000

---------------------------------------------------------

✔ GroupBy() + Min()

• Finds the minimum value in each group.

Example:

IT -> 50000

---------------------------------------------------------

✔ GroupBy() with Multiple Keys

Groups using more than one property.

Example:

employees.GroupBy(e => new
{
    e.Department,
    e.Age
});

Useful when reports require grouping by multiple columns.

---------------------------------------------------------

✔ GroupBy() + Select()

Projects grouped data into a custom object.

Example:

Department
Employee Count
Average Salary

This is the most common way GroupBy() is used in real projects.

---------------------------------------------------------

Department Statistics

Combines multiple aggregate functions together.

Example:

Department
Count
Sum
Average
Maximum
Minimum

Very common in dashboards and reports.

=========================================================
                SQL EQUIVALENT
=========================================================

LINQ

employees.GroupBy(e => e.Department)

SQL

SELECT Department
FROM Employees
GROUP BY Department;

---------------------------------------------------------

LINQ

GroupBy()
.Select(g => new
{
    g.Key,
    Count = g.Count(),
    Average = g.Average(x => x.Salary)
})

SQL

SELECT Department,
COUNT(*),
AVG(Salary)
FROM Employees
GROUP BY Department;

=========================================================
                INTERVIEW QUESTIONS
=========================================================

Q1. What does GroupBy() return?

Answer:
IEnumerable<IGrouping<TKey,TValue>>

---------------------------------------------------------

Q2. What is group.Key?

Answer:
The value used for grouping.

---------------------------------------------------------

Q3. Can we use multiple keys in GroupBy()?

Yes.

Example:

GroupBy(e => new
{
    e.Department,
    e.Age
})

---------------------------------------------------------

Q4. Difference between GroupBy() and ToLookup()?

GroupBy()

✔ Deferred execution
✔ Query is executed when enumerated

ToLookup()

✔ Immediate execution
✔ Creates a read-only lookup

---------------------------------------------------------

Q5. Which aggregate methods are commonly used with GroupBy()?

✔ Count()
✔ Sum()
✔ Average()
✔ Max()
✔ Min()

=========================================================
                REAL WORLD USES
=========================================================

✔ Employee Reports

✔ Sales by Month

✔ Orders by Customer

✔ Products by Category

✔ Students by Grade

✔ Dashboard Statistics

✔ Financial Reports

✔ Analytics

=========================================================
                THINGS TO REMEMBER
=========================================================

✔ GroupBy() only creates groups.

✔ Aggregate methods come AFTER GroupBy().

✔ GroupBy() returns IEnumerable<IGrouping<TKey,TValue>>.

✔ group.Key gives the grouping key.

✔ GroupBy() is Deferred Execution.

✔ GroupBy() is one of the most important LINQ operators.

✔ Frequently used with:
    Count()
    Sum()
    Average()
    Min()
    Max()
    Select()

=========================================================
*/