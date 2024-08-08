using System.Collections;
using APIROBERTO.Models.DCModel;
using APIROBERTO.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIROBERTO.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AspiranteController : ControllerBase
    {
        private readonly AspiranteServices _services;

        public AspiranteController(AspiranteServices services)
        {
            _services = services;
        }

        [HttpGet("obtener")]
        public async Task<IEnumerable<Aspirante>> GetAll()
        {
            return await _services.GetAll();
        }

        [HttpPost("Crear")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IActionResult> Create (Aspirante aspirante)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            _services.Create(aspirante);
            return Ok();
        }
    }
}