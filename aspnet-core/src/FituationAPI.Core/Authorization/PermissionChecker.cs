using Abp.Authorization;
using FituationAPI.Authorization.Roles;
using FituationAPI.Authorization.Users;

namespace FituationAPI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
