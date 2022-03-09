// See https://aka.ms/new-console-template for more information
using Day07Demo;

Console.WriteLine("Hello, World!");
//Test1();
//Test2();

Demo.Test();


void Test2()
{
    Car c = new Car(10, 20);
    c.Display();

    RacingCar rc = new RacingCar(10, 20, ConsoleColor.Yellow);
    rc.Display();
}

void Test1()
{
    IEmployee emp1 = new Programmer();
    IEmployee emp2 = new SalesRep();

    emp1.CalculateInventive(15);
    emp1.GiveBonus(1000);
    emp1.ChangeTiming(1000);
    emp1.PrintSalarySlip();


    emp2.CalculateInventive(20);
    emp2.GiveBonus(2000);
    emp2.PrintSalarySlip();
}

