namespace EmployeWageComputationProblem_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWage calculatesalary= new EmpWage();
            calculatesalary.CalculateSalary("Company1", 20,20,100);
            calculatesalary.CalculateSalary("Company2", 30, 18, 90);
        }
    }
}