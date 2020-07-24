using RentBooks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentBooks.DAL.Entities.Books;


namespace RentBooks.DAL
{
    public class BookDAL : BaseDAL
    {
        public List<BookDTO> GetBooks()
        {
            using (RentBooksEntities1 model = new RentBooksEntities1())
            {
                List<BookDTO> listBooks = (from r in model.Book
                                                   select new BookDTO()
                                                   {
                                                       IDBook = r.IDBook,
                                                       NMBook = r.NMBook,
                                                       NMAutor = r.NMAutor
                                                   }).ToList();

                return listBooks.OrderBy(r => r.NMBook).ToList();
            }
        }
    }
}