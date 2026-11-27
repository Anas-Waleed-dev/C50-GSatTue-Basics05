namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1.Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            Book b1 = new Book();
            Console.WriteLine(b1.password);//compilation error
            // because access modifiers (private) Accessible only with in containing class.
            #endregion


        }
    }
}
