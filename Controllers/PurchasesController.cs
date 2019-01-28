using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testvue.Models;
using testvue.Models.ViewModels;
using testvue.Services;

namespace vuetest.Controllers
{
    [Route("api/[controller]")]
    public class PurchasesController : ControllerBase
    {
        private readonly IPurchasesRepo _repo;

        public PurchasesController(IPurchasesRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneById(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> AddOne([FromBody] PurchaseVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Lol!");
            }

            var entity = new Purchase { Name = viewModel.Name };
            await _repo.AddOneAsync(entity);
            if (!await _repo.SaveAsync())
            {
                return StatusCode(500);
            }
            return Created($"api/purchases/{entity.ID}", entity);
        }
    }
}