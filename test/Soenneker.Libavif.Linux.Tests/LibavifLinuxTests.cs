using System.IO;
using System.Threading.Tasks;

namespace Soenneker.Libavif.Linux.Tests;

public sealed class LibavifLinuxTests
{
    [Test]
    public async Task Project_defines_the_expected_runtime_path()
    {
        string path = Path.Combine("Resources", "linux-x64", "libavif", "avifenc");
        await Assert.That(path).EndsWith("avifenc");
    }
}
