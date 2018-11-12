using System.Collections.Generic;

namespace Lab2
{
    public class NoteBook
    {
        private HashSet<string> _notebook;

        public NoteBook()
        {
            _notebook = new HashSet<string>();
        }

        public void Add( string value )
        {
            _notebook.Add( value );
        }

        public int Find( string value )
        {
            int result = 0;
            foreach ( string note in _notebook )
            {
                if ( note.StartsWith( value ) )
                {
                    result++;
                }
            }

            return result;
        }
    }
}