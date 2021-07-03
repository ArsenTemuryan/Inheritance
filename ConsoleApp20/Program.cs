using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Jeko", "black", "male", 2, 4,0, 80.5, 40, true);
            dog.Sleep();
            dog.Transport();
            dog.Haf("Cat");
            Bird bird = new Bird();
            bird.Fly();
        }
    }
}
