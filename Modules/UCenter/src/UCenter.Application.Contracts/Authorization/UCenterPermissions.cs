using Volo.Abp.Reflection;

namespace UCenter.Authorization
{
    public class UCenterPermissions
    {
        public const string GroupName = "UCenter";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UCenterPermissions));
        }
    }
}