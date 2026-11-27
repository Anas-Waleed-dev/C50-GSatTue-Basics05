namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1.Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            //Book b1 = new Book();
            //Console.WriteLine(b1.password);//compilation error
            //// because access modifiers (private) Accessible only with in containing class.
            #endregion
            #region Question 2
            ////2.Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            //// Why ?
            //Book B2 = new Book();
            //Console.WriteLine(B2.CopiesInStock);//Run Successfully
            ////because accessModifiers (internal) Accessib

            #endregion

            #region Question 3
            ////3.Add a public string Title; field to Book. Set it and print it from Main.
            //Book b3 = new Book();
            //b3.Title = "C#";
            //Console.WriteLine(b3.Title);//run successfully.
            ////because the title is public 

            #endregion
            #region Question 4
            //4.Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it
            //Book book = new Book();
            //book.BookGenre = Genre.Science;
            //Console.WriteLine(book.BookGenre);

            #endregion

            #region Question 5
            //5.Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);


            #endregion
            #region Question 6
            //6.Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);
            #endregion

            #region Question 7
            //7.Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());

            #endregion
            #region Question 8
            //8.Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            //print the result.
            //string genreText = "Science";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre);

            #endregion
            #region Question 9
            //9.Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
            //attempt the conversion.Print "Unknown genre" if it fails.
            string genreText = "Mystery";
            if (Enum.TryParse<Genre>(genreText, out Genre genre))
            {
                Console.WriteLine(genre);
            }
            else
            {
                Console.WriteLine("UnKnown genre");
            }
            #endregion



        }
    }
}
