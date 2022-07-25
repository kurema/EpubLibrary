using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace kurema.Epub.Documents;

public class Archive
{
    public Rendition RenditionMain { get; set; } = new Rendition();
    public List<Rendition> RenditionsSubs { get; } = new List<Rendition>();

    public IEnumerable<IFileItem> GetFileItems()
    {
        foreach (var item in RenditionMain.GetFileItems()) yield return item;
    }
}
