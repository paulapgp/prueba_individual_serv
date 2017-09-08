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

namespace prueba_individual_serv.Controllers
{
    public class PacientesController : ApiController
    {
        private IPacienteService pacienteService;

        public PacientesController(IPacienteService _pacienteService)
        {
            this.pacienteService = _pacienteService;
        }

        // GET: api/Pacientes
        public IQueryable<Paciente> GetPacientes()
        {
            return pacienteService.ReadAll();
        }

        // GET: api/Pacientes/5
        [ResponseType(typeof(Paciente))]
        public IHttpActionResult GetPaciente(long id)
        {
            Paciente paciente = pacienteService.Read(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return Ok(paciente);
        }

        // PUT: api/Pacientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPaciente(long id, Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != paciente.Id)
            {
                return BadRequest();
            }

            try
            {
                pacienteService.Update(paciente);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }
            

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pacientes
        [ResponseType(typeof(Paciente))]
        public IHttpActionResult PostPaciente(Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            pacienteService.Create(paciente);

            return CreatedAtRoute("DefaultApi", new { id = paciente.Id }, paciente);
        }

        // DELETE: api/Pacientes/5
        [ResponseType(typeof(Paciente))]
        public IHttpActionResult DeletePaciente(long id)
        {
            Paciente paciente;
            try
            {
                paciente = pacienteService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(paciente);
        }
    }
}