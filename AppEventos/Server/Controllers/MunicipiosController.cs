using AppEventos.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppEventos.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MunicipiosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public MunicipiosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Municipio>>> Get()
        {
            return await context.Municipios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Municipio>>> Get(int id)
        {
            return await context.Municipios.Where(x => x.DepartamentoId == id).ToListAsync();
        }
    }
}
