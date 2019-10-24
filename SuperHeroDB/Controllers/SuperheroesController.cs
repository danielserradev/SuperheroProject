using SuperHeroDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroDB.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext context;
        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            return View(context.Superheroes.ToList());
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();

            return View(superhero);
            
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero editedSuperhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
                //context.Superheroes.Add(superhero);
                editedSuperhero.Id = superhero.Id;
                editedSuperhero.name = superhero.name;
                editedSuperhero.alterEgo = superhero.alterEgo;
                editedSuperhero.primarySuperheroAbility = superhero.primarySuperheroAbility;
                editedSuperhero.secondarySuperheroAbility = superhero.secondarySuperheroAbility;
                editedSuperhero.catchphrase = superhero.catchphrase;
                
                context.SaveChanges(); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                Superhero deletedSuperhero = context.Superheroes.Where(s => s.Id == id).FirstOrDefault();
                context.Superheroes.Remove(deletedSuperhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
