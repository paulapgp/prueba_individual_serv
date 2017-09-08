using prueba_individual_serv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_individual_serv.Repository
{
    public interface IMedicamentoRepository
    {
        Medicamento Create(Medicamento medicamento);
        Medicamento Read(long Id);
        IQueryable<Medicamento> ReadAll();
        void Update(Medicamento medicamento);
        Medicamento Delete(long Id);
    }
}
