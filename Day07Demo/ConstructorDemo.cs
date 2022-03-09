using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07Demo
{
    public class Car
    {
        private int _x, _y;
        public Car(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Car()
        {

        }

        public void Display()
        {
            Console.WriteLine($"x,y={_x},{_y}");
        }
    }
    
    public class RacingCar : Car
    {
        ConsoleColor _color;
        public RacingCar(int x, int y, ConsoleColor color) : base(x, y)
        {
            _color = color;
        }
    }
}
