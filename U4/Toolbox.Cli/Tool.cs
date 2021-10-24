using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Cli
{
    internal class Tool
    {
        //MSBuild erstellt bei Properties automatisch im Hintergrund Getter- und Setter-Methoden
        //z.B. internal string get_Name() bzw. internal void set_Name(string value)
        //wenn diese Methoden nicht überschrieben werden, wird auch privates Feld angelegt, das den Wert speichert
        internal string Name { get; set; }
        internal float Price { get; set; }
    }
}
