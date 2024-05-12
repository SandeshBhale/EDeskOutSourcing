using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectTaskDocumentController : Controller
    {

        IProjectDocumentRepo repo;
        IProjectRepo prepo;
        IWebHostEnvironment env;

        public ProjectTaskDocumentController(IProjectDocumentRepo repo,IProjectRepo prepo, IWebHostEnvironment env)
        {
            this.repo = repo;
            this.prepo = prepo;
            this.env = env;
        }

        public IActionResult Index(Int64 id)
        {
            ViewBag.ProjectId = id;
            var pDoc = this.repo.GetProjectDocumentById(id);
            ViewBag.ProjectDocument = pDoc;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectDocument rec)
        {
            //ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            if (ModelState.IsValid)
            {
            if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.env.WebRootPath, "ProjectDocument");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\ProjectDocument", filename);
                        rec.DocumentFilePath = logicalpath;
                    }
                }
                this.repo.Add(rec);
                return RedirectToAction("Index");
            }
            //return View(rec);
            return RedirectToAction("Index",rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
