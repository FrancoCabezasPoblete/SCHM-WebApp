using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Http;


namespace Web.Models{
    public class ExpedienteModelForm{
        private readonly string _dbConnection;
        
        public ExpedienteModelForm(string conString){
            _dbConnection = conString;
        }

        public ExpedienteModelForm(){
        }

        [Key]
        public int IDExpediente { get; set; } = -1;
        public string Fecha { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        public string Titulo { get; set; }
        public string Fuente { get; set; }
        public string Autor {get; set; }
        public string Descripcion { get; set; } = "-";
        public IFormFile ArchivoForm {get; set; }
        public int IDExperto { get; set; } = 1;

    }
}
