using OpenClosedDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo
{
    public class Employee
    {
        public int Bonus { get; set; }
        public Employee()
        { }
    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
            this.Bonus = 1000;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {
            this.Bonus = 500;
        }
    }

    public class Trainee : Employee
    {
        public Trainee()
        {
            this.Bonus = 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trainee oleg = new Trainee();

            Console.WriteLine(oleg.Bonus + " долларов бонус у Олега");

            Console.ReadLine();
        }
    }
}