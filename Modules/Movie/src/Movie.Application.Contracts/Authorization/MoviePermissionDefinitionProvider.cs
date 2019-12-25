using Movie.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Movie.Authorization
{
    public class MoviePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var moduleGroup = context.AddGroup(MoviePermissions.GroupName, L("Permission:Movie"));
            moduleGroup.AddPermission(MoviePermissions.Create, L("Permission:Create"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MovieResource>(name);
        }
    }
}