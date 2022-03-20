namespace projeto_contabil.Domain
{
    public interface IProcessDocumentService
    {
        Task<NfeProc> Execute(IFormFile file);
    }
}
