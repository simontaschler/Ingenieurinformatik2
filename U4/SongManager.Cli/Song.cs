using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongManager.Cli
{
    internal class Song
    {
        internal string Name { get; set; }
        internal string Artist { get; set; }
        internal TimeSpan Length { get; set; }

        public Song(string name, string artist, TimeSpan length)
        {
            Name = name;
            Artist = artist;
            Length = length;
        }

        public override string ToString() => 
            $"Name:   {Name}\nArtist: {Artist}\nLength: {Length:%m\\:ss}\n";
    }
}
