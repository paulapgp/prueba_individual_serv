using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prueba_individual_serv.Models;
using prueba_individual_serv.Exceptions;
using System.Data.Entity;

namespace prueba_individual_serv.Repository
{
    public class PacienteRepository : IPacienteRepository
    {
        public Paciente Create(Paciente paciente)
        {
            return ApplicationDbContext.applicationDbContext.Pacientes.Add(paciente);
        }

        public Paciente Delete(long Id)
        {
            Paciente paciente = ApplicationDbContext.applicationDbContext.Pacientes.Find(Id);
            if (paciente == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Pacientes.Remove(paciente);
            return paciente;
        }

        public Paciente Read(long Id)
        {
            return ApplicationDbContext.applicationDbContext.Pacientes.Find(Id);
        }

        public IQueryable<Paciente> ReadAll()
        {
            IList<Paciente> lista = new List<Paciente>(ApplicationDbContext.applicationDbContext.Pacientes);

            return lista.AsQueryable();
        }

        public void Update(Paciente paciente)
        {
            if (ApplicationDbContext.applicationDbContext.Pacientes.Count(c => c.Id == paciente.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(paciente).State = EntityState.Modified;
        }
    }
}