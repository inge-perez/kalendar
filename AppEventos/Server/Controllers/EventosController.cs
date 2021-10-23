using AppEventos.Server.Helpers;
using AppEventos.Shared.DTOs;
using AppEventos.Shared.Entidades;
using AppEventos.Web.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AppEventos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "eventos";
        public EventosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("[action]", Name = "obtenerCategoria")]
        public async Task<ActionResult<List<Categoria>>> obtenerCategoria()
        {
            return await context.Categorias.ToListAsync();
        }

        [HttpGet("[action]/{id}", Name = "obtenerEvento")]
        public async Task<ActionResult<EventoVisualizarDTO>> Obtener(int id)
        {
            var evento = await context.Eventos
                .Include(x => x.Municipio)
                .Include(x => x.Categoria)
                .Include(x => x.Departamento)
                //.Include(x => x.Usuario)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (evento == null)
            {
                return NotFound();
            }

            var model = new EventoVisualizarDTO();
            model.NombreEvento = evento.NombreEvento;
            model.DescripcionEvento = evento.DescripcionEvento;
            model.FechaEvento = evento.FechaEvento;
            model.NombreMunicipio = evento.Municipio.Nombre;
            model.NombreDepartamento = evento.Departamento.Nombre;
            model.DescripcionCategoria = evento.Categoria.Descripcion;
            //model.NombreUsuario = evento.Usuario.NombreUsuario;

            return model;
        }


        [HttpPost("[action]")]
        public async Task<ActionResult> Crear([FromBody] EventoCreacionDTO eventoCreacionDTO)
        {
            var evento = mapper.Map<Evento>(eventoCreacionDTO);

            if (eventoCreacionDTO.Imagen != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    var fotoPersona = Convert.FromBase64String(eventoCreacionDTO.Imagen);
                    evento.Imagen = await almacenadorArchivos.GuardarArchivo(fotoPersona, "jpg", contenedor);
                }
            }

            evento.EstadoId = 1;
            context.Add(evento);

            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            var dto = mapper.Map<EventoCreacionDTO>(evento);
            return new CreatedAtRouteResult("obtenerEvento", new { id = evento.Id }, dto);
        }
    }
}
