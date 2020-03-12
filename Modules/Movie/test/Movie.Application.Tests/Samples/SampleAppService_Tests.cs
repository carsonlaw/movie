using System.Threading.Tasks;
using Movie.Movies;
using Movie;
using Shouldly;
using Xunit;

namespace Movie.Samples
{
    public class SampleAppService_Tests : MovieApplicationTestBase
    {
        private readonly IMovieAppService _sampleAppService;

        public SampleAppService_Tests()
        {
            _sampleAppService = GetRequiredService<IMovieAppService>();
        }

        
    }
}
