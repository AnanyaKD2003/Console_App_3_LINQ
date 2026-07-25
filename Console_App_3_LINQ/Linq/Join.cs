using Console_App_3_LINQ.Data;
using Console_App_3_LINQ.Models;

namespace Console_App_3_LINQ.Linq
{
    public class Join
    {
        List<Employee> employees = SampleData.Employees;
        List<Department> departments = SampleData.Departments;

        // 1. Inner Join
        // Returns only the matching records from both collections.
        public void InnerJoinExample()
        {
            var result = employees.Join(
                departments,
                employee => employee.Department,
                department => department.Name,
                (employee, department) => new
                {
                    employee.Name,
                    employee.Age,
                    employee.Salary,
                    Department = department.Name,
                    department.Location
                });

            Console.WriteLine("Inner Join:");

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"Name: {item.Name}, Department: {item.Department}, Location: {item.Location}");
            }
        }

        // 2. Group Join
        // Groups matching employees under each department.
        public void GroupJoinExample()
        {
            var result = departments.GroupJoin(
                employees,
                department => department.Name,
                employee => employee.Department,
                (department, empGroup) => new
                {
                    Department = department.Name,
                    Employees = empGroup
                });

            Console.WriteLine("Group Join:");

            foreach (var group in result)
            {
                Console.WriteLine($"\nDepartment: {group.Department}");

                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }

        // 3. Left Outer Join
        // Returns all departments, even if no employees exist.
        public void LeftOuterJoinExample()
        {
            var result = departments
                .GroupJoin(
                    employees,
                    department => department.Name,
                    employee => employee.Department,
                    (department, empGroup) => new
                    {
                        Department = department,
                        Employees = empGroup
                    })
                .SelectMany(
                    x => x.Employees.DefaultIfEmpty(),
                    (x, employee) => new
                    {
                        Department = x.Department.Name,
                        Employee = employee?.Name ?? "No Employee"
                    });

            Console.WriteLine("Left Outer Join:");

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"Department: {item.Department}, Employee: {item.Employee}");
            }
        }

        // 4. Cross Join
        // Returns every employee with every department.
        public void CrossJoinExample()
        {
            var result = employees.SelectMany(
                employee => departments,
                (employee, department) => new
                {
                    Employee = employee.Name,
                    Department = department.Name
                });

            Console.WriteLine("Cross Join:");

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"Employee: {item.Employee}, Department: {item.Department}");
            }
        }

        // 5. Composite Key Join
        // Joins collections using more than one key.
        public void CompositeKeyJoinExample()
        {
            var result = employees.Join(
                departments,
                employee => new
                {
                    Department = employee.Department,
                    Location = employee.Location
                },
                department => new
                {
                    Department = department.Name,
                    Location = department.Location
                },
                (employee, department) => new
                {
                    EmployeeName = employee.Name,
                    DepartmentName = department.Name,
                    department.Location
                });

            Console.WriteLine("Composite Key Join:");

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"Employee: {item.EmployeeName}, Department: {item.DepartmentName}, Location: {item.Location}");
            }
        }

        // 6. Join with Projection
        // Projects only the required fields after joining.
        public void JoinWithProjectionExample()
        {
            var result = employees.Join(
                departments,
                employee => employee.Department,
                department => department.Name,
                (employee, department) => new
                {
                    employee.Name,
                    Department = department.Name
                });

            Console.WriteLine("Join with Projection:");

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"Employee: {item.Name}, Department: {item.Department}");
            }
        }
    }
}

/*
=========================================================
                JOIN - INTERVIEW NOTES
=========================================================

✔ Join()

• Combines two collections based on a common key.
• Similar to SQL INNER JOIN.
• Returns only matching records.

Example:

Employee      Department
-------------------------
John          IT
Jane          HR

---------------------------------------------------------

✔ GroupJoin()

• Groups matching records together.
• Returns one parent with a collection of children.
• Similar to one-to-many relationship.

Example:

IT
    John
    Jill

HR
    Jane
    James

---------------------------------------------------------

✔ Left Outer Join

• Returns ALL records from the left collection.
• Matching records are returned from the right collection.
• If no match exists, DefaultIfEmpty() returns null.

Syntax:

GroupJoin()
SelectMany()
DefaultIfEmpty()

---------------------------------------------------------

✔ Cross Join

• Every item from Collection A is matched with every item from Collection B.

Formula:

Rows = A.Count × B.Count

Example:

Employees = 6
Departments = 4

Result = 24 rows

---------------------------------------------------------

✔ Composite Key Join

• Join using more than one column.

Example:

Department
Location

Useful when a single key is not enough.

=========================================================
                SQL EQUIVALENT
=========================================================

LINQ Join()

employees.Join(...)

SQL

SELECT *
FROM Employees
INNER JOIN Departments
ON Employees.Department = Departments.Name

---------------------------------------------------------

Left Outer Join

SQL

SELECT *
FROM Departments
LEFT JOIN Employees
ON Departments.Name = Employees.Department

---------------------------------------------------------

Cross Join

SQL

SELECT *
FROM Employees
CROSS JOIN Departments

=========================================================
                INTERVIEW QUESTIONS
=========================================================

Q1. Difference between Join() and GroupJoin()?

Join()

✔ Returns flat results.

Example:

John - IT

Jane - HR

GroupJoin()

✔ Returns grouped results.

Example:

IT
    John
    Jill

HR
    Jane

---------------------------------------------------------

Q2. Which LINQ operator performs INNER JOIN?

Answer:

Join()

---------------------------------------------------------

Q3. How do we perform LEFT OUTER JOIN in LINQ?

Answer:

GroupJoin()
+
DefaultIfEmpty()
+
SelectMany()

---------------------------------------------------------

Q4. Does LINQ have Right Join?

Answer:

No.

Swap the collections and perform Left Join.

---------------------------------------------------------

Q5. Does LINQ have Full Outer Join?

Answer:

No.

Need to combine Left Join + Right Join manually.

---------------------------------------------------------

Q6. What is a Composite Key Join?

Joining on multiple columns.

Example:

Department
Location

=========================================================
                REAL WORLD USES
=========================================================

✔ Employee ↔ Department

✔ Student ↔ Course

✔ Customer ↔ Orders

✔ Product ↔ Category

✔ User ↔ Roles

✔ Invoice ↔ InvoiceItems

✔ Employee ↔ Address

=========================================================
                THINGS TO REMEMBER
=========================================================

✔ Join() = INNER JOIN

✔ GroupJoin() = Parent with Child Collection

✔ Left Join =
GroupJoin() +
DefaultIfEmpty() +
SelectMany()

✔ Cross Join =
SelectMany()

✔ Composite Join =
Join using multiple keys.

✔ Right Join is NOT available.

✔ Full Outer Join is NOT available.

=========================================================
*/