using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace Lab2Tests
{
    [TestClass]
    public class NoteBookTests
    {
        [TestMethod]
        public void NoteBook_Find_FindAlex_Count3()
        {
            //ARRANGE
            NoteBook noteBook = new NoteBook();
            noteBook.Add("alex");
            noteBook.Add("alexey");
            noteBook.Add("alexander");
            //ACT
            int result = noteBook.Find( "alex" );
            //ASSERT
            Assert.AreEqual( 3, result );
        }

        [TestMethod]
        public void NoteBook_Find_FindAlexIfNotExist_Count0()
        {
            //ARRANGE
            NoteBook noteBook = new NoteBook();
            noteBook.Add( "anton" );
            noteBook.Add( "andrey" );
            noteBook.Add( "anna" );
            //ACT
            int result = noteBook.Find( "alex" );
            //ASSERT
            Assert.AreEqual( 0, result );
        }

        [TestMethod]
        public void NoteBook_Find_FindAnna_Count2()
        {
            //ARRANGE
            NoteBook noteBook = new NoteBook();
            noteBook.Add( "anton" );
            noteBook.Add( "andrey" );
            noteBook.Add( "ksusha" );
            noteBook.Add( "masha" );
            noteBook.Add( "annaanna" );
            noteBook.Add( "sasha" );
            noteBook.Add( "nastya" );
            noteBook.Add( "kirill" );
            noteBook.Add( "anna" );
            noteBook.Add( "alex" );
            noteBook.Add( "alexey" );
            noteBook.Add( "alexander" );
            noteBook.Add( "maks" );
            noteBook.Add( "maksim" );
            noteBook.Add( "igor" );
            //ACT
            int result = noteBook.Find( "anna" );
            //ASSERT
            Assert.AreEqual( 2, result );
        }
    }
}