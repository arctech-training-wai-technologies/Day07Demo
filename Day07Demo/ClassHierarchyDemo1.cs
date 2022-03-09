using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Demo
{
    public interface IEmployee
    {
        public void CalculateInventive(float percentage);
        public void GiveBonus(double bonus);
        public void ChangeTiming(int hours);

        public void PrintSalarySlip();
    }

    public abstract class Employee : IEmployee
    {
        protected double salary;
        protected int startHour, endHour;

        public Employee()
        {
            startHour = 10;
            endHour = 18;
            salary = 10000;
        }

        public abstract void CalculateInventive(float percentage);
        public abstract void GiveBonus(double bonus);

        public void ChangeTiming(int hours)
        {
            startHour += hours;
            endHour += hours;
        }

        public void PrintSalarySlip()
        {
            Console.WriteLine($"Salary = {salary}, Work Timings = {startHour}:00 - {endHour}:00");
        }
    }

    public class Programmer : Employee
    {
        public override void CalculateInventive(float percentage)
        {
        }

        public override void GiveBonus(double bonus)
        {
            salary += bonus;
        }
    }

    public class SalesRep : Employee
    {
        public override void CalculateInventive(float percentage)
        {
            salary += salary * percentage / 100;
        }

        public override void GiveBonus(double bonus)
        {
            if (salary > 1000000)
                salary += (bonus * 2);
            else
                salary += bonus;
        }
    }

}
