using System;
using System.Collections.Generic;

namespace RealEstate.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var realEstates = new List<RealEstate> //Liste an Immobilien anlegen
            {
                new House
                {
                    Address = "Kopernikusgasse 12",
                    Rent = 2400
                },
                new Apartment
                { 
                    Address = "Münzgrabenstraße 10",
                    Rent = 1600
                },
                new Apartment
                {
                    Address = "Petersgasse 16",
                    Rent = 1800
                }
            };

            var tenants = new List<Tenant> //8 Mieter anlegen
            {
                new Tenant { Name = "Max",      Age = 22 },
                new Tenant { Name = "Maria",    Age = 26 },
                new Tenant { Name = "Manfred",  Age = 21 },
                new Tenant { Name = "Lea",      Age = 19 },
                new Tenant { Name = "Alex",     Age = 28 },
                new Tenant { Name = "Lisa",     Age = 20 },
                new Tenant { Name = "Stefan",   Age = 22 },
                new Tenant { Name = "Markus",   Age = 23 }
            };

            var i = 0;
            foreach (var realEstate in realEstates) //Jede Immobilie wird der Reihe nach mit Mietern voll gemacht und anschließend ausgegeben
            {
                while (i < tenants.Count && realEstate.AddTenant(tenants[i])) 
                //Falls nicht bereits alle Mieter zugewiesen wurden, wird versucht diese zur aktuellen Immobilie hinzuzufügen
                //Wenn kein Platz mehr ist wird durch false-Rückgabe von AddTenant While-Schleife verlassen und bei der nächsten Immobilie hinzugefügt
                    i++;
                Console.WriteLine(realEstate);
            }
        }
    }
}
