using System;

namespace Circus.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var circus = new Circus(5) //neuen Zirkus mit neuem Trainer anlegen
            {
                Name = "Zirkus Halligalli",
                Trainer = new Trainer { Name = "Anton" }
            };
            circus.AddAnimal(new Animal { Name = "Dumbo", Race = "Elefant" });  //Tiere anlegen und dem Zirkus hinzufügen
            circus.AddAnimal(new Animal { Name = "Donald", Race = "Ente" });
            circus.AddAnimal(new Animal { Name = "Kuzco", Race = "Lama" });
            circus.AddAnimal(new Animal { Name = "Goofy", Race = "Hund" });
            circus.AddAnimal(new Animal { Name = "Balu", Race = "Bär" });

            Console.WriteLine(circus); //siehe Circus.ToString()
        }
    }
}
