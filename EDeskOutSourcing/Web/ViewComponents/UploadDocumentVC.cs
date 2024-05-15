using Core;
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

        public IViewComponentResult Invoke(List<ProjectDocument> id)
        {
            //var document = repo.GetAll();
            //var rec = repo.GetAllProjectDocument();
            return View(id);
        }
    }
}