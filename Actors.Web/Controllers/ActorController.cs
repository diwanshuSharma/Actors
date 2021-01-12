using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Actors.Business;
using Actors.Data;

namespace Actors.Web.Controllers
{
    public class ActorController : Controller
    {
        IActorManager mgr = new ActorManager();


        // GET: Actor
        public ActionResult Index()
        {
            var actors = mgr.GetActors();
            return View(actors);
        }

        [HttpGet]
        public ActionResult ActorDisplay()
        {
            ViewBag.name = mgr.GetActors().Select(x => x.Name);
            return View();
        }

        [HttpPost]
        public ActionResult ActorDisplay(int id)
        {
            return View();
        }

        public ActionResult AddNewMovie(int id)
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Actor actor)
        {
            string filename = Path.GetFileNameWithoutExtension(actor.ImageFile.FileName);
            string extension = Path.GetExtension(actor.ImageFile.FileName);
            filename = filename + extension;

            // saving Image
            var savefilename = Path.Combine(Server.MapPath("~/Image/"), filename);
            actor.ImageFile.SaveAs(savefilename);

            filename = "~/Image/" + filename;

            mgr.AddActor(actor, filename);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var actor = mgr.GetActorById(id);
            return View(actor);
        }

        public ActionResult AddMovie(int id)
        {
            ViewBag.ActorId = id;
            return View("AddMovie");
        }

        public ActionResult AddMovieWithActor(int ActorId, Movie movie)
        {
            mgr.AddMovieToActor(ActorId, movie);
            return RedirectToAction("Details", new { id = ActorId });
        }
    }
}