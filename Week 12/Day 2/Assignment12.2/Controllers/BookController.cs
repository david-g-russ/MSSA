using Microsoft.AspNetCore.Mvc;
using Assignment12._2.Models;

namespace Assignment12._2.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _tempRepository;

        public BookController(IBookRepository tempRepository)
        {
            _tempRepository = tempRepository;
        }

        public IActionResult Index()
        {
            BookGallery bookGallery = new BookGallery();
            bookGallery.Books = _tempRepository.InitializeBooks();
            return View(bookGallery);
        }

        public IActionResult Details(int? isbn)
        {
            var model = _tempRepository.GetBook(isbn);
            if (model == null)
                return NotFound();
            return View(model);
        }
    }
}