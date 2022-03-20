using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_contabil.Domain;

namespace projeto_contabil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IProcessDocumentService _service;
        public DocumentsController(IProcessDocumentService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> UploadDocument(IFormFile file)
        {
            return Ok(await _service.Execute(file));
        }
    }
}
