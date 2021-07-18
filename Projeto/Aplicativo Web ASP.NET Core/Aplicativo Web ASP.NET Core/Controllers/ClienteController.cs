using Aplicativo_Web_ASP.NET_Core.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Aplicativo_Web_ASP.NET_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
       
        private readonly ILogger<ClienteController> _logger;
        private IClienteService _clienteService;
        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clienteService.FindAll());
        } 
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = _clienteService.FindByID(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }
    }
}
