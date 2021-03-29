using LowFidelityPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LowFidelityPrototype.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Pessoa um = new Pessoa
            {
                ID = 1,
                PrimeiroNome = "Manuel",
                UltimoNome = "Fontes",
                Pontuacao = 1154
            };

            Pessoa dois = new Pessoa
            {
                ID = 2,
                PrimeiroNome = "Joana",
                UltimoNome = "Torres",
                Pontuacao = 1658
            };

            Pessoa tres = new Pessoa
            {
                ID = 3,
                PrimeiroNome = "Carlos",
                UltimoNome = "Costa",
                Pontuacao = 1154
            };

            Pessoa quatro = new Pessoa
            {
                ID = 4,
                PrimeiroNome = "Carlos",
                UltimoNome = "Costa",
                Pontuacao = 506
            };

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                um,
                dois,
                tres,
                quatro
            };

            pessoas.OrderByDescending(x => x.Pontuacao);

            return View(pessoas);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}