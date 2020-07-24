using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBooks.DTO
{
    public class ListBooksDTO
    {

        public List<BookDTO> books{ get; set; }

        #region Construtores

        public ListBooksDTO()
        {
            books = new List<BookDTO>();
        }
        #endregion
    }
}