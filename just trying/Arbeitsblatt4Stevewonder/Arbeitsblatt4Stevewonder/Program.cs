 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsblatt4Stevewonder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Einheitsmatrix = new int[5, 5];
            int x = 0;
            int y = 0;
            
            //Schleife zum befüllen der Matrix. alternativ auch mit zwei Schleifen (Spalten und Zeilen möglich)
            while (y <= 4)
            {
                
                
                    if (x == y)
                    {
                        Einheitsmatrix[x, y] = 1;
                        Console.WriteLine(Einheitsmatrix[x, y]);
                    }
                    else
                    {
                        Einheitsmatrix[x, y] = 0;
                    }

                    if (x < 4)
                    {
                        x++;
                    }
                    else
                    {
                        x = 0;
                        y++;
                    }

             
            }
            
          
            
            
            
            Console.ReadLine(); 
        }
    }
}
