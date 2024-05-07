using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;

namespace Web.ViewComponents
{
    public class LayoutDropdownVC : ViewComponent
    {
        ISkillRepo srepo;
        ITechnologiesRepo trepo;
        
        public LayoutDropdownVC(ISkillRepo srepo,ITechnologiesRepo trepo)
        {
            this.srepo = srepo;
            this.trepo = trepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            ViewBag.SkillId = new SelectList(this.srepo.GetAll(), "SkillId", "SkillName");
            ViewBag.TechnologiesId = new SelectList(this.trepo.GetAll(), "TechnologiesId", "TechnologyName");
            return View();
        }
    }
}
