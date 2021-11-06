using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus.Cli
{
    internal class Trainer
    {
        internal string Name { get; set; }

        public override string ToString() => 
            Name;
    }
}
