﻿using MountainStyleShop.ModelNH.Config;
using MountainStyleShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MountainStyleShop.Controllers
{
    public class ComponentesController : Controller
    {
        // GET: Componentes
        public PartialViewResult MenuCategorias(int idCategoriaAtiva = 0)
        {
            ViewBag.Categorias = ConfigDB.Instance.CategoriaRepository.GetAll().OrderBy(x=>x.Nome).ToList();
            ViewBag.CategoriaAtiva = idCategoriaAtiva;
            return PartialView("_MenuCategorias");
        }

        public PartialViewResult PainelImagensIndex()
        {
            return PartialView("_PainelImagensIndex");
        }

        
        public PartialViewResult MenuUsuarioLogado()
        {
            if (UsuarioUtils.Usuario != null)
            {
                ViewBag.IsAdmin = UsuarioUtils.Usuario.Admin;
                return PartialView("_MenuUsuarioLogado");
            }
            
            return PartialView("_MenuUsuarioDeslogado");
        }


    }
}