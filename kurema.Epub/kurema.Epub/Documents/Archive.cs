using System;
using System.Collections.Generic;
using System.Text;

using kurema.Epub.Xml.Epub30.OcfContainer;

#nullable enable

namespace kurema.Epub.Documents;

public class Archive
{
    public container Container { get; } = new container();

    public Rendition RenditionMain { get; set; } = new Rendition();
    public List<Rendition> RenditionsSubs { get; } = new List<Rendition>();

    private rootfile[] GetRootFiles()
    {
        var rootfiles = new rootfile[1 + RenditionsSubs.Count];
        rootfiles[0] = new rootfile()
        {
            fullpath = RenditionMain.Package.Name,
            mediatype = rootfileMediatype.applicationoebpspackagexml,
        };
        for (int i = 0; i < RenditionsSubs.Count; i++)
        {
            rootfiles[i + 1] = new rootfile()
            {
                fullpath = RenditionsSubs[i].Package.Name,
                mediatype = rootfileMediatype.applicationoebpspackagexml,
            };
        }
        return rootfiles;
    }

    public void UpdateRootFiles()
    {
        Container.rootfiles = GetRootFiles();
    }

    public FileItemCollection GetFileItems()
    {
        var result = new FileItemCollection
        {
            new FileItemSerializable<container>(Helpers.DefaultValues.PathContainer, Container)
        };
        result.AddRange(RenditionMain.GetFileItems());
        foreach (var item in RenditionsSubs) result.AddRange(item.GetFileItems());
        return result;
    }
}
