using System;
using System.Collections.Generic;
using System.Text;

namespace c_basics_session05
{

    #region Question 1
    /*1-Add a private string password = "secret"; field to a Book class. Try to print it from Main 
      (outside the class). What happens, and why? */
    #endregion
    internal class Book
    {
        private string Password = "secret";
        internal int copiesInStock = 5 ;
    }
}
