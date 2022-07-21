using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using kurema.Epub.Xml.Epub30.Package;

namespace kurema.Epub.Documents;

#nullable enable

public class Rendition
{
    //Definition of Rendition:
    //https://www.w3.org/publishing/epub3/epub-spec.html#dfn-rendition

    public package Package { get; } = new();
    public IEnumerable<IFileItem> GetStreams()
    {
        yield return new FileItemSerializer<package>("/epub/package.opf", Package);
    }


}

