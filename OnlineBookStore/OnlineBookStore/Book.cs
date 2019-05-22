using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    class Book : Product
    {
        private string BookName;
        private string ISBN_number;
        private string author; //the author of the book
        private string publisher; //the publisher of the book
        private int page; //– the page number of the book
        private string type;
        public Book() { }

        private static Book instance;
        public static Book getInstance()
        {
            if (instance == null)
                instance = new Book();
            return instance;
        }

        public string Bookname
        {
            get
            {
                return BookName;
            }

            set
            {
                BookName = value;
            }
        }
        public string ISBN_Number
        {
            get
            {
                return ISBN_number;
            }

            set
            {
                ISBN_number = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                publisher = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
