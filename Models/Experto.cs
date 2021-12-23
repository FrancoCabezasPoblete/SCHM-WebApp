using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Dapper;


namespace Web.Models{
    [Table("Experto")]
    public class ExpertoModel{
        private readonly string _dbConnection;
        
        public ExpertoModel(string conString){
            _dbConnection = conString;
        }


        public ExpertoModel(string conString,int id){
            _dbConnection = conString;
            GetById(id);
        }

        public ExpertoModel(){
        }

        [Key]
        public  int  IDExperto { get; set; } = -1;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public void GetById(int id){
            ExpertoModel experto = new ExpertoModel();

            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                experto = db.Get<ExpertoModel>(id);
            }

            IDExperto = experto.IDExperto;
            Nombre = experto.Nombre;
            Apellido = experto.Apellido;
            Correo = experto.Correo;
        }

        public ExpertoModel GetByAccount(string correo, string contrasena){
            ExpertoModel experto;
            string sql = String.Format("SELECT * FROM Experto WHERE Correo = '{0}' AND Contraseña = '{1}'", correo, contrasena);
            using (IDbConnection db = new SqlConnection(_dbConnection))
            {
                experto = db.Query<ExpertoModel>(sql).FirstOrDefault();
            }

            return experto;
        }
    }
}
