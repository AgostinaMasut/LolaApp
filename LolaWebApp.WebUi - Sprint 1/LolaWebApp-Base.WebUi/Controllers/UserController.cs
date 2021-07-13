using LolaApp.DataAccess;
using LolaApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LolaWebApp_Base.WebUi.Models;
using LolaApp.Entities;

namespace LolaWebApp_Base.WebUi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserTypeRepository _userTypeRepository;
        private readonly ISexRepository _sexRepository;

        public UserController(IUserRepository userRepository,
            IUserTypeRepository userTypeRepository,
            ISexRepository sexRepository)
        {
            _userRepository = userRepository;
            _userTypeRepository = userTypeRepository;
            _sexRepository = sexRepository;
            //_userRepository = new UserRepository(new LolaAppContext());
        }

        // GET: User
        public ActionResult Index()
        {
            var entityList = _userRepository.FindAll();
            List<UserViewModel> model = new List<UserViewModel>();
            foreach (var entity in entityList)
            {
                var vm = new UserViewModel();
                vm.Name = entity.Name;
                vm.LastName = entity.LastName;
                vm.Email = entity.Email;
                //Resolver tipo de usuario
                vm.Enable = entity.Enable;
                //todo: mapear el resto de los campos
                model.Add(vm);
            }
            return View(model);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            var model = new UserViewModel();
            //model.UserType = GetUserType();
            //model.Sex = GetSex();
            return View(model);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserViewModel user)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return View(user);
                }
                var entity = new User();
                //Crear mappeo
                entity.Name = user.Name;
                entity.LastName = user.LastName;
                entity.DNI = user.DNI;
                entity.CuitCuil = user.CuitCuil;
                entity.Birthday = user.Birthday;
                entity.Street = user.Street;
                entity.StreetNumber = user.StreetNumber;
                entity.Neighbourhood = user.Neighbourhood;
                entity.ZipCode = user.ZipCode;
                entity.City = user.City;
                entity.Mobile = user.Mobile;
                entity.Email = user.Email;
                entity.Password = user.Password;
                entity.Enable = user.Enable;
                entity.IdUserType = 1;
                entity.IdSex = 2;
                _userRepository.Create(entity);
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

        private SelectList GetUserType() {
            var listaTipos = _userTypeRepository.FindAll();
            var selectlst = new SelectList(listaTipos, "Id", "Description");
            return selectlst;
        }
        //private SelectList GetUserTypeId()
        //{
        //    //var listaTipos = _userTypeRepository.FindAll();
        //    //var selectlstId = new SelectList(listaTipos, "Id", "Description");
        //    //return selectlstId;
        //}
        private SelectList GetSex()
        {
            var listaTipos = _sexRepository.FindAll();
            var selectlst = new SelectList(listaTipos, "Id", "Description");
            return selectlst;
        }

    }
}
