using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private ClienteContext _context;

        public ClienteController(ClienteContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente); 
            _context.SaveChanges(); 
            return CreatedAtAction(nameof(BuscaClientesPorId), new { id = cliente.id }, cliente);
        }

        [HttpGet]
        public IEnumerable<Cliente> BuscaFilmes()
        {
            return _context.Clientes;
        }

        [HttpGet("{id}")]
        public IActionResult BuscaClientesPorId(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.id == id);

            if (cliente != null)
            {
                return Ok(cliente);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCliente(int id, [FromBody] Cliente clientenovo)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.id == id);

            if (cliente == null) return NotFound();

            cliente.Nome = clientenovo.Nome;
            cliente.Documento = clientenovo.Documento;
            cliente.Telefone = clientenovo.Telefone;
            cliente.Email = clientenovo.Email;
            cliente.Endereço = clientenovo.Endereço;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.id == id);

            if (cliente == null) return NotFound();

            _context.Remove(cliente);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
