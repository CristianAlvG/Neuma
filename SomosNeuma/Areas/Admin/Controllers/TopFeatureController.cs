using Microsoft.AspNetCore.Mvc;
using Neuma.DataAccess.Repository;
using Neuma.DataAccess.Repository.IRepository;
using Neuma.Models;

namespace SomosNeuma.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TopFeatureController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TopFeatureController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int id)
        {
            TopFeature feature = _unitOfWork.TopFeature.Get(u => u.Id == id);

            if (feature != null) {

                return View(feature);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Upsert(TopFeature feature, IFormFile? file)
        {
            TopFeature oldFeature = _unitOfWork.TopFeature.Get(u => u.Id == feature.Id);

            if (ModelState.IsValid)
            {
                if (feature == null || feature.Id == 0)
                {
                    return RedirectToAction("Index", "Home", new { area = "User" });
                }
                else
                {
                    if(file != null)
                    {
                        //Store images
                        string wwwRootPath = _webHostEnvironment.WebRootPath;

                        string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        string filePath = @"images\topfeatures\feature-" + feature.Id;
                        string finalPath = Path.Combine(wwwRootPath, filePath);

                        if (!Directory.Exists(finalPath))
                        {
                            Directory.CreateDirectory(finalPath);
                        }

                        using (var filestream = new FileStream(Path.Combine(finalPath, filename), FileMode.Create))
                        {
                            file.CopyTo(filestream);
                        }

                        var oldImagePath = Path.Combine(wwwRootPath, oldFeature.Image.Trim('\\'));


                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }

                        feature.Image = @"\" + filePath + @"\" + filename;
                    }
                    else
                    {
                        feature.Image = oldFeature.Image;
                    }

                    _unitOfWork.TopFeature.Update(feature);
                    _unitOfWork.Save();
                    return RedirectToAction("Index", "Home", new { area = "User" });
                }
            }
            else
            {
                feature.Image = oldFeature.Image;
                return View(feature);
            }

        }
    }
}
