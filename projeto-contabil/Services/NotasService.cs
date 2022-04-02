using Microsoft.Extensions.Options;
using MongoDB.Driver;
using projeto_contabil.Domain;
using projeto_contabil.Domain.Interface.Services;

namespace projeto_contabil.Services
{
    public class NotasService : INotasService
    {
        private readonly IMongoCollection<Nota> _notasCollection;

        public NotasService(
            IOptions<DbClient> notasStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                notasStoreDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                notasStoreDatabaseSettings.Value.DatabaseName);

            _notasCollection = mongoDatabase.GetCollection<Nota>("Notas");
        }

        public async Task<List<Nota>> GetAsync() =>
            await _notasCollection.Find(_ => true).ToListAsync();

        public async Task<Nota?> GetAsync(string id) =>
            await _notasCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Nota newNota) =>
            await _notasCollection.InsertOneAsync(newNota);

        public async Task UpdateAsync(string id, Nota updatedNota) =>
            await _notasCollection.ReplaceOneAsync(x => x.Id == id, updatedNota);

        public async Task RemoveAsync(string id) =>
            await _notasCollection.DeleteOneAsync(x => x.Id == id);
    }
}
