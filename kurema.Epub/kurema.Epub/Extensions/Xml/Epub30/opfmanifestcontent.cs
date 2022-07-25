using System;

namespace kurema.Epub.Xml.Epub30.Package;

partial class opfmanifestcontent
{
    public opfmanifestcontent()
    {
    }

    public void AddItems(params item[] newItems)
    {
        Helpers.Functions.AddItemsToArray(ref this.itemField, newItems);
    }
}
