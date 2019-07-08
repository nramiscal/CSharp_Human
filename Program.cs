using System;

namespace Human
{

    class Program
    {
        static void Main(string[] args)
        {
            Human hooman = new Human();
            Human natalie = new Human("Natalie");
            Human sally = new Human("Sally");

            System.Console.WriteLine(hooman.Health);

            natalie.Attack(sally);
        }
    }
}
