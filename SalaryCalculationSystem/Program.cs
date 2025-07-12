namespace SalaryCalculationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new()
            {
                new Manager
                {
                    Id = "1001",
                    Fname = "Ahmad",
                    Lname = "Hossam",
                    HourRate = 20.0m,
                    ExpectedHours = 50,
                    LoggedHours = 50,
                },
                new SalesAgent
                {
                    Id = "1002",
                    Fname = "Moaz",
                    Lname = "Mohamed",
                    HourRate = 10.0m,
                    ExpectedHours = 30,
                    LoggedHours = 45,
                    TotalSales = 30000
                },
                new HandyMan
                {
                    Id = "1003",
                    Fname = "adel",
                    Lname = "Emad",
                    HourRate = 7.5m,
                    ExpectedHours = 40,
                    LoggedHours = 60,
                },
                new SoftwareEngineer
                {
                    Id = "1004",
                    Fname = "Noureldin",
                    Lname = "Mohamed",
                    HourRate = 20.0m,
                    ExpectedHours = 40,
                    LoggedHours = 40,
                    StoryPointCompleted = 8
                }
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"-------- {employee.GetType().Name} ---------");
                Console.WriteLine(employee.ShowSalary());
                Console.WriteLine();
            }
        }
    }
}
