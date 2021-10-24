using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongManager.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[]
            {
                new Song("White Ferrari", "Frank Ocean", new TimeSpan(0, 4, 9)),
                new Song("Detach", "Hans Zimmer", new TimeSpan(0, 6, 42)),
                new Song("Troublemaker", "Beach House", new TimeSpan(0, 4, 9))
            };

            foreach (var song in songs)
                Console.WriteLine(song);

            //Alternativen:
            //for (var i = 0; i < 3; i++)
            //    Console.WriteLine(songs[i]);

            //Console.WriteLine(string.Join(Environment.NewLine, songs as object[]));

            Console.ReadLine();
        }
    }
}
