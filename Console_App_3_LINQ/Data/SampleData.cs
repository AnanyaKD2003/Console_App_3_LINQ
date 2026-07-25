namespace Console_App_3_LINQ.Data;

using Console_App_3_LINQ.Models;

public static class SampleData
{
    public static List<int> Numbers => new()
    {
        10,20,30,40,50,60,70,80,90,100
    };

    public static List<int> DuplicateNumbers => new()
    {
        1,2,2,3,3,3,4,5,5,6,6,7,7
    };

    public static List<string> Names => new()
    {
        "John",
        "Jane",
        "Jack",
        "Jill",
        "James",
        "Jenny"
    };

    public static List<Employee> Employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "John",
            Age = 30,
            Department = "IT",
            Salary = 50000,
            Location = "Bangalore"
        },

        new Employee
        {
            Id = 2,
            Name = "Jane",
            Age = 25,
            Department = "HR",
            Salary = 40000,
            Location = "Hyderabad"
        },

        new Employee
        {
            Id = 3,
            Name = "Jack",
            Age = 35,
            Department = "Finance",
            Salary = 60000,
            Location = "Chennai"
        },

        new Employee
        {
            Id = 4,
            Name = "Jill",
            Age = 28,
            Department = "IT",
            Salary = 55000,
            Location = "Bangalore"
        },

        new Employee
        {
            Id = 5,
            Name = "James",
            Age = 32,
            Department = "HR",
            Salary = 45000,
            Location = "Hyderabad"
        },

        new Employee
        {
            Id = 6,
            Name = "Jenny",
            Age = 29,
            Department = "Finance",
            Salary = 65000,
            Location = "Chennai"
        }
    };

    public static List<Department> Departments = new()
    {
        new Department
        {
            Id = 1,
            Name = "IT",
            Location = "Bangalore"
        },

        new Department
        {
            Id = 2,
            Name = "HR",
            Location = "Hyderabad"
        },

        new Department
        {
            Id = 3,
            Name = "Finance",
            Location = "Chennai"
        },

        new Department
        {
            Id = 4,
            Name = "Marketing",
            Location = "Mumbai"
        }
    };

    public static List<Student> Students => new()
    {
        new Student
        {
            Id=1,
            Name="John",
            Marks=90,
            Subjects=new(){ "Math","Science"}
        },
        new Student
        {
            Id=2,
            Name="Alice",
            Marks=95,
            Subjects=new(){ "English","History"}
        }
    };

    public static List<Customer> Customers => new()
    {
        new Customer{ Id=1, Name="Alex", City="Delhi"},
        new Customer{ Id=2, Name="Bob", City="Mumbai"},
        new Customer{ Id=3, Name="Chris", City="Bangalore"}
    };

    public static List<Order> Orders => new()
    {
        new Order{ Id=1, CustomerId=1, Amount=2500, OrderDate=DateTime.Today.AddDays(-2)},
        new Order{ Id=2, CustomerId=1, Amount=1800, OrderDate=DateTime.Today.AddDays(-1)},
        new Order{ Id=3, CustomerId=2, Amount=5000, OrderDate=DateTime.Today},
        new Order{ Id=4, CustomerId=3, Amount=1200, OrderDate=DateTime.Today}
    };

    public static List<Product> Products => new()
    {
        new Product{ Id=1, Name="Laptop", Category="Electronics", Price=65000, Stock=10},
        new Product{ Id=2, Name="Phone", Category="Electronics", Price=35000, Stock=15},
        new Product{ Id=3, Name="Table", Category="Furniture", Price=7000, Stock=5},
        new Product{ Id=4, Name="Chair", Category="Furniture", Price=2500, Stock=20}
    };

    public static List<object> MixedData => new()
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
}