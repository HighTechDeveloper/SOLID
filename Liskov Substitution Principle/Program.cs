namespace LiskovDemo
{
    public abstract class Employee
    {
        public abstract int CalculateBonus();

        public Employee()
        { }
    }
    public class PermanentEmployee : Employee
    {
        public override int CalculateBonus()
        {
            return 1000;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override int CalculateBonus()
        {
            return 500;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee oleg = new TemporaryEmployee();

            Console.WriteLine(oleg.CalculateBonus() + " долларов бонус у Олега");

            Console.ReadLine();
        }
    }
}