namespace projeto_contabil.Domain.Interface.Services
{
    public interface IProcessDocumentService
    {
        Task<NfeProc> Execute(IFormFile file);
    }
}
