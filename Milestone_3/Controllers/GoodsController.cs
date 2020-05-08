﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milestone_3.Models;
using Milestone_3.Models.Goods;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using System.IO;
using Milestone_3.Services;

namespace Milestone_3.Controllers { 
    public class GoodsController : Controller
    {
        private readonly GoodsService _goodService;

        public GoodsController(GoodsService goodService)
        {
            _goodService = goodService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _goodService.GetGoods();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Good good)
        {

            await _goodService.AddAndSave(good);

            var goods = await _goodService.GetGoods();

            return View("Index", goods);
        }


        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Good good)
        {

            await _goodService.Save(good);

            var goods = await _goodService.GetGoods();

            return View("Index", goods);
        }


        public async Task<IActionResult> Search(string text)
        {
            var searchedGoods = await _goodService.Search(text);
            return View("Index", searchedGoods);
        }


    }
}