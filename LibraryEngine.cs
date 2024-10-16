using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    #region User Defined Delegate 
    public delegate string BookDelegate(Book book);
    #endregion
    public class LibraryEngine
    {
        #region a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

        public static void ProcessBooks(List<Book> books, BookDelegate fPtr)
        {
            foreach (var book in books)
                Console.WriteLine(fPtr(book));
        }
        #endregion

        #region b)Use the Proper built in delegate. 

        public static void ProcessBooks2(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var book in books)
                Console.WriteLine(fPtr(book));
        }

        #endregion
    }
}