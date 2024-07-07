using DemoLibrarySol;

namespace Solution
{
    public class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Emma";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.WriteLine();

            IManager emp2 = new CEO();

            emp2.FirstName = "Base";
            emp2.LastName = "Corey";
            emp2.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp2.FirstName }'s salary is ${ emp2.Salary }/hour.");

            Console.ReadLine();

        }
    }
}