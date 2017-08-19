using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class Program
    {


        // we need to code an army that has Knights, Archers, and Wizards
        // Knights, Swing Swords, 
        // Archers, Shoot arrows, 
        // Wizards, of course shoot magic missile

        // I want to store my entire army in a data structure (organized our data to optimize usage)
        // so I can manipulate in any way that I want 

        static void Main(string[] args)
        {

            var lancelot = new Knight();

            var legalas = new Archer();

            var harry = new Wizard();

            var army = new List<Warrior>();
            army.Add(lancelot);
            army.Add(legalas);
            army.Add(harry);

            army.ForEach(fighter => fighter.Attack());


            // Console.WriteLine("Hello World!");
        }
    }
}
