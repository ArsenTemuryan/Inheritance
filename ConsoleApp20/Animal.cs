using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Animal
    {
        public string _name;
        public string _colour;
        public string _gender;
        public int _age;
        public int _footNum;
        public int _handNum;
        public double _height;
        public double _weight;
        public bool _tail;
        public Animal(string name, string colour, string gender, int age, int footNum, int handNum, double height, double weight, bool tail)
        {
            _name = name;
            _colour = colour;
            _age = age;
            _footNum = footNum;
            _handNum = handNum;
            _gender = gender;
            _height = height;
            _weight = weight;


        }
        public Animal()
        {
                
        }
        public void Eat()
        {
            Console.WriteLine($"{_name} is etaing");
        }
        public void Sleep()
        {
            Console.WriteLine($"{_name} is sleeping");
        }
        public void Transport()
        {
            Console.WriteLine($"{_name} is transporting");
        }

    }
}
