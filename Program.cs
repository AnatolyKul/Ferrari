using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile Ferrari = new Automobile("Ferrari", "Red", "EVA 599XX", "530 km/h");
            Ferrari.name("Ferrari");
            Ferrari.color("Red");
            Ferrari.model("EVA 599XX");
            Ferrari.speed("530 km/h");
            Ferrari.move(Ferrari);
            Ferrari.stop(Ferrari);
        }
    }
}
