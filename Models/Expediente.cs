using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Http;


namespace Web.Models{
    [Table("Expediente")]
    public class ExpedienteModel{
        private readonly string _dbConnection;
        
        public ExpedienteModel(string conString){
            _dbConnection = conString;
        }


        public ExpedienteModel(string conString,int id){
            _dbConnection = conString;
            GetById(id);
        }

        public ExpedienteModel(){
        }

        [Key]
        public int IDExpediente { get; set; } = -1;
        public string Fecha { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        public string Titulo { get; set; }
        public string Fuente { get; set; }
        public string Autor {get; set; }
        public string Descripcion { get; set; } = "-";
        public byte[] Archivo {get; set; }
        public int IDExperto { get; set; } = 1;

        public List<ExpedienteModel> GetAll(){
            IEnumerable<ExpedienteModel> expedientes;
            string sql = String.Format("SELECT * FROM Expediente ORDER BY Fecha DESC");

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                expedientes = db.Query<ExpedienteModel>(sql);
            }

            return expedientes.ToList();
        }

        public List<ExpedienteModel> GetAll(string busqueda){
            IEnumerable<ExpedienteModel> expedientes;
            string sql = String.Format("SELECT * FROM Expediente WHERE Titulo LIKE '%{0}%' OR Fuente LIKE '%{0}%' OR Descripcion LIKE '%{0}%' ORDER BY Fecha DESC", busqueda);

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                expedientes = db.Query<ExpedienteModel>(sql);
            }

            return expedientes.ToList();
        }

        public List<ExpedienteModel> GetAllTitulo(string busqueda){
            IEnumerable<ExpedienteModel> expedientes;
            string sql = String.Format("SELECT * FROM Expediente WHERE Titulo LIKE '%{0}%' OR Fuente LIKE '%{0}%' ORDER BY Fecha DESC", busqueda.Substring(1));

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                expedientes = db.Query<ExpedienteModel>(sql);
            }

            return expedientes.ToList();
        }

        public void GetById(int id){
            ExpedienteModel expediente = new ExpedienteModel();

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                expediente = db.Get<ExpedienteModel>(id);
            }

            IDExpediente = expediente.IDExpediente;
            Fecha = expediente.Fecha;
            Titulo = expediente.Titulo;
            Fuente = expediente.Fuente;
            Archivo = expediente.Archivo;
            Descripcion = expediente.Descripcion;
            IDExperto = expediente.IDExperto;
        }
    }
}
