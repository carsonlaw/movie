using UCenter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace UCenter.Authorization
{
    public class UCenterPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(UCenterPermissions.GroupName, L("Permission:UCenter"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UCenterResource>(name);
        }
    }
}