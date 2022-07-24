using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package;

partial class package
{
    public package()
    {
        spine = new spine();
        manifest = new manifest();
        metadata = new opfpackagecontentMetadata();


/* プロジェクト 'kurema.Epub (NET6.0)' からのマージされていない変更
前:
        uniqueidentifier = Documents.DefaultValues.UniqueIdentifier;
後:
        uniqueidentifier = DefaultValues.UniqueIdentifier;
*/
        uniqueidentifier = Helpers.DefaultValues.UniqueIdentifier;
        version = packageVersion.Item30;
        collection = new collection[0];
    }

    public void SetRequiredValues(string identifier, string title, string language)
    {
        metadata.SetRequiredValues(identifier, title, language);

/* プロジェクト 'kurema.Epub (NET6.0)' からのマージされていない変更
前:
        uniqueidentifier = Documents.DefaultValues.UniqueIdentifier;
後:
        uniqueidentifier = DefaultValues.UniqueIdentifier;
*/
        uniqueidentifier = Helpers.DefaultValues.UniqueIdentifier;
    }
}
