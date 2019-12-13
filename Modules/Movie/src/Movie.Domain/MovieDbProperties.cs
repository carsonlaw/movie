namespace Movie
{
    public static class MovieDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Movie";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Movie";
    }
}
