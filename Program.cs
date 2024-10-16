
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("1", "C#", new []{"mohamed","ahmed","alaa"}, DateTime.Now,20),
                new Book("2", "OOP", new []{"mohamed","ahmed","alaa"}, DateTime.Now,30),
                new Book("3", "LINQ", new []{"mohamed","ahmed","alaa"}, DateTime.Now,40),
            };



            #region a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.

            //BookDelegate title = BookFunctions.GetTitle;
            //BookDelegate authors = BookFunctions.GetAuthors;
            //BookDelegate price = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBooks(books, price);

            #endregion

            #region b)Use the Proper build in delegate.

            // Func<Book, string> func = BookFunctions.GetTitle;
            // LibraryEngine.ProcessBooks2(books, func);

            #endregion

            #region c) Anonymous Method(GetISBN)

            // LibraryEngine.ProcessBooks2(books, delegate (Book b) { return b.ISBN; });
            #endregion

            #region d)Lambda Expression (GetPublicationDate)

            // LibraryEngine.ProcessBooks2(books, b => $"Publication Date : {b.PublicationDate}");
            #endregion
        }
    }
