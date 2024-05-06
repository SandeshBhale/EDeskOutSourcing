using Infra;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;

namespace Web.ViewComponents
{
    public class TechnologyCheckBoxVC:ViewComponent
    {
        EDeskContext repo;

        public TechnologyCheckBoxVC(EDeskContext repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(Int64 id=0)
        {
            if (id == 0)
            {
                var v = from t in this.repo.Technologies.ToList()
                        select new CheckBoxVM
                        {
                            CheckBoxID = t.TechnologiesId,
                            CheckBoxText = t.TechnologyName,
                            IsSelected = false
                        };
                return View(v.ToList());
            }
            else
            {
                var oldskill = this.repo.Technologies.ToList().Where(c => c.TechnologiesId == id);
                var v = from t in this.repo.Technologies.ToList()
                        select new CheckBoxVM
                        {
                            CheckBoxID = t.TechnologiesId,
                            CheckBoxText = t.TechnologyName,
                            IsSelected = false
                        };
                return View(v.ToList());
            }
        }
    }
}
