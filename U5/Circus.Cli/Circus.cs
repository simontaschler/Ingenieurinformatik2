using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus.Cli
{
    internal class Circus
    {
        private Animal[] _animals;
        private int nextIndex = 0;

        internal Trainer Trainer { get; set; }
        internal string Name { get; set; }

        internal Circus(int numAnimals) =>
            _animals = new Animal[numAnimals];

        internal void AddAnimal(Animal animal) 
        {
            if (animal == null)
                return;

            if (nextIndex >= _animals.Length) 
            {
                Console.WriteLine("Kein Platz mehr.");
                return;
            }

            _animals[nextIndex] = animal;
            nextIndex++;
        }

        public override string ToString() =>
            $@"-------------{Name}-------------
Trainer: {Trainer}
Tiere:
{string.Join(Environment.NewLine, _animals as object[])}";

        //public override string ToString()
        //{
        //    var sb = new StringBuilder().AppendLine($"-------------{Name}-------------");
        //    sb.AppendLine($"Trainer: {Trainer}").AppendLine("Tiere:");
        //    foreach (var animal in _animals)
        //        sb.AppendLine(animal.ToString());
        //    return sb.ToString();
        //}
    }
}
