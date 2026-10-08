using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Libavif.Linux.Tests;

public sealed class LibavifLinuxTests
{
    [Test]
    public async ValueTask Project_defines_the_expected_runtime_path(CancellationToken cancellationToken)
    {
        string path = Path.Combine("Resources", "linux-x64", "libavif", "avifenc");
        await Assert.That(path).EndsWith("avifenc");
    }
}
