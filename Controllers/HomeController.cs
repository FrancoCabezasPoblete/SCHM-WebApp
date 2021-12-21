using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using X.PagedList;


namespace Web.Controllers{
    public class HomeController : Controller{
        private readonly ILogger<HomeController> _logger;
        private readonly string _dbConnection;

        public HomeController(ILogger<HomeController> logger, string conString){
            _logger = logger;
            _dbConnection = conString;
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Solicitud(){
            ViewBag.Current = "Solicitud";
            return View();
        }

        public IActionResult Buscador(){
            ViewBag.Current = "Buscador";
            List<ExpedienteModel> expedientes = new ExpedienteModel(_dbConnection).GetAll();
            return View(expedientes);
        }

        public IActionResult Login(){
            ViewBag.Current = "Login";
            return View();
        }

        public IActionResult Solicitudes(int pagina = 1){
            const int cantidad = 10;
            ViewBag.Current = "Solicitudes";
            var solicitudes = new SolicitudModel(_dbConnection).GetAll();
            var elementosPagina = solicitudes.ToPagedList(pagina, cantidad);
            ViewBag.elementosPagina = elementosPagina;
            return View();
        }

        // CRUD Solicitudes
        [HttpGet]
        public IActionResult LeerMas(int id){
            ViewBag.Current = "Solicitudes";
            return View(new SolicitudModel(_dbConnection, id));
        }

        [HttpGet]
        public IActionResult EditarEstado(int id, byte estado){
            using (var db = new SqlConnection(_dbConnection)){
                SolicitudModel solicitud = db.Get<SolicitudModel>(id);
                solicitud.Estado = estado;
                db.Update<SolicitudModel>(solicitud);
            }
            return RedirectToAction("Solicitudes","Home");
        }

        [HttpPost]
        public IActionResult InsertarSolicitud(SolicitudModel newSolicitud){

            using (var db = new SqlConnection(_dbConnection)){
                db.Insert(newSolicitud);
            }
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult EliminarSolicitud(int id){
            using (var db = new SqlConnection(_dbConnection)){
                db.Delete(new SolicitudModel {IDFormulario = id});
            }
            return RedirectToAction("Solicitudes","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


/*
<ul class="pagination justify-content-center">
                    <li class="page-item disabled">
                        <a class="page-link" href="#" tabindex="-1">Anterior</a>
                    </li>
                    <li class="page-item active"><a class="page-link" href="#">1</a></li>
                    <li class="page-item"><a class="page-link" href="#">2</a></li>
                    <li class="page-item"><a class="page-link" href="#">3</a></li>
                    <li class="page-item">
                        <a class="page-link" href="#">Siguiente</a>
                    </li>
                </ul>

*/