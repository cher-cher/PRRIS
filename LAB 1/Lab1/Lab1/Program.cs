using System;

namespace Lab1
{
    class Program
    {
        static void Main( string[] args )
        {
            string word1 = "day";
            string word2 = "Today";

            string text = "Today is very good a sunny day and tomorrow will be very good day too.";
            DistanceCalculator distanceCalculator = new DistanceCalculator( text, word1, word2 );
            Console.WriteLine( "Min distance = " + distanceCalculator.FindMinDistance() );
            Console.WriteLine( "Max distance = " + distanceCalculator.FindMaxDistance() );
        }
    }
}
