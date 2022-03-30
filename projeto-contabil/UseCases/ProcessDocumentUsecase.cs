using projeto_contabil.Domain;
using projeto_contabil.Domain.Interface.Services;
using projeto_contabil.Domain.Interface.UseCases;

namespace projeto_contabil.UseCases
{
    public class ProcessDocumentUsecase : IProcessDocumentUsecase
    {
        private readonly IProcessDocumentService? _serviceProcessDocument;

        public ProcessDocumentUsecase(IProcessDocumentService serviceProcessDocument)
        {
               _serviceProcessDocument = serviceProcessDocument;
        }
        public async Task<NfeProc> Execute(IFormFile file)
        {
            return await _serviceProcessDocument.Execute(file);            
        }
    }
}
