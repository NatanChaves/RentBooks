using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBooks.DTO
{
    public class BookDTO
    {
        #region Propriedades
        public int IDBook { get; set; }
        public string NMBook { get; set; }
        public string NMAutor { get; set; }
        public string DSResumo { get; set; }
        public string DSEditora { get; set; }
        public int DSISBN { get; set; }
        public int IDCategoria { get; set; }
        public List<BookDTO> listBooks { get; set; }
        #endregion

        #region Construtores

        public BookDTO()
        { }
        #endregion

        #region Métodos

        #endregion

    }
}