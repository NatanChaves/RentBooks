using RentBooks.BLL;
using RentBooks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentBooks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ListBooksDTO listBooks = new ListBooksDTO();

            using (BookBLL oBoBLL = new BookBLL())
            {
                listBooks = oBoBLL.GetBooks();
            }
            return View("Index", listBooks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}