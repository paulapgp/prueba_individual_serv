using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prueba_individual_serv.Models;
using prueba_individual_serv.Exceptions;
using System.Data.Entity;

namespace prueba_individual_serv.Repository
{
    public class MedicamentoRepository : IMedicamentoRepository
    {
        public Medicamento Create(Medicamento medicamento)
        {
            return ApplicationDbContext.applicationDbContext.Medicamentos.Add(medicamento);
        }

        public Medicamento Delete(long Id)
        {
            Medicamento medicamento = ApplicationDbContext.applicationDbContext.Medicamentos.Find(Id);
            if (medicamento == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Medicamentos.Remove(medicamento);
            return medicamento;
        }

        public Medicamento Read(long Id)
        {
            return ApplicationDbContext.applicationDbContext.Medicamentos.Find(Id);
        }

        public IQueryable<Medicamento> ReadAll()
        {
            IList<Medicamento> lista = new List<Medicamento>(ApplicationDbContext.applicationDbContext.Medicamentos);

            return lista.AsQueryable();
        }

        public void Update(Medicamento medicamento)
        {
            if (ApplicationDbContext.applicationDbContext.Medicamentos.Count(c => c.Id == medicamento.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(medicamento).State = EntityState.Modified;
        }
    }
}