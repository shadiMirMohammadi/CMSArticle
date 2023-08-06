using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMSArticle.ModelsLayer;
using CMSArticle.ModelsLayer.Context;
using CMSArticle.ServiceLayer;
using CMSArticle.App_Start;
using CMSArticle.Views.ViewModels;
using System.IO;


namespace CMSArticle.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private CMSContext db = new CMSContext();

        CategoryService _CategoryService;

        public CategoriesController()
        {
            _CategoryService = new CategoryService(db);
        }

        public ActionResult Index()
        {
            return View(AutoMapperConfig.mapper.Map<List<Category>, List<CategoryViewModel>>(_CategoryService.GetAll().ToList()));
        }



        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryId,Title")] CategoryViewModel categoryViewModel, HttpPostedFileBase imageUpload)
        {
            if (ModelState.IsValid)
            {
                if (imageUpload != null)
                {
                    if (imageUpload.ContentType != "image/jpeg" && imageUpload.ContentType != "image/png")
                    {
                        ModelState.AddModelError("ImageName", "تصویر شما باید با فرمت png یا jpeg باشد");
                        return View();
                    }
                    if (imageUpload.ContentLength > 300000)
                    {
                        ModelState.AddModelError("ImageName", "تصویر باید کمتر از 300 کیلوبایت باشد");
                        return View();
                    }

                    categoryViewModel.ImageName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(imageUpload.FileName);

                    imageUpload.SaveAs(Server.MapPath("/Image/Category/" + categoryViewModel.ImageName));
                }
                else
                {
                    categoryViewModel.ImageName = "NoImages.png";
                }

                Category category = AutoMapperConfig.mapper.Map<CategoryViewModel, Category>(categoryViewModel);
                _CategoryService.Add(category);
                _CategoryService.Save();
                return RedirectToAction("Index");
            }

            return View(categoryViewModel);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _CategoryService.GetEntity(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            var categoryViewModel = AutoMapperConfig.mapper.Map<Category, CategoryViewModel>(category);
            return View(categoryViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,Title,ImageName")] CategoryViewModel categoryViewModel, HttpPostedFileBase imageUpload)
        {
            if (ModelState.IsValid)
            {
                if (imageUpload != null)
                {
                    if (categoryViewModel.ImageName != "NoImages.png")
                    {
                        System.IO.File.Delete(Server.MapPath("/Image/Category/" + categoryViewModel.ImageName));
                    }
                    else
                    {
                        System.IO.File.Delete(Server.MapPath("/Image/Category/" + categoryViewModel.ImageName));
                        categoryViewModel.ImageName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(imageUpload.FileName);
                    }
                    imageUpload.SaveAs(Server.MapPath("/Image/Category/" + categoryViewModel.ImageName));
                }

                var category = AutoMapperConfig.mapper.Map<CategoryViewModel, Category>(categoryViewModel);
                _CategoryService.Update(category);
                _CategoryService.Save();
                return RedirectToAction("Index");
            }
            return View(categoryViewModel);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = _CategoryService.GetEntity(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            CategoryViewModel categoryViewModel = AutoMapperConfig.mapper.Map<Category, CategoryViewModel>(category);
            return View(categoryViewModel);
        }



        #region Delete

        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Category category = _CategoryService.GetEntity(id.Value);
        //    if (category == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(category);
        //}
        #endregion



        [HttpPost]
        public ActionResult Delete(int id)
        {
            Category category = _CategoryService.GetEntity(id);
            _CategoryService.Delete(category);
            _CategoryService.Save();
            if (category.ImageName != "NoImages.png")
            {
                System.IO.File.Delete(Server.MapPath("/Image/Category/" + category.ImageName));

            }

            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            _CategoryService.Dispose();
        }
    }
}
