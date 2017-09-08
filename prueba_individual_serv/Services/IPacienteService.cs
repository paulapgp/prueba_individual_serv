using prueba_individual_serv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_individual_serv.Services
{
    public interface IPacienteService
    {
        Paciente Create(Paciente paciente);
        Paciente Read(long id);
        IQueryable<Paciente> ReadAll();
        void Update(Paciente paciente);
        Paciente Delete(long id);
    }
}
