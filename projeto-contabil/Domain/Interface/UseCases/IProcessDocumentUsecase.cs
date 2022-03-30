namespace projeto_contabil.Domain.Interface.UseCases
{
    public interface IProcessDocumentUsecase
    {
        Task<NfeProc> Execute(IFormFile file);
    }
}
