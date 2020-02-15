using System;

namespace Rabitt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit bunny = new Rabbit(Rabbit.FurColors.Grey, Rabbit.EyeColors.Black, Rabbit.Gender.Female);
            Console.WriteLine(bunny.Age);
        }
    }
}
