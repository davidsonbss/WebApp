﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            IEnumerable<Seller> listSellers = _sellerService.FindAll();


            return View(listSellers);
        }
    }
}
