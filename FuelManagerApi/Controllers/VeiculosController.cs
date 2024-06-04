using FuelManagerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuelManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeiculosController(AppDbContext context) {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetVeiculos()
        {
            return await _context.Veiculos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculo>> GetVeiculo(int id) {
            var veiculo = await _context.Veiculos.FirstOrDefaultAsync(c => c.Id == id);

            if (veiculo == null)
            {
                return NotFound();
            }

            return veiculo;

        }

        [HttpPut]
        public async Task<>



    }
}
