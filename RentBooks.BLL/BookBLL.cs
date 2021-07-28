using RentBooks.DAL;
using RentBooks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBooks.BLL
{
    public class BookBLL : BaseBLL
    {
        public ListBooksDTO GetBooks()
        {
            ListBooksDTO listBooks = new ListBooksDTO();

            using (BookDAL oBokDAL = new BookDAL())
            {
                listBooks.books = oBokDAL.GetBooks();


                return listBooks;
            }
        }

    }
}