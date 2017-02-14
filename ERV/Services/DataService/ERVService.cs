using ERV.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace ERV.Services.DataService
{
    internal class ERVService : IERVService
    {
        private List<PresencePreviewModel> allNames;

        public async Task<List<PresencePreviewModel>> GetAllNamesAsync()
        {
            var client = new HttpClient();

            var stream = await client.GetStreamAsync("http://localhost:9011/recipes ");
            var serializer = new DataContractJsonSerializer(typeof(List<PresencePreviewModel>));

            allNames = (List<PresencePreviewModel>)serializer.ReadObject(stream);

            return allNames;
        }
    }
}