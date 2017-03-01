using System.Threading.Tasks;
using Abp.Application.Services;
using rentcar.Roles.Dto;

namespace rentcar.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
