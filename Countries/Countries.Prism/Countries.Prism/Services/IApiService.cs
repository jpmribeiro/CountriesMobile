namespace Countries.Prism.Services
{
    using Countries.Prism.Entities;
    using System.Threading.Tasks;

    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);

    }
}
