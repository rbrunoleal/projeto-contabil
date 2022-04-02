using Microsoft.AspNetCore.Mvc;
using projeto_contabil.Domain;
using projeto_contabil.Services;

namespace projeto_contabil.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase
    {
        private readonly NotasService _notasService;

        public NotasController(NotasService NotasService) =>
            _notasService = NotasService;

        [HttpGet]
        public async Task<List<Nota>> Get() =>
            await _notasService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Nota>> Get(string id)
        {
            var Nota = await _notasService.GetAsync(id);

            if (Nota is null)
            {
                return NotFound();
            }

            return Nota;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Nota newNota)
        {
            await _notasService.CreateAsync(newNota);

            return CreatedAtAction(nameof(Get), new { id = newNota.Id }, newNota);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Nota updatedNota)
        {
            var Nota = await _notasService.GetAsync(id);

            if (Nota is null)
            {
                return NotFound();
            }

            updatedNota.Id = Nota.Id;

            await _notasService.UpdateAsync(id, updatedNota);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Nota = await _notasService.GetAsync(id);

            if (Nota is null)
            {
                return NotFound();
            }

            await _notasService.RemoveAsync(id);

            return NoContent();
        }
    }
}
