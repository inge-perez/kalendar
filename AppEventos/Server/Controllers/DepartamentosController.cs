using AppEventos.Shared.Entidades;
using Microsoft.AspNetCore.Http;
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
    public class DepartamentosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DepartamentosController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Departamento>>> Get()
        {
            return await context.Departamentos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Departamento>> Get(int id)
        {
            return await context.Departamentos.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
