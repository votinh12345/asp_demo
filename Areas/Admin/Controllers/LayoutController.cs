using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hienv_asp.Models;
using hienv_asp.Context;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using CountryModel = hienv_asp.Models.Country;

namespace MVC_hiennv.Areas.Admin.Country.Controllers;
[Area("Admin")]
public class LayoutController : Controller
{

    private readonly ApplicationDbContext _context;

    private readonly ILogger<LayoutController> _logger;

    public LayoutController(ApplicationDbContext context, ILogger<LayoutController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var items = _context.Layout.ToList();
        return View(items);
    }
}
