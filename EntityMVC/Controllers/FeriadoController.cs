﻿using EntityMVC.Api;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EntityMVC.Controllers
{
    public class FeriadoController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            int ano = DateTime.Now.Year;
            var feriados = await ApiNagerDate.GetFeriados(ano);
            var listaFeriados = feriados ?? new List<ApiNagerDateResponse>();

            ViewBag.Ano = ano;
            return View(listaFeriados);
        }
    }
}