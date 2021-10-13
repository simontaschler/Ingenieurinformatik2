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
            }
            #endregion

            #region integer
            {
                var hypotenuse = 10;
                var ankathete = 5;
                var cos = ankathete / hypotenuse;
                Console.WriteLine($"Int calculation: Enclosed Angle of {Math.Acos(cos)} rad");
            }
            #endregion
        }
    }
}
