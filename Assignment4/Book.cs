using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    internal class Book
    {
        private string password = "secret";
        internal int CopiesInStock = 5;
        public string Title;
        public Genre BookGenre { get; set; }
    }
}
