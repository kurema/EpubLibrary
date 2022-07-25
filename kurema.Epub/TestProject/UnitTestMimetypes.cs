using kurema.Epub.Helpers;

namespace TestProject;

public class UnitTestMimetypes
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("application/xhtml+xml", Mimetypes.GetMimetypeFromExtension("hTmL"));
        Assert.Equal("image/svg+xml", Mimetypes.GetMimetypeFromExtension(".SvG"));
        Assert.Equal("font/ttf", Mimetypes.GetMimetypeFromPath("/Users/kurema/Documents/Development/EpubLibrary/samplefile.ttf"));
    }
}