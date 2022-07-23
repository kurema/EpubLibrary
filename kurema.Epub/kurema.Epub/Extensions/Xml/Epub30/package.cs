using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package;

partial class package
{
    public const string DefaultUniqueIdentifier = "pub-id";

    public package()
    {
        spine = new spine();
        manifest = new manifest();
        metadata = new opfpackagecontentMetadata();

        uniqueidentifier = DefaultUniqueIdentifier;
        version = packageVersion.Item30;
        collection = new collection[0];
    }

    public void SetRequiredValues(string identifier, string title, string language)
    {
        metadata.SetRequiredValues(identifier, title, language);
        uniqueidentifier = DefaultUniqueIdentifier;
    }
}

partial class opfmanifestcontent
{
    public opfmanifestcontent()
    {
    }

    public void AddItem(item newItem)
    {
        if(item is null)
        {
            item = new[] { newItem };
            return;
        }
        Array.Resize(ref itemField, item.Length + 1);
        itemField[item.Length - 1] = newItem;
    }
}