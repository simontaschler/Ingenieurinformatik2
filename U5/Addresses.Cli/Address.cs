using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addresses.Cli
{
    internal class Address
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Road { get; set; }
        internal int ZipCode { get; set; }
        internal string Town { get; set; }

        internal string FullName => 
            $"{FirstName} {LastName}";

        public override string ToString() =>
            $@"{FirstName} {LastName}:
    {Road}, {ZipCode} {Town}";
    }
}
