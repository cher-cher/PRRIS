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
        private List<int> _positionsWord1 = new List<int>();
        private List<int> _positionsWord2 = new List<int>();

        public DistanceCalculator( string text, string word1, string word2 )
        {
            _word1 = word1;
            _word2 = word2;
            _text = text.Split().ToList();
            FillWordsPosition();
        }

        public int FindMinDistance()
        {
            int result = Int32.MaxValue;
            if ( _positionsWord1.Count > 0 && _positionsWord2.Count > 0 )
            {
                foreach ( var positionWord1 in _positionsWord1 )
                {
                    foreach ( var positionWord2 in _positionsWord2 )
                    {
                        int distance = Math.Abs( positionWord2 - positionWord1 );
                        if ( distance < result )
                        {
                            result = distance;
                        }
                    }
                }

                return result - 1;
            }

            return -1;
        }

        public int FindMaxDistance()
        {
            if ( _positionsWord1.Count > 0 && _positionsWord2.Count > 0 )
            {
                return Math.Max(
                           Math.Abs( _positionsWord1.Min() - _positionsWord2.Max() ),
                           Math.Abs( _positionsWord2.Min() - _positionsWord1.Max() ) ) - 1;
            }

            return -1;
        }

        private void FillWordsPosition()
        {
            for ( int i = 0; i < _text.Count; i++ )
            {
                if ( _text[ i ] == _word1 )
                {
                    _positionsWord1.Add( i );
                }

                if ( _text[ i ] == _word2 )
                {
                    _positionsWord2.Add( i );
                }
            }
        }
    }
}