using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;

namespace Web.ViewComponents
{
    public class LayoutDropdownListVC : ViewComponent
    {
        IProjectRepo prepo;
        
        public LayoutDropdownListVC(IProjectRepo prepo)
        {
            this.prepo = prepo;
        }

        public IViewComponentResult Invoke(List<Project> id)
        {
            if (id == null)
            {
                var rec = this.prepo.GetAllProject();
                return View(rec);
            }
            else
            {
                return View(id);
            }
        }
    }
}
