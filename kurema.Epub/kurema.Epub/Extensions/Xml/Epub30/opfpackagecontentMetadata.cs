using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package;

partial class opfmetadatacontent1
{

    public void AddItems(params IMetadataItem[] newItems)
    {

/* プロジェクト 'kurema.Epub (NET6.0)' からのマージされていない変更
前:
        Documents.Functions.AddItemsToArray(ref itemsField, newItems);
後:
        Functions.AddItemsToArray(ref itemsField, newItems);
*/
        Epub.Helpers.Functions.AddItemsToArray(ref itemsField, newItems);
    }

    public void UpdateItemOfSameType<T>(T value, Func<T, bool> judge = null) where T : IMetadataItem
    {
        if (value is null) goto nomatch;
        for (int i = 0; i < this.Items.Length; i++)
        {
            var item = this.Items[i];
            if (item is T itemT && (judge?.Invoke(itemT) ?? true))
            {
                Items[i] = value;
                return;
            }
        }
    nomatch:;
        AddItems(value);
    }

    public void SetRequiredValues(string identifier, string title, string language)
    {
        //This is not good in performance. Array.Resize() is called three times.

/* プロジェクト 'kurema.Epub (NET6.0)' からのマージされていない変更
前:
        UpdateItemOfSameType(new identifier() { id = Documents.DefaultValues.UniqueIdentifier, Value = identifier }, v => v.id == Documents.DefaultValues.UniqueIdentifier);
        UpdateItemOfSameType(new title() { id = Documents.DefaultValues.IdTitleMain, Value = title }, v => v.id == Documents.DefaultValues.IdTitleMain);
        UpdateItemOfSameType(new language() { id = Documents.DefaultValues.IdLanguageMain, Value = language }, v => v.id == Documents.DefaultValues.IdLanguageMain);
後:
        UpdateItemOfSameType(new identifier() { id = DefaultValues.UniqueIdentifier, Value = identifier }, v => v.id == DefaultValues.UniqueIdentifier);
        UpdateItemOfSameType(new title() { id = DefaultValues.IdTitleMain, Value = title }, v => v.id == DefaultValues.IdTitleMain);
        UpdateItemOfSameType(new language() { id = DefaultValues.IdLanguageMain, Value = language }, v => v.id == DefaultValues.IdLanguageMain);
*/
        UpdateItemOfSameType(new identifier() { id = Helpers.DefaultValues.UniqueIdentifier, Value = identifier }, v => v.id == Helpers.DefaultValues.UniqueIdentifier);
        UpdateItemOfSameType(new title() { id = Helpers.DefaultValues.IdTitleMain, Value = title }, v => v.id == Helpers.DefaultValues.IdTitleMain);
        UpdateItemOfSameType(new language() { id = Helpers.DefaultValues.IdLanguageMain, Value = language }, v => v.id == Helpers.DefaultValues.IdLanguageMain);
    }
}

public interface IMetadataItem { }

partial class contributor : IMetadataItem { }
partial class coverage : IMetadataItem { }
partial class creator : IMetadataItem { }
partial class date : IMetadataItem { }
partial class description : IMetadataItem { }
partial class format : IMetadataItem { }
partial class identifier : IMetadataItem { }
partial class language : IMetadataItem { }
partial class publisher : IMetadataItem { }
partial class relation : IMetadataItem { }
partial class rights : IMetadataItem { }
partial class source : IMetadataItem { }
partial class subject : IMetadataItem { }
partial class title : IMetadataItem { }
partial class type : IMetadataItem { }
partial class opfmetadatacontentLink : IMetadataItem { }
partial class opfmetadatacontentMeta : IMetadataItem { }
