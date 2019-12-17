using System.Threading.Tasks;
using Xunit;

namespace Movie.Samples
{
    public class SampleManager_Tests : MovieDomainTestBase
    {
        //private readonly SampleManager _sampleManager;

        public SampleManager_Tests()
        {
            //_sampleManager = GetRequiredService<SampleManager>();
        }

        [Fact]
        public async Task Method1Async()
        {

            await Task.CompletedTask;
        }
    }
}
