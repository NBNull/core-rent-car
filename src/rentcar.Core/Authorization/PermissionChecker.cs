using Abp.Authorization;
using rentcar.Authorization.Roles;
using rentcar.MultiTenancy;
using rentcar.Users;

namespace rentcar.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
