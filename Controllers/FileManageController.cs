using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hienv_asp.Controllers
{
   
    public class FileManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Folders()
        {
            string root = @"wwwroot/FileManager";
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(root);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                LoadSubDirs(subdirectory);
            }
            return Json("Response from Get");
        }

        private void LoadSubDirs(string dir)
        {

            Console.WriteLine(dir);
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                LoadSubDirs(subdirectory);
            }
        }
    }
}
