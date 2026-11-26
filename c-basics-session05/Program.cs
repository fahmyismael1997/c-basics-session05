using System.Net.Sockets;

namespace c_basics_session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Add a private string password = "secret"; field to a Book class. Try to print it from Main 
            (outside the class). What happens, and why? */

            Book book = new Book();
            Console.WriteLine(book.Password);//this compiler Error , cannot Access a private member to fix it make password public
            #endregion
        }
    }
}
