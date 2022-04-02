namespace projeto_contabil.Domain.Interface.UseCases
{
    public interface IProcessDocumentUsecase
    {
        Task<Nota> Execute(IFormFile file);
    }
}
