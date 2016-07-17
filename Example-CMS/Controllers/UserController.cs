using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CMS_Domain.Entity;
using CMS_Domain.Interfaces.AppService;
using Example_CMS.ViewModel;
using PagedList;

namespace Example_CMS.Controllers
{
    [RoutePrefix("Users")]
    public class UserController : BaseController
    {
        private readonly IUserAppService _app;

        public UserController(IUserAppService app)
        {
            this._app = app;
        }

        [Route("")]
        public ActionResult Index(int pageNumber = 1)
        {
            var users = _app.GetAllActive();
            var count = users.Count();

            var pagedUsers = users.ToPagedList(pageNumber, _pageSize);
            IEnumerable<UserViewModel> usersVM = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(pagedUsers);

            return Request.IsAjaxRequest()
            ? (ActionResult)PartialView("_ListUsers", new StaticPagedList<UserViewModel>(usersVM, pageNumber, _pageSize, count))
            : View(new StaticPagedList<UserViewModel>(usersVM, pageNumber, _pageSize, count));

        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
