using System;
using rpg_dio.src.Entities;

namespace rpg_dio // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

        }
    }
}