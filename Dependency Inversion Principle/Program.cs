namespace OpenClosedDemo
{
    namespace DependencyInversionDemo
    {
        interface IbonusEmployee
        {
            public int CalculateBonus();
        }

        public abstract class Employee : IbonusEmployee
        {
            public int CalculateBonus()
            {
                return 1000;
            }

            public Employee()
            { }
        }
        public class PermanentEmployee : IbonusEmployee
        {
            public int CalculateBonus()
            {
                return 500;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                IbonusEmployee oleg = new PermanentEmployee();

                Console.WriteLine(oleg.CalculateBonus() + " долларов бонус у Олега");

                Console.ReadLine();
            }
        }
    }
}