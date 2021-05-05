using Microsoft.AspNetCore.Mvc;
using Monstros_SA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;
using X.PagedList;

namespace Monstros_SA.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly AppDBContext _db;

        public PersonagemController(AppDBContext db)
        {
            _db = db;
        }

        public IActionResult Index(int ? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 8;
            var onePageOfStudents = (_db.Personagens.ToPagedList(pageNumber, pageSize));
            return View(onePageOfStudents);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Personagem obj)

        {
            if (ModelState.IsValid) {

                _db.Personagens.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Update(int? id)

        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Personagens.Find(id);
            if (obj == null)
            {
                return NotFound();

            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Personagem obj)

        {
            if (ModelState.IsValid)
            {

                _db.Personagens.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Delete(int? id)

        {
           if(id == null || id==0)
            {
                return NotFound();
            }

            var obj = _db.Personagens.Find(id);
            if (obj == null)
            {
                return NotFound();

            }
            return View(obj);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)

        {

            var obj = _db.Personagens.Find(id);
            
            if (obj == null)
            {
                return NotFound();
            
            }
                _db.Personagens.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
              
        }

    }
}
