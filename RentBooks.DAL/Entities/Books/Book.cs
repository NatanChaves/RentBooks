//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentBooks.DAL.Entities.Books
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int IDBook { get; set; }
        public string NMBook { get; set; }
        public string NMAutor { get; set; }
        public string DSResumo { get; set; }
        public Nullable<System.DateTime> DTPublicacao { get; set; }
        public string DSISBN { get; set; }
        public string DSEditora { get; set; }
        public Nullable<int> IDCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}
