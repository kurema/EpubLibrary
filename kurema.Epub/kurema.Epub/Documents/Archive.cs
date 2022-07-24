using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace kurema.Epub.Documents;

public class Archive
{
    public Rendition? RenditionMain { get; set; }
    public List<Rendition> RenditionsSubs { get; set; } = new List<Rendition>();

    public System.IO.Stream? GetFile(string path)
    {
        return null;
    }
}
