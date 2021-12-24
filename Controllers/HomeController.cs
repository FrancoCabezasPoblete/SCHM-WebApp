using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using X.PagedList;
using System.Web;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;


namespace Web.Controllers{
    public class HomeController : Controller{
        private readonly ILogger<HomeController> _logger;
        private readonly string _dbConnection;

        public HomeController(ILogger<HomeController> logger, string conString){
            _logger = logger;
            _dbConnection = conString;
        }

        public IActionResult Index(){
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            }
            return View();
        }

        public IActionResult Solicitud(){
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            }
            ViewBag.Current = "Solicitud";
            return View();
        }

        // CRUD SolicitudModel
        [HttpGet]
        public IActionResult Solicitudes(int pagina = 1, int filtro = 0, string busqueda = ""){
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            } else {
                return RedirectToAction("Index","Home");
            }
            const int cantidad = 10;
            ViewBag.Current = "Solicitudes";
            List<SolicitudModel> solicitudes;
            if(busqueda == ""){
                switch(filtro){
                    case 1:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Fecha","ASC");
                        break;
                    case 2:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Nombre","ASC");
                        break;
                    case 3:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Nombre","DESC");
                        break;
                    case 4:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(0);
                        break;
                    case 5:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(2);
                        break;
                    case 6:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(3);
                        break;
                    case 7:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(1);
                        break;
                    default:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Fecha","DESC");
                        break;
                }
            } else {
                switch(filtro){
                    case 1:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Fecha","ASC", busqueda);
                        break;
                    case 2:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Nombre","ASC", busqueda);
                        break;
                    case 3:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Nombre","DESC", busqueda);
                        break;
                    case 4:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(0, busqueda);
                        break;
                    case 5:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(2, busqueda);
                        break;
                    case 6:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(3, busqueda);
                        break;
                    case 7:
                        solicitudes = new SolicitudModel(_dbConnection).GetAllEstado(1, busqueda);
                        break;
                    default:
                        solicitudes = new SolicitudModel(_dbConnection).GetAll("Fecha","DESC", busqueda);
                        break;
                }
            }

            IPagedList elementosPagina = solicitudes.ToPagedList(pagina, cantidad);
            ViewBag.filtro = filtro;
            ViewBag.busqueda = busqueda;
            return View(elementosPagina);
        }

        [HttpGet]
        public IActionResult EditarEstado(int id, byte estado){
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            } else {
                return RedirectToAction("Index","Home");
            }
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
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            } else {
                return RedirectToAction("Index","Home");
            }
            using (var db = new SqlConnection(_dbConnection)){
                db.Delete(new SolicitudModel {IDFormulario = id});
            }
            return RedirectToAction("Solicitudes","Home");
        }

        //CRUD ExpedienteModel
        public IActionResult Buscador(int pagina = 1, string busqueda = ""){
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            } else {
                return RedirectToAction("Index","Home");
            }
            const int cantidad = 10;
            ViewBag.Current = "Buscador";
            List<ExpedienteModel> expedientes;
            if(busqueda == ""){
                expedientes = new ExpedienteModel(_dbConnection).GetAll();
            } else { 
                if(busqueda != null && busqueda[0] == '#'){
                    expedientes = new ExpedienteModel(_dbConnection).GetAllTitulo(busqueda);
                } else {
                    expedientes = new ExpedienteModel(_dbConnection).GetAll(busqueda);
                }
            }

            var elementosPagina = expedientes.ToPagedList(pagina, cantidad);
            ViewBag.elementosPagina = elementosPagina;
            ViewBag.busqueda = busqueda;
            ViewBag.cantidad = elementosPagina.Count;
            return View();
        }

        [HttpPost]
        public IActionResult InsertarExpediente(ExpedienteModelForm newExpediente){
            if(newExpediente.ArchivoForm != null){
                using (var memoryStream = new MemoryStream()){
                    newExpediente.ArchivoForm.CopyTo(memoryStream);

                    // Upload the file if less than 10 MB
                    if (memoryStream.Length < (2097152*5)){
                        var file = new ExpedienteModel(){
                            Fecha = newExpediente.Fecha, 
                            Titulo = newExpediente.Titulo,
                            Fuente = newExpediente.Fuente,
                            Autor = newExpediente.Autor,
                            Descripcion = newExpediente.Descripcion,
                            Archivo = memoryStream.ToArray(), 
                            };

                        using (var db = new SqlConnection(_dbConnection)){
                            db.Insert<ExpedienteModel>(file);
                        }
                    } else {
                        ModelState.AddModelError("File", "El archivo es muy grande");
                    }
                }
            } else {
                ExpedienteModel expediente = new ExpedienteModel{Fecha = newExpediente.Fecha, Titulo = newExpediente.Titulo, Fuente = newExpediente.Fuente, Autor = newExpediente.Autor, Descripcion = newExpediente.Descripcion};
                using (var db = new SqlConnection(_dbConnection)){
                    db.Insert<ExpedienteModel>(expediente);
                }
            }
            return RedirectToAction("Buscador","Home");
        }

        [HttpGet]
        public FileResult DescargarExpediente(int id){
            ExpedienteModel archivo;
            using (var db = new SqlConnection(_dbConnection)){
                archivo = db.Get<ExpedienteModel>(id);
            }

            return File(archivo.Archivo,"application/pdf", archivo.Titulo);
        }

        [HttpGet]
        public IActionResult EliminarExpediente(int id){
            IRequestCookieCollection cookie = GetCookies();
            if(cookie != null){
                ViewBag.cookie = new {Nombre = cookie["user_name"], Correo = cookie["user_email"], IDExperto = cookie["user_id"]};
            } else {
                return RedirectToAction("Index","Home");
            }
            using (var db = new SqlConnection(_dbConnection)){
                db.Delete(new ExpedienteModel {IDExpediente = id});
            }
            return RedirectToAction("Buscador","Home");
        }

        // Cambiar contraseña Experto
        [HttpPost]
        public IActionResult CambiarContrasena(ExpertoModel experto){
            // string contraseña = BCrypt.Net.BCrypt.HashPassword(nueva_contrasena); // Implementación de hasheo de contraseña cuando se necesiten más expertos
            using (var db = new SqlConnection(_dbConnection)){
                ExpertoModel originalExperto = db.Get<ExpertoModel>(experto.IDExperto);
                if(experto.Correo == originalExperto.Correo){
                    originalExperto.Contraseña = experto.Contraseña;
                    db.Update<ExpertoModel>(originalExperto);
                } else {
                    ViewBag.Error = "El Correo no concuerda con el Identificador";
                }
            }
            return View("Login");
        }

        // Control de sesiones
        public IActionResult Login(){
            ViewBag.Current = "Login";
            return View();
        }

        [HttpPost]
        public IActionResult Login(ExpertoModel experto){
            var cuenta = new ExpertoModel(_dbConnection).GetByAccount(experto.Correo, experto.Contraseña);
            if(cuenta == null){
                ViewBag.Error = "Credenciales incorrectas";
                return View();
            }
            HttpContext.Response.Cookies.Append("user_id", cuenta.IDExperto.ToString());
            HttpContext.Response.Cookies.Append("user_name", cuenta.Nombre+" "+cuenta.Apellido);
            HttpContext.Response.Cookies.Append("user_email", cuenta.Correo);

            return RedirectToAction("Index","Home");
        }

        public IRequestCookieCollection GetCookies(){
            IRequestCookieCollection cookie = HttpContext.Request.Cookies;
            if(cookie["user_id"] == null){
                return null;
            } else {
                return cookie;
            }
        }

        public IActionResult LogOut(){
            HttpContext.Response.Cookies.Delete("user_id");
            HttpContext.Response.Cookies.Delete("user_name");
            HttpContext.Response.Cookies.Delete("user_email");
    
            return RedirectToAction("Index","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}