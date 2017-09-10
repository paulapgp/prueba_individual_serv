using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using prueba_individual_serv.Models;
using prueba_individual_serv.Services;
using prueba_individual_serv.Exceptions;
using System.Web.Http.Cors;

namespace prueba_individual_serv.Controllers
{
    [EnableCors(origins: "http://localhost:8081, http://localhost:8080", headers: "*", methods: "*")]
    public class MedicamentosController : ApiController
    {
        private IMedicamentoService medicamentoService;

        public MedicamentosController(IMedicamentoService _medicamentoService)
        {
            this.medicamentoService = _medicamentoService;
        }

        // GET: api/Medicamentoes
        public IQueryable<Medicamento> GetMedicamentos()
        {
            return medicamentoService.ReadAll();
        }

        // GET: api/Medicamentoes/5
        [ResponseType(typeof(Medicamento))]
        public IHttpActionResult GetMedicamento(long id)
        {
            Medicamento medicamento = medicamentoService.Read(id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return Ok(medicamento);
        }

        // PUT: api/Medicamentoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMedicamento(long id, Medicamento medicamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != medicamento.Id)
            {
                return BadRequest();
            }

            try
            {
                medicamentoService.Update(medicamento);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Medicamentoes
        [ResponseType(typeof(Medicamento))]
        public IHttpActionResult PostMedicamento(Medicamento medicamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            medicamentoService.Create(medicamento);

            return CreatedAtRoute("DefaultApi", new { id = medicamento.Id }, medicamento);
        }

        // DELETE: api/Medicamentoes/5
        [ResponseType(typeof(Medicamento))]
        public IHttpActionResult DeleteMedicamento(long id)
        {
            Medicamento medicamento;
            try
            {
                medicamento = medicamentoService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(medicamento);
        }

    }
}