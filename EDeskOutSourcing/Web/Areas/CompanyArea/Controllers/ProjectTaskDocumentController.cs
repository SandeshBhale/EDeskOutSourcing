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

        IProjectTaskDocumentRepo repo;
        IProjectRepo prepo;
        IWebHostEnvironment env;

        public ProjectTaskDocumentController(IProjectTaskDocumentRepo repo,IProjectRepo prepo, IWebHostEnvironment env)
        {
            this.repo = repo;
            this.prepo = prepo;
            this.env = env;
        }

        public IActionResult Index(Int64 id)
        {
            ViewBag.ProjectTaskId = id;
            var pDoc = this.repo.GetProjectTaskDocumentById(id);
            ViewBag.ProjectTaskDocument = pDoc;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectTaskDocument rec)
        {
            //ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            if (ModelState.IsValid)
            {
            if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.env.WebRootPath, "ProjectTaskDocument");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\ProjectTaskDocument", filename);
                        rec.ProjectDocumentFilePath = logicalpath;
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
