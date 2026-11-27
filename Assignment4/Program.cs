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
            Book b3 = new Book();
            b3.Title = "C#";
            Console.WriteLine(b3.Title);//run successfully.
            //because the title is public 

            #endregion


        }
    }
}
