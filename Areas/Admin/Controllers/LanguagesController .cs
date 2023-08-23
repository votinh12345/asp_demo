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
public class LanguagesController : Controller
{

    private readonly ApplicationDbContext _context;

    private readonly ILogger<LanguagesController> _logger;

    public LanguagesController(ApplicationDbContext context, ILogger<LanguagesController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var items = _context.Language.ToList();
        return View(items);
    }

    // GET: Admin/Country/Create
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("name,code,locale,sort_order,status")] LanguageModel language)
    {
        if (ModelState.IsValid)
        {
            //Tạo Post
            var newpost = new LanguageModel()
            {
                name = language.name,
                code = language.code,
                locale = language.locale,
                image = "gb.png",
                directory = language.name.ToLower(),
                filename = language.name.ToLower(),
                sort_order = language.sort_order,
                status = language.status
            };
            _logger.LogInformation("Testing logging in Program.cs");
            try
            {

                _context.Add(newpost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (IOException ioException)
            {
               Console.WriteLine(ioException.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
            }
        }

        return View(language);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var post = await _context.Language.Where(p => p.language_id == id).FirstOrDefaultAsync();
        if (post == null)
        {
            return NotFound();
        }

        return View(post);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("name,code,locale,sort_order,status")] LanguageModel language)
    {
        if (id != language.language_id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            var languageUpdate = await _context.Language.Where(p => p.language_id == id).FirstOrDefaultAsync();
            if (languageUpdate == null)
            {
                return NotFound();
            }
            languageUpdate.name = language.name;
            languageUpdate.code = language.code;
            languageUpdate.locale = language.locale;
            languageUpdate.directory = language.name.ToLower();
            languageUpdate.filename = language.name.ToLower();
            languageUpdate.sort_order = language.sort_order;
            languageUpdate.status = language.status;
            try
            {

                _context.Update(languageUpdate);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return RedirectToAction(nameof(Index));
        }
        return View(language);
    }
}
