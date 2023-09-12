using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace hienv_asp.Controllers
{
    class Node
    {
        public string name { get; set; }
        public string Path { get; set; }
        public string type { get; set; }
        public string DateCreate { get; set; }
        public List<Node> children { get; set; }
        public Node()
        {
            children = new List<Node>();
        }
    }

    public class FileManageController : Controller
    {
        static Node Node = new Node();

        [HttpGet]
        public IActionResult Folders()
        {
            List<Node> nodes = Node.children;
            nodes.Clear();
            LoadDirectory(@"wwwroot/FileManager");
            return Json(nodes);
        }

        public static void LoadDirectory(string Dir)
        {

            DirectoryInfo di = new DirectoryInfo(Dir);
            Node.name = di.Name;
            LoadSubDirectories(Dir, Node);
        }
        private static void LoadSubDirectories(string dir, Node node)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                Node node1 = new Node();
                node1.name = di.Name;
                node1.type = "folder";
                node1.Path = subdirectory;
                node1.DateCreate = di.CreationTime.ToLongTimeString();
                node.children.Add(node1);
                LoadSubDirectories(subdirectory, node1);
            }
        }

        public IActionResult GetAllItemOnFolder(string Dir, int id)
        {
            var ListItem = new ArrayList();
            if (Dir == "all")
            {
                Dir = @"wwwroot/FileManager";
            }
            
            string[] subdirectoryEntries = Directory.GetDirectories(Dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                Hashtable folder = new Hashtable();
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                folder.Add("name", di.Name);
                folder.Add("type", "folder");
                folder.Add("Path", subdirectory);
                ListItem.Add(folder);
            }
            var filters = new String[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" };
            DirectoryInfo dir = new DirectoryInfo(Dir);
            foreach (var filter in filters)
            {
                FileInfo[] imageFiles = dir.GetFiles("*." + filter);
                foreach (FileInfo f in imageFiles)
                {
                    Hashtable itemFile = new Hashtable();
                    itemFile.Add("name", f.Name);
                    itemFile.Add("type", "file");
                    itemFile.Add("Path", f.FullName);
                    ListItem.Add(itemFile);
                }
            }
            return Json(ListItem);
        }

        [HttpPost]
        public IActionResult AddFolders()
        {
            var status = 200;

            return Json("dasda");
        }
    }
}
