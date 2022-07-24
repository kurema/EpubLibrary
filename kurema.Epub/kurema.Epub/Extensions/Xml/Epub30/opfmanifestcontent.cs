using System;

namespace kurema.Epub.Xml.Epub30.Package;

partial class opfmanifestcontent
{
    public opfmanifestcontent()
    {
    }

    public void AddItems(params item[] newItems)
    {
        if(item is null)
        {
            item = newItems;
            return;
        }
        int currentLength = item.Length;
        Array.Resize(ref itemField, currentLength + newItems.Length);
        for (int i = 0; i < newItems.Length; i++)
        {
            itemField[currentLength + i] = newItems[i];
        }
    }
}