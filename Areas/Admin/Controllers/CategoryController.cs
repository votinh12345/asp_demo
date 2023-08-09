using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hienv_asp.Models;
using hienv_asp.Context;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_hiennv.Areas.Admin.Category.Controllers;
[Area("Admin")]
public class CategoryController : Controller
{
    
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var items = _context.Categories.ToList();
        return View(items);
    }

    public async Task<IActionResult> Create()
    {
        
        return View();
    }
}
