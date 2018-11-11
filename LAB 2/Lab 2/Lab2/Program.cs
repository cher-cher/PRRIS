using System;

namespace Lab2
{
    class Program
    {
        static void Main( string[] args )
        {
            var notebook = new NoteBook();
            string inputString = String.Empty;
            Console.WriteLine( GetHelp() );
            while ( ( inputString = Console.ReadLine() ) != "exit" )
            {
                string[] inputNote = inputString.Split();
                if ( inputNote.Length != 2 )
                {
                    Console.WriteLine( GetHelp() );
                }
                else
                {
                    if ( inputNote[ 0 ].ToLower() == "add" )
                    {
                        notebook.Add( inputNote[ 1 ] );
                    }
                    else if ( inputNote[ 0 ].ToLower() == "find" )
                    {
                        var foundCount = notebook.Find( inputNote[ 1 ] );
                        Console.WriteLine( foundCount );
                    }
                }
            }
        }

        private static string GetHelp()
        {
            return "To add user write \"Add <name>\", to find count write \"Find <name>\". To exit write \"Exit\"";
        }
    }
}
