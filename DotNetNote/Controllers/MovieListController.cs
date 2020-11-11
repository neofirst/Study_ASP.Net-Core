﻿using System;
using System.Collections.Generic;
using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetNote.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult Index()
        {
            List<MovieViewModel> vms = new List<MovieViewModel>()
            {
                new MovieViewModel{Id=1, Title="1", CreationDate = new DateTime(2014,1,1)},
                new MovieViewModel{Id=2, Title="2", CreationDate = new DateTime(2013,1,1)},
                new MovieViewModel{Id=3, Title="3", CreationDate = new DateTime(2015,1,1)}
            };
            return View(vms);
        }
    }
}
