using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using prueba_individual_serv.Models;
using prueba_individual_serv.Repository;

namespace prueba_individual_serv.Services
{
    public class MedicamentoService : IMedicamentoService
    {
        IMedicamentoRepository medicamentoRepository;

        public MedicamentoService(IMedicamentoRepository _medicamentoRepository)
        {
            this.medicamentoRepository = _medicamentoRepository;
        }

        public Medicamento Create(Medicamento medicamento)
        {
            return medicamentoRepository.Create(medicamento);
        }

        public Medicamento Delete(long id)
        {
            return medicamentoRepository.Delete(id);
        }

        public Medicamento Read(long id)
        {
            return medicamentoRepository.Read(id);
        }

        public IQueryable<Medicamento> ReadAll()
        {
            return medicamentoRepository.ReadAll();
        }

        public void Update(Medicamento medicamento)
        {
            medicamentoRepository.Update(medicamento);
        }
    }
}