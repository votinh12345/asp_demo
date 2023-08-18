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

    // GET: Admin/Country/Create
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("name,iso_code_2,iso_code_3,address_format,postcode_required,status")] CountryModel country)
    {
        if (ModelState.IsValid)
        {
            //Tạo Post
            var newpost = new CountryModel()
            {
                name = country.name,
                iso_code_2 = country.iso_code_2,
                iso_code_3 = country.iso_code_3,
                address_format = country.address_format,
                postcode_required = country.postcode_required,
                status = country.status
            };
            _context.Add(newpost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(country);
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if(id == null)
        {
            return NotFound();
        }
        var post = await _context.Country.Where(p => p.country_id == id).FirstOrDefaultAsync();
        if (post == null)
        {
            return NotFound();
        }

        return View(post);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("name,iso_code_2,iso_code_3,address_format,postcode_required,status")] CountryModel country)
    {
        if (id != country.country_id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            var countryUpdate = await _context.Country.Where(p => p.country_id == id).FirstOrDefaultAsync();
            if (countryUpdate == null)
            {
                return NotFound();
            }
            countryUpdate.name = country.name;
            countryUpdate.iso_code_2 = country.iso_code_2;
            countryUpdate.iso_code_3 = country.iso_code_3;
            countryUpdate.address_format = country.address_format;
            countryUpdate.postcode_required = country.postcode_required;
            countryUpdate.status = country.status;
            try
            {

                _context.Update(countryUpdate);

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
               
            }
            return RedirectToAction(nameof(Index));
        }
        return View(country);
    }
}
