using kurema.Epub.Documents;

namespace TestProject;

public class UnitTestFileItem
{
    [Fact]
    public async Task Test1()
    {
        var item = new FileItemString("/EPUB/Readme.txt", "sample");
        Assert.Equal("/EPUB/Readme.txt", item.Name);
        Assert.Equal("sample", item.Content.ToString());
        {
            using var ms = new MemoryStream(1024);
            await item.WriteToStream(ms);
            ms.Seek(0, SeekOrigin.Begin);
            var sr = new StreamReader(ms);
            Assert.Equal("sample", await sr.ReadToEndAsync());
        }
    }

    [Fact]
    public async Task Test2()
    {
        kurema.Epub.Xml.Epub30.OcfContainer.container container = new();
        container.AddRootFile(new kurema.Epub.Xml.Epub30.OcfContainer.rootfile() { fullpath = "EPUB/package.opf", mediatype = kurema.Epub.Xml.Epub30.OcfContainer.rootfileMediatype.applicationoebpspackagexml });
        var item = new FileItemSerializer<kurema.Epub.Xml.Epub30.OcfContainer.container>("META-INF/container.xml", container);
        Assert.Equal("META-INF/container.xml", item.Name);
        {
            using var ms = new MemoryStream(4096);
            await item.WriteToStream(ms);
            ms.Seek(0, SeekOrigin.Begin);
            var sr = new StreamReader(ms);
            var result = await sr.ReadToEndAsync();
            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-8\"?><container xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" version=\"1.0\" xmlns=\"urn:oasis:names:tc:opendocument:xmlns:container\"><rootfiles><rootfile full-path=\"EPUB/package.opf\" media-type=\"application/oebps-package+xml\" /></rootfiles></container>"
                , result);
        }
    }
    [Fact]
    public async Task Test3()
    {
        var item = new FileItemDelegate("EPUB/random.txt", () =>new MemoryStream(System.Text.Encoding.UTF8.GetBytes("This is nice stream!")));
        Assert.Equal("EPUB/random.txt", item.Name);
        {
            using var ms = new MemoryStream(1024);
            await item.WriteToStream(ms);
            ms.Seek(0, SeekOrigin.Begin);
            var sr = new StreamReader(ms);
            Assert.Equal("This is nice stream!", await sr.ReadToEndAsync());
        }
    }
}
