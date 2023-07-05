namespace kurema.Epub.Xml.Epub30.Package;

partial class opfspinecontent
{
    public void AddItems(params itemref[] newItems)
    {
        Helpers.Functions.AddItemsToArray(ref itemrefField, newItems);
    }
}