using ERV.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERV.Services.DataService
{
    public interface IERVService
    {
        Task<List<PresencePreviewModel>> GetAllNamesAsync();
    }
}