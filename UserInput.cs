using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now that I've said hello to the world, let's introduce ourselves. I'm Syed, you must be..");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hi " + name + ", it's nice meeting you!");

        }
    }
}
