using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package;

partial class package
{
    public void SetRequiredValues(string identifier, string title, string language)
    {
        if (metadata is null) metadata = new opfpackagecontentMetadata();
        metadata.SetRequiredValues(identifier, title, language);
        uniqueidentifier = Helpers.DefaultValues.UniqueIdentifier;
    }
}
