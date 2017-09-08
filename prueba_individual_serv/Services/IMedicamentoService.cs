using prueba_individual_serv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_individual_serv.Services
{
    public interface IMedicamentoService
    {
        Medicamento Create(Medicamento medicamento);
        Medicamento Read(long id);
        IQueryable<Medicamento> ReadAll();
        void Update(Medicamento medicamento);
        Medicamento Delete(long id);
    }
}
