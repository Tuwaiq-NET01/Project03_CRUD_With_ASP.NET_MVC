﻿using Cat_Adoption.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cat_Adoption.Controllers
{
    public class CatsController : Controller
    {
        private AppDbContext _db;
        public CatsController(AppDbContext context)
        {
            _db = context;
        }



        public IActionResult Index()
        {
            ViewData["Cats"] = _db.cat.ToList();
            Console.WriteLine("Hey Yo");
            foreach (var item in _db.cat.ToList())
            {
                Console.WriteLine(item.name);
                Console.WriteLine("Hey booo");
            }
            
             
            return View();
        }
        public IActionResult Details(int id)
        {
            var cat = _db.cat.Where(c => c.id == id).ToList().First();
            var owner = _db.owner.Where(o => o.id == cat.OwnerId).ToList().First();
            var location = _db.location.Where(l => l.id == cat.LocationId).ToList().First();
            ViewData["Cat"] = cat;
            ViewData["Owner"] = owner;
            ViewData["Location"] = location;
            return View();
        }
    }
}
