using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
   public  class Dog:Animal
    {
        public Dog(string name, string colour, string gender, int age, int footNum, int handNum, double height, double weight, bool tail):base(name,colour,gender,age,footNum,handNum,height,weight,tail)
        {
            
        }
        public void Haf(string HafOBJ)
        {
            Console.WriteLine($"{_name} is barking on {HafOBJ}");
        }
    }
}
