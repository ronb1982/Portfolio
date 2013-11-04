using System.Web.Mvc;
using MVCPortfolio.Models.FakeDatabase;
using SWCGuild.FakeDatabase;

namespace MVCPortfolio.Controllers.FakeDatabase
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        public ActionResult Index()
        {
            var repo = RepositoryFactory.GetRepository();
            var books = repo.GetAll<Book>();
            return View(books);
        }

        public ActionResult Create()
        {
            return View(new Book());
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                var repo = RepositoryFactory.GetRepository();

                repo.Add(book);

                // this will tell the browser to request the Index action, so that method will run, this is different than return View("Index")
                // because if we do that, we would have to pass the books model (it doesn't actually run index, it just returns the view) so
                // RedirectToAction is handy when you just want the whole action to run.
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }

        public ActionResult Edit(int id)
        {
            var repo = RepositoryFactory.GetRepository();
            var book = repo.Get<Book>(id);

            return View(book);
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                var repo = RepositoryFactory.GetRepository();
                repo.Update(book);

                // this will tell the browser to request the Index action, so that method will run, this is different than return View("Index")
                // because if we do that, we would have to pass the books model (it doesn't actually run index, it just returns the view) so
                // RedirectToAction is handy when you just want the whole action to run.
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }

        public ActionResult Delete(int id)
        {
            var repo = RepositoryFactory.GetRepository();
            var book = repo.Get<Book>(id);

            return View(book);
        }

        [HttpPost]
        public ActionResult DeleteBook(int id)
        {
            var repo = RepositoryFactory.GetRepository();
            repo.Remove<Book>(id);

            return RedirectToAction("Index");
        }
    }
}
