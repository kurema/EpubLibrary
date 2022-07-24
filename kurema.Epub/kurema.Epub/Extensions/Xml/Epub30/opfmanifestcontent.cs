using System;

namespace kurema.Epub.Xml.Epub30.Package;

partial class opfmanifestcontent
{
    public opfmanifestcontent()
    {
    }

    public void AddItems(params item[] newItems)
    {

/* プロジェクト 'kurema.Epub (NET6.0)' からのマージされていない変更
前:
        Documents.Functions.AddItemsToArray(ref this.itemField, newItems);
後:
        Functions.AddItemsToArray(ref this.itemField, newItems);
*/
        Epub.Helpers.Functions.AddItemsToArray(ref this.itemField, newItems);
    }
}
