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
using LanguageModel = hienv_asp.Models.Language;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace MVC_hiennv.Areas.Admin.Languages.Controllers;
[Area("Admin")]
public class StoreController : Controller
{

    private readonly ApplicationDbContext _context;

    private readonly ILogger<StoreController> _logger;

    public StoreController(ApplicationDbContext context, ILogger<StoreController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var items = _context.Store.ToList();
        return View(items);
    }
}
