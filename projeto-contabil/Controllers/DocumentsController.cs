using Microsoft.AspNetCore.Mvc;
using projeto_contabil.Domain.Interface.UseCases;

namespace projeto_contabil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IProcessDocumentUsecase _useCase;
        public DocumentsController(IProcessDocumentUsecase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public async Task<IActionResult> UploadDocument(IFormFile file)
        {
            return Ok(await _useCase.Execute(file));
        }
    }
}
