using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;



namespace Web.Models{
    [Table("Solicitud")]
    public class SolicitudModel{
        private readonly string _dbConnection;
        
        public SolicitudModel(string conString){
            _dbConnection = conString;
        }


        public SolicitudModel(string conString,int id){
            _dbConnection = conString;
            GetById(id);
        }

        public SolicitudModel(){
        }

        [Key]
        public int IDFormulario{ get; set; } = -1;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Solicitud { get; set; }
        public string Fecha { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        
        public byte Estado { get; set; } = 0;

        //DateTime myDateTime = DateTime.Now;
        //string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

        public List<SolicitudModel> GetAll(){
            IEnumerable<SolicitudModel> solicitudes;

            using (IDbConnection db = new SqlConnection(_dbConnection)){
                solicitudes = db.GetAll<SolicitudModel>();
            }

            return solicitudes.ToList();
        }
        
        public void GetById(int id){
            SolicitudModel solicitud = new SolicitudModel();

            using (IDbConnection db = new SqlConnection(_dbConnection)){
                solicitud = db.Get<SolicitudModel>(id);
            }

            IDFormulario = solicitud.IDFormulario;
            Nombre = solicitud.Nombre;
            Apellido = solicitud.Apellido;
            Correo = solicitud.Correo;
            Fecha = solicitud.Fecha;
            Solicitud = solicitud.Solicitud;
            Estado = solicitud.Estado;
        }
    }
}
