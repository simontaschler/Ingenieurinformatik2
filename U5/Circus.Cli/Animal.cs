using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus.Cli
{
    internal class Animal
    {
        internal string Name { get; set; }
        internal string Race { get; set; }

        public override string ToString() => 
            $"\t{Race} {Name}";
    }
}
