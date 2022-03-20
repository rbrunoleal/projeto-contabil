using projeto_contabil.Domain;
using System.Text;
using System.Xml.Serialization;

namespace projeto_contabil.Services
{
    public class ProcessDocumentService : IProcessDocumentService
    {
        public Task<NfeProc> Execute(IFormFile file)
        {
            var xml = ReadAsStringAsync(file).Result;

            var serializer = new XmlSerializer(typeof(NfeProc));
            NfeProc result;

            using (TextReader reader = new StringReader(xml))
            {
                result = (NfeProc)serializer.Deserialize(reader);
            }

            return Task.FromResult(result);
        }

        public async Task<string> ReadAsStringAsync(IFormFile file)
        {
            var result = new StringBuilder();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.AppendLine(await reader.ReadLineAsync());
            }
            return result.ToString();
        }
    }
}
