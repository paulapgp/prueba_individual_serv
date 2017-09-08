using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prueba_individual_serv.Models
{
    public class Paciente
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string DescripcionDolencia { get; set; }
        public int DuracionTratamiento { get; set; }

        public Paciente()
        { }

        public Paciente(string _nombre, string _apellidos, string _sexo, int _edad, string _descripcionDolencia, int _duracionTratamiento)
        {
            this.Nombre = _nombre;
            this.Apellidos = _apellidos;
            this.Sexo = _sexo;
            this.Edad = _edad;
            this.DescripcionDolencia = _descripcionDolencia;
            this.DuracionTratamiento = _duracionTratamiento;
        }
    }
}