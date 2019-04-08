using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        ComicBookRepository comicBookRepository = new ComicBookRepository();

        public ActionResult Detail()
        {
            var comicBook = comicBookRepository.GetComicBook();
            return View(comicBook);
        }

    }
}