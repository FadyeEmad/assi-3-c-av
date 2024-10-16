using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    public class Book
    {
        #region Properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructor
        public Book(string _iSBN, string _title, string[] _authors, DateTime _publicationDate, decimal _price)
        {
            ISBN = _iSBN;
            Title = _title;
            Authors = _authors;
            PublicationDate = _publicationDate;
            Price = _price;

        }
        #endregion

        #region Override ToString

        public override string ToString()
        {
            string authors = string.Join(",", Authors);
            return $"ISBN = {ISBN} \nTitle = {Title} \nAuthors = {authors} \nPublicationDate {PublicationDate} \nPrice = {Price} ";
        }

        #endregion
    }
}