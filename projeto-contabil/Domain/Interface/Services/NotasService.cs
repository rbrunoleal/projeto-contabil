namespace projeto_contabil.Domain.Interface.Services
{
    public interface INotasService
    {
        Task<List<Nota>> GetAsync();
        Task<Nota?> GetAsync(string id);
        Task CreateAsync(Nota newNota);
        Task UpdateAsync(string id, Nota updatedNota);
        Task RemoveAsync(string id);
    }
}
