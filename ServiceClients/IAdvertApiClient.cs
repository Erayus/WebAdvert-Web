using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAdvert.Web.ServiceClients
{
    public interface IAdvertApiClient
    {
        Task<CreateAdvertResponse> CreateAsync(CreateAdvertModel model);
        Task<bool> ConfirmAsync(ConfirmAdvertRequest model);
        Task<List<Advertisement>> GetAllAsync();
        Task<Advertisement> GetAsync(string advertId);
    }
}
