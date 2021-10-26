using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Cli
{
    internal class Toolbox
    {
        private uint containedTools = 0;
        //Generieren von Methode zur Rückgabe von Array mit Auto-Property
        internal Tool[] Contents { get; private set; }
        internal uint Count { get; set; }
        internal string Name { get; set; }

        internal void Add(Tool tool)
        {
            if (tool == null)
                return;
            if (containedTools >= Count)
                return;
            if (Contents == null && Count > 0)
                Contents = new Tool[Count];

            Contents[containedTools] = tool;
            containedTools++;
        }

        internal float GetTotalPrice()
        {
            if (Contents == null)
                return 0;

            var sum = 0F;
            foreach (var tool in Contents)
                sum += tool?.Price ?? 0;

            return sum;
        }
    }
}
