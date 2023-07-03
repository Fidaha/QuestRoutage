using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuestRoutage.Controllers
{
    public class HelloController : Controller
    {


        // Itinéraire par attribut
        [Route("/Say")] // The endpoint here is reached by calling `/Say` route
        public String SayHello()
        {
            return "Hello !";
        }

        [Route("/Yell")] // The endpoint here is reached by calling `/Yell` route
        public String YellHello()
        {
            return "HELLO !";
        }


        // Itinéraire conventionnel 
        public String SayHello1()
        {
            return "Hello !";
        }

        public String YellHello1()
        {
            return "HELLO !";
        }





        // GET: HelloController
        public ActionResult Index()
        {
            return View();
        }




        /*
        // GET: HelloController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } */
    }
}
