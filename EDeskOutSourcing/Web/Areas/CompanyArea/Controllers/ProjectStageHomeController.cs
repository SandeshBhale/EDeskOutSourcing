using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis;
using Repo;
using Repo.ViewModels;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectStageHomeController : Controller
    {
        IProjectStageRepo repo;
        IProjectRepo prepo;
        public ProjectStageHomeController(IProjectStageRepo repo,IProjectRepo prepo)
        {
            this.prepo = prepo;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProjectStageVM rec)

        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            if (ModelState.IsValid)
            {
                ProjectStage prec = new ProjectStage();
                //prec.ProjectId = rec.ProjectId;

                for (int i = 0; i < rec.ProjectStageName.Count(); i++)
                {
                    ProjectStage ptemp = new ProjectStage();
                    //ptemp.ProjectStageId = rec.ProjectStageId[i];
                    ptemp.StageDescription = rec.StageDescription[i];
                    ptemp.ProjectStageName = rec.ProjectStageName[i];
                    ptemp.DurationInHours = rec.DurationInHours[i];
                    ptemp.ProjectId = rec.ProjectId;
                    prec.ProjectStages.Add(ptemp);
                }

                this.repo.AddRecord(prec.ProjectStages);
                return RedirectToAction("Index");
            }

            return View(rec);
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            var rec = from t in this.repo.GetProject()
                      where t.ProjectId == id
                      select new ProjectStageVM
                      {
                          ProjectId = t.ProjectId,
                          ProjectStageName = (from t1 in t.ProjectStages select t1.ProjectStageName).ToList(),
                          DurationInHours = (from t1 in t.ProjectStages select t1.DurationInHours).ToList(),
                          StageDescription = (from t1 in t.ProjectStages select t1.StageDescription).ToList()
                      };
                  ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
                  return View(rec.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Edit(ProjectStageVM rec)
        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            if (ModelState.IsValid)
            {
                // first delete from child table 
                //var oldskill = this.cntx.EmployeeSkills.Where(p => p.EmployeeID == rec.EmployeeID);
                //foreach (var temp in oldskill)
                //{
                //    this.cntx.EmployeeSkills.Remove(temp);
                //}
                //this.cntx.SaveChanges();
                this.repo.RemoveStage(rec);

                //ProjectStageVM prec = this.repo.GetProject().Find(rec.ProjectId);
                

                ////find parent table record and modify it
                //Employee erec = this.cntx.Employees.Find(rec.EmployeeID);
                //erec.EmpName = rec.Name;
                //erec.Address = rec.Address;
                //erec.EmailID = rec.EmailID;
                //erec.MobileNo = rec.MobileNo;


                ////create and add child records
                //for (int i = 0; i < rec.SkillID.Count(); i++)
                //{
                //    EmployeeSkill eskrec = new EmployeeSkill();
                //    eskrec.SkillID = rec.SkillID[i];
                //    eskrec.Reamrk = rec.Remark[i];
                //    eskrec.ExperienceInMonths = rec.Experience[i];
                //    erec.EmployeeSkills.Add(eskrec);
                //}

                //this.cntx.SaveChanges();
                //return RedirectToAction("Index");
            }

            return View(rec);
        }



        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}