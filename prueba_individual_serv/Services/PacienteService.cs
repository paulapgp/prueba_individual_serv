using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prueba_individual_serv.Models;
using prueba_individual_serv.Repository;

namespace prueba_individual_serv.Services
{
    public class PacienteService : IPacienteService
    {
        private IPacienteRepository pacienteRepository;

        public PacienteService(IPacienteRepository _pacienteRepository)
        {
            this.pacienteRepository = _pacienteRepository;
        }

        public Paciente Create(Paciente paciente)
        {
            return pacienteRepository.Create(paciente);
        }

        public Paciente Delete(long id)
        {
            return pacienteRepository.Delete(id);
        }

        public Paciente Read(long id)
        {
            return pacienteRepository.Read(id);
        }

        public IQueryable<Paciente> ReadAll()
        {
            return pacienteRepository.ReadAll();
        }

        public void Update(Paciente paciente)
        {
            pacienteRepository.Update(paciente);
        }
    }
}