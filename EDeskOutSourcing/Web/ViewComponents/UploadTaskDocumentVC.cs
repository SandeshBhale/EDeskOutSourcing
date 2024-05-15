using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class UploadTaskDocumentVC : ViewComponent
    {
        IProjectTaskDocumentRepo repo;
        public UploadTaskDocumentVC(IProjectTaskDocumentRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(List<ProjectTaskDocument> id)
        {
            //var document = repo.GetAll();
           //var rec = repo.GetAllProjectDocument();
            return View(id);
        }
    }
}
