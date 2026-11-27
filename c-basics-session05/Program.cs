using System.Net.Sockets;

namespace c_basics_session05
{
    
    internal enum Genre
    {
        Fiction, NonFiction, Science
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Add a private string password = "secret"; field to a Book class. Try to print it from Main 
            (outside the class). What happens, and why? */

            Book book = new Book();
            //Console.WriteLine(book.Password);//this compiler Error , cannot Access a private member to fix it make password public
            #endregion

            #region Question 2
            /*2-Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? 
            Why?*/

            // Console.WriteLine(book.copiesInStock);//yes , internal access modifer can see and change it from this project (Assamply)
            #endregion

            #region Question 3
            /*3-Add a public string Title; field to Book. Set it and print it from Main.*/

            //book.Title = "Clean code";
            //Console.WriteLine(book.Title);
            #endregion

            #region Question 4
            /*4-Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, 
              assign it Genre.Science, and print it.*/

            //book.Property = Genre.Science;
            //Console.WriteLine(book.Property);
            #endregion

            #region Question 5
            /*5-Using the Genre enum above, print the underlying int value of 
              Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int. */

            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion

            #region Question 6
            /*6-Given int genreNumber = 1;, cast it into a Genre value and print the result.*/
            int genreNumber = 1;
            Console.WriteLine((Genre)genreNumber);
            #endregion





        }
    }
}
