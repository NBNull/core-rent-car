using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using rentcar.MultiTenancy.Dto;

namespace rentcar.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
