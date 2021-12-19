using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;


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
        public string Fecha { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Fuente { get; set; }
        public string Descripcion { get; set; }
        public int IDExperto { get; set; } = -1;

        public List<ExpedienteModel> GetAll()
        {
            IEnumerable<ExpedienteModel> expedientes;

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                expedientes = db.GetAll<ExpedienteModel>();
            }

            return expedientes.ToList();
        }

        public void GetById(int id)
        {
            ExpedienteModel expediente = new ExpedienteModel();

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                expediente = db.Get<ExpedienteModel>(id);
            }

            IDExpediente = expediente.IDExpediente;
            Fecha = expediente.Fecha;
            Nombre = expediente.Nombre;
            Titulo = expediente.Titulo;
            Fuente = expediente.Fuente;
            Descripcion = expediente.Descripcion;
            IDExperto = expediente.IDExperto;
        }
    }
}
