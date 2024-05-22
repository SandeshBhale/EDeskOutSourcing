using Core;
using Infra;
using Infra.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Repo;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectDocumentHomeController : Controller
    {
        IProjectDocumentRepo repo;
        IProjectRepo prepo;
        IWebHostEnvironment env;
        EDeskContext ec;

        public ProjectDocumentHomeController(IProjectDocumentRepo repo, IProjectRepo prepo, IWebHostEnvironment env,EDeskContext ec)
        {
            this.repo = repo;
            this.prepo = prepo;
            this.env = env;
            this.ec = ec;
        }

        public IActionResult Index(Int64 id)
        {
            ViewBag.ProjectId = id;
            var pDoc = this.repo.GetProjectDocumentById(id);
            ViewBag.ProjectDocument = pDoc;
            return View();
        }

        [HttpGet]
        public IActionResult Create(Int64 id)
        {
            ViewBag.ProjectId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectDocument rec)
        {
            ViewBag.ProjectId = rec.ProjectId;

            var v = rec.ProjectId;

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
                return RedirectToAction("Index", new {id=v});
            }
            return RedirectToAction("Index", rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var pa = ec.ProjectDocuments.Where(t => t.ProjectDocumentId == id).Select(p => p.ProjectId).FirstOrDefault();

            ViewBag.ProjectId = pa;

            this.repo.Delete(id);
            return RedirectToAction("Index", new {id=pa});
        }
    }
}