using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using kurema.Epub.Xml.Epub30.Package;
using kurema.Epub.Helpers;

namespace kurema.Epub.Documents;

#nullable enable

public class Rendition
{
    //Definition of Rendition:
    //https://www.w3.org/publishing/epub3/epub-spec.html#dfn-rendition

    public FileItemSerializer<package> Package { get; } = new(DefaultValues.PathPackage, new package());
    
    public IEnumerable<IFileItem> GetFileItems()
    {
        yield return Package;
    }
}

