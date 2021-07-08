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
                vm.Apellido = entity.Apellido;
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
            model.TipoUsuario = GetTipoUsario();
            model.Sexo = GetTipoSexo();
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
                //entity.Denominacion = model.Denominacion;
                entity.Nombre = user.Nombre;
                entity.Apellido = user.Apellido;
                entity.DNI = user.DNI;
                entity.CuitCuil = user.CuitCuil;
                entity.FechaNacimiento = user.FechaNacimiento;
                entity.Calle = user.Calle;
                //entity.IdUserType = user.TipoUsuario;
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

        private SelectList GetTipoUsario() {
            var listaTipos = _userTypeRepository.FindAll();
            var selectlst = new SelectList(listaTipos, "Id", "Descripcion");
            return selectlst;
        }
        private SelectList GetTipoSexo()
        {
            var listaTipos = _sexRepository.FindAll();
            var selectlst = new SelectList(listaTipos, "Id", "Descripcion");
            return selectlst;
        }

    }
}
