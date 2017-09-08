using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prueba_individual_serv.Models
{
    public class Medicamento
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Presentacion { get; set; }
        public string FechaCaducidad { get; set; }

        public Medicamento()
        { }

        public Medicamento(string _nombre, string _tipo, string _presentacion, string _fechaCaducidad)
        {
            this.Nombre = _nombre;
            this.Tipo = _tipo;
            this.Presentacion = _presentacion;
            this.FechaCaducidad = _fechaCaducidad;
        }
    }
}