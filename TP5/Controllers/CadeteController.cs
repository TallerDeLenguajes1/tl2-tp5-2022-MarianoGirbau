using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels; //Agregar
using Mappers;
using AutoMapper;

namespace TP4.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        private readonly IMapper _mapper;

        private static readonly List<Cadete> Cadetes = new();

        private static int IDCadetes = 0;

        public CadeteController(ILogger<CadeteController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(Cadetes);
        }

        [HttpGet]
        public IActionResult CargaCadete()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult CargaCadeteExito(CadeteViewModel CadeteViewModel) 
        {
            //Cadete nuevoCadete = mapper.getCadete(cadete);
            //nuevoCadete.ID = ++IDCadetes;
            //Cadetes.Add(nuevoCadete);
            
            if(ModelState.IsValid){
                var NuevoCadete = _mapper.Map<Cadete>(CadeteViewModel);
                NuevoCadete.ID = ++IDCadetes;
                Cadetes.Add(NuevoCadete);
                return RedirectToAction("Index");
            } 

            return View("CargaCadete",CadeteViewModel);

        }

        [HttpGet]
        public void BajaCadete(int ID)
        {   
            Cadetes.RemoveAll(x => x.getID() == ID);
            Response.Redirect("/Cadete");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}