using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class DistanceCalculator
    {
        private string _word1;
        private string _word2;
        private List<string> _text;

        public DistanceCalculator( string text, string word1, string word2 )
        {
            _word1 = word1;
            _word2 = word2;
            _text = text.Split().ToList();
        }

        public int FindMinDistance()
        {
            int minDistance = Int32.MaxValue;
            int lastPosWord1 = -1;
            int lastPosWord2 = -1;
            for ( int i = 0; i < _text.Count; i++ )
            {
                string currentWord = _text[ i ];
                if ( currentWord == _word1 )
                {
                    lastPosWord1 = i;
                    int distance = lastPosWord1 - lastPosWord2;
                    if ( lastPosWord2 >= 0 && minDistance > distance )
                    {
                        minDistance = distance;
                    }
                }
                else if ( currentWord == _word2 )
                {
                    lastPosWord2 = i;
                    int distance = lastPosWord2 - lastPosWord1;
                    if ( lastPosWord1 >= 0 && minDistance > distance )
                    {
                        minDistance = distance;
                    }
                }
            }

            return minDistance - 1;
        }

        public int FindMaxDistance()
        {
            List<int> positionsWord1 = new List<int>();
            List<int> positionsWord2 = new List<int>();
            FillWordsPosition( positionsWord1, positionsWord2 );
            if ( positionsWord1.Count > 0 && positionsWord2.Count > 0 )
            {
                return Math.Max(
                           Math.Abs( positionsWord1.Min() - positionsWord2.Max() ),
                           Math.Abs( positionsWord2.Min() - positionsWord1.Max() ) ) - 1;
            }

            return -1;
        }

        private void FillWordsPosition( List<int> positionsWord1, List<int> positionsWord2 )
        {
            for ( int i = 0; i < _text.Count; i++ )
            {
                if ( _text[ i ] == _word1 )
                {
                    positionsWord1.Add( i );
                }

                if ( _text[ i ] == _word2 )
                {
                    positionsWord2.Add( i );
                }
            }
        }
    }
}