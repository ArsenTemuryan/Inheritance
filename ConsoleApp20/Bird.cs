using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Bird : Animal
    {
        public Bird(string name, string colour, string gender, int age, int footNum, int handNum, double height, double weight, bool tail) : base(name, colour, gender, age, footNum, handNum, height, weight, tail)
        {

        }
        public Bird()
        {
            _name = "Violik";
            _colour = "rose";
            _gender = "female";
            _age = 18;
            _footNum = 2;
            _handNum = 2;
            _height = 50;
            _weight = 1.70;
            _tail = true;
        }
        public void Fly()
        {
            Console.WriteLine($"{_name} is flying");
        }
    }
}
