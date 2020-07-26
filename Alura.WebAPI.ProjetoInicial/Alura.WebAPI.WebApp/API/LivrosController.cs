﻿using Alura.ListaLeitura.Modelos;
using Alura.ListaLeitura.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.WebAPI.WebApp.API
{
    public class LivrosController : Controller
    {
        private readonly IRepository<Livro> _repo;

        public LivrosController(IRepository<Livro> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Recuperar(int id)
        {
            var model = _repo.Find(id);
            if (model == null)
            {
                return NotFound();
            }

            return Json(model.ToModel());
        }
    }
}
