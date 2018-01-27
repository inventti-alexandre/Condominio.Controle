using AutoMapper;
using Condominio.Controle.Application.Interfaces;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Condominio.Controle.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public LoginController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        // GET: Login
        public ActionResult SignIn()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult SignIn(UsuarioViewModel user, string ReturnUrl = "")
        {
            if (ModelState.IsValid)
            {
                if (_usuarioAppService.IsAuthenticated(Mapper.Map<UsuarioViewModel, Usuario>(user)))
                {
                    FormsAuthentication.SetAuthCookie(user.Nome, false);
                    return Redirect(string.IsNullOrEmpty(ReturnUrl) ? "/" : ReturnUrl);
                }

                ViewBag.Mensagem = "O Usuario/Senha inválido";
                return View(user);
            }
            return View();
        }

        // GET: Login/SignOut
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("SignIn");
        }

    }
}
