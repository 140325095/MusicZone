using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicZone.Models;

namespace MusicZone.Controllers
{
    public class BandasController : Controller
    {
        public IActionResult Index()
        {
            List<Banda> bandas = Repositorio.VerBandas;
            return View(bandas);
        }

        [HttpGet]
        public IActionResult NovaBanda()

        {

            return View();
        }

        [HttpPost]
        public IActionResult NovaBanda(Banda b)

        {
            if (ModelState.IsValid)
            {
                Repositorio.AdicionarBanda(b);
                return View("ConfirmacaoBanda", b);
            }
            else
            {
                return View();
            }
        }
    }
}