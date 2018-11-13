using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Lab1.Tests
{
    [TestClass]
    public class DistanceCalculatorTests
    {
        [TestMethod]
        public void DistanceCalculator_FindMinDistance_Success()
        {
            //ARRANGE
            string word1 = "day";
            string word2 = "Today";

            string text = "Today is very good a sunny day and tomorrow will be very good day too.";
            DistanceCalculator distanceCalculator = new DistanceCalculator( text, word1, word2 );
            //ACT
            int result = distanceCalculator.FindMinDistance();
            //ASSERT
            Assert.AreEqual( 5, result );
        }

        [TestMethod]
        public void DistanceCalculator_FindMaxDistance_Success()
        {
            //ARRANGE
            string word1 = "day";
            string word2 = "Today";

            string text = "Today is very good a sunny day and tomorrow will be very good day too.";
            DistanceCalculator distanceCalculator = new DistanceCalculator( text, word1, word2 );
            //ACT
            int result = distanceCalculator.FindMaxDistance();
            //ASSERT
            Assert.AreEqual( 12, result );
        }

        [TestMethod]
        public void DistanceCalculator_FindMaxDistance_NotFind()
        {
            //ARRANGE
            string word1 = "Day";
            string word2 = "today";

            string text = "Today is very good a sunny day and tomorrow will be very good day too.";
            DistanceCalculator distanceCalculator = new DistanceCalculator( text, word1, word2 );
            //ACT
            int minResult = distanceCalculator.FindMinDistance();
            int maxResult = distanceCalculator.FindMaxDistance();
            //ASSERT
            Assert.AreEqual( 2147483646, minResult );
            Assert.AreEqual( -1, maxResult );
        }
    }
}