using System;

namespace Freighter.Cli
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var freighter = new Freighter("Columbus", "Helga", "Hong Kong", "Hamburg", 300);
            freighter.AddContainer(new Container("Teddybären", 40));
            freighter.AddContainer(new CoolingContainer("Bier", "Getränke", 10));
            freighter.AddContainer(new CoolingContainer("Fischstäbchen", "Tiefkühlprodukte"));
            freighter.AddContainer(new TankContainer("Helium", 20, 80, 600000, 10));
            freighter.AddContainer(new TankContainer("Luft", 20, 80, 600000, 10));
            freighter.WriteInfo();
        }
    }
}
