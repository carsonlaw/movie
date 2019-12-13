using Volo.Abp.Reflection;

namespace Movie.Authorization
{
    public class MoviePermissions
    {
        public const string GroupName = "Movie";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MoviePermissions));
        }
    }
}