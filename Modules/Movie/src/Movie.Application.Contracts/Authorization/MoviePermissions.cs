using Volo.Abp.Reflection;

namespace Movie.Authorization
{
    public class MoviePermissions
    {
        public const string GroupName = "Movie";
        public const string Create = GroupName + ".Create";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MoviePermissions));
        }
    }
}