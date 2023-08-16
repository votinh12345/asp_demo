using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hienv_asp.Models;
using hienv_asp.Context;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;


namespace MVC_hiennv.Areas.Admin.Country.Controllers;
[Area("Admin")]
public class CountryController : Controller
{
    
    private readonly ApplicationDbContext _context;

    private readonly ILogger<CountryController> _logger;

    public CountryController(ApplicationDbContext context, ILogger<CountryController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var items = _context.Country.ToList();
        return View(items);
    }

    public IActionResult Create()
    {
        return View();
    }
}
