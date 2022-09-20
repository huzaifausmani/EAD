using System.Collections.ObjectModel;
using System.Xml;
using System.Xml.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using videofiles.Models;

namespace videofiles.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment Environment;
 
        public HomeController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }

        // private IHostingEnvironment Environment;
 
        // public HomeController(IHostingEnvironment _environment)
        // {
        //     Environment = _environment;
        // }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [RequestSizeLimit(209715200)]  //200 MB limit
        // https://nicolaiarocci.com/how-to-increase-upload-file-size-in-asp.net-core/ 
        // [DisableRequestSizeLimit, RequestFormLimits(MultipartBodyLengthLimit = 1, ValueLengthLimit = 52428800)]
        public IActionResult Index(List<IFormFile> postedFiles)
        {
            try
            {
                string wwwPath = this.Environment.WebRootPath;
                // string contentPath = this.Environment.ContentRootPath;
        
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
        
                List<string> uploadedFiles = new List<string>();
                foreach (IFormFile postedFile in postedFiles)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    string extension = Path.GetExtension(postedFile.FileName);
                    //fileName = "myName2"+extension;
                    if(extension.ToLower() == ".mp4" || extension.ToLower() == ".mov" || extension.ToLower() == ".flv" || extension.ToLower() == ".ts" || extension.ToLower() == ".3gp" || extension.ToLower() == ".m3u8" || extension.ToLower() == ".avi" || extension.ToLower() == ".wmv" || extension.ToLower() == ".webm")
                    {
                        using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                        {
                            postedFile.CopyTo(stream);
                            uploadedFiles.Add(fileName);
                            video v = new video();
                            v.Filename=fileName;
                            v.Filepath="~/Uploads/"+fileName;
                            bool flag = v.insertData(v);
                            if(flag)
                            {
                                ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                            }
                            else
                            {
                                ViewBag.Message += string.Format("Error: <b>{0}</b> not uploaded.<br />", fileName);
                            }
                        }
                    }
                    else
                    {
                        ViewBag.Message += string.Format("Error: <b>{0}</b> not uploaded because this extension is not supported.<br />", fileName);
                    }
                }
            }  
            catch (Exception ex)  
            {
                ViewBag.Message = "ERROR: File size " + ex.Message.ToString();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            video v = new video();
            List<video> li = new List<video>();
            li = v.getData();
            return View("Privacy",li);
        }

        public IActionResult showfiles()
        {
            video v = new video();
            List<video> li = new List<video>();
            li = v.getData();
            return View("showfiles",li);
        }

        [HttpGet]
        public IActionResult deletefiles()
        {
            video v = new video();
            List<video> li = new List<video>();
            li = v.getData();
            return View("deletefiles",li);
        }

        [HttpPost]
        public IActionResult deletefiles(string filename)
        {
            // https://www.c-sharpcorner.com/UploadFile/dbeniwal321/how-to-delete-a-file-in-C-Sharp/

            try
            {
                string wwwPath = this.Environment.WebRootPath;
                string contentPath = this.Environment.ContentRootPath;
        
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (System.IO.File.Exists(Path.Combine(path, filename)))    
                {    
                    // If file found, delete it.
                    System.IO.File.Delete(Path.Combine(path, filename));    
                    ViewBag.Message =  "File deleted.";    
                }    
                else
                { 
                    ViewBag.Message = "File not found";    
                }
            }  
            catch (Exception ex)  
            {
                ViewBag.Message = "ERROR: File not found " + ex.Message.ToString();
            }

            video v = new video();
            ViewBag.flag = v.deleteVideo(filename);  //from database.
            List<video> li = new List<video>();
            li = v.getData();
            return View("deletefiles",li);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
