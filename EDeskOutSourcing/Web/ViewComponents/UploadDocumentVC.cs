using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class UploadDocumentVC : ViewComponent
    {
        IProjectDocumentRepo repo;
        public UploadDocumentVC(IProjectDocumentRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            //var document = repo.GetAll();
            var rec = repo.GetAllProjectDocument();
            return View(rec);
        }
    }
}
