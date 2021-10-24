using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var toolbox = new Toolbox
            {
                Name = "Werkzeugkasten",
                Count = 4
            };

            toolbox.Add(new Tool
            {
                Name = "Hammer",
                Price = 16.90F
            });
            toolbox.Add(new Tool
            {
                Name = "Schraubenzieher",
                Price = 14.90F
            });
            toolbox.Add(new Tool
            {
                Name = "Zange",
                Price = 19.90F
            });
            toolbox.Add(new Tool
            {
                Name = "Akkuschrauber",
                Price = 49.90F
            });

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Gesamtpreis: {toolbox.GetTotalPrice():C2}");
            Console.ReadLine();
        }
    }
}
