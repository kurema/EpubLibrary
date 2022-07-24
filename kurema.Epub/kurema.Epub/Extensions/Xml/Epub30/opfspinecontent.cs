namespace kurema.Epub.Xml.Epub30.Package;

partial class opfspinecontent
{
    public void AddItems(params itemref[] newItems)
    {

/* プロジェクト 'kurema.Epub (NET6.0)' からのマージされていない変更
前:
        Documents.Functions.AddItemsToArray(ref itemrefField, newItems);
後:
        Functions.AddItemsToArray(ref itemrefField, newItems);
*/
        Epub.Helpers.Functions.AddItemsToArray(ref itemrefField, newItems);
    }
}