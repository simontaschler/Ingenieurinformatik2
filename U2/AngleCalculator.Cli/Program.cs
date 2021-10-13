using System;

namespace AngleCalculator.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            #region double
            {
                var hypotenuse = 10.0;
                var ankathete = 5.0;
                var cos = ankathete / hypotenuse;
                Console.WriteLine($"Double calculation: Enclosed Angle of {Math.Acos(cos)} rad");
                //Gibt Winkel von Pi/3 bzw. 30° aus
            }
            #endregion

            #region integer
            {
                var hypotenuse = 10;
                var ankathete = 5;
                var cos = ankathete / hypotenuse;
                Console.WriteLine($"Int calculation: Enclosed Angle of {Math.Acos(cos)} rad");
                //Gibt Winkel von Pi/2 bzw. 45° aus, weil cos = 0 (Verlust von Nachkommastellen durch int)
            }
            #endregion


        }
    }
}
