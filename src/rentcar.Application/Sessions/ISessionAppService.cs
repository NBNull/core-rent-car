using System.Threading.Tasks;
using Abp.Application.Services;
using rentcar.Sessions.Dto;

namespace rentcar.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
