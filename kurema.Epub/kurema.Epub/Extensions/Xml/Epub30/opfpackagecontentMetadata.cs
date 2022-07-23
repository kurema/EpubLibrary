using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package;

partial class opfpackagecontentMetadata
{
    public const string IdTitleMain = "main-title";
    public const string IdLanguageMain = "main-language";

    public opfpackagecontentMetadata()
    {
        Items = new IMetadataItem[0];
    }

    public void AppendItem(IMetadataItem item)
    {
        if (Items is null)
        {
            Items = new IMetadataItem[] { item };
            return;
        }
        var itemsTmp = this.Items;
        Array.Resize(ref itemsTmp, Items.Length + 1);
        itemsTmp[Items.Length - 1] = item;
        this.Items = itemsTmp;
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
        AppendItem(value);
    }

    public void SetRequiredValues(string identifier, string title, string language)
    {
        UpdateItemOfSameType(new identifier() { id = package.DefaultUniqueIdentifier, Value = identifier }, v => v.id == package.DefaultUniqueIdentifier);
        UpdateItemOfSameType(new title() { id = IdTitleMain, Value = title }, v => v.id == IdTitleMain);
        UpdateItemOfSameType(new language() { id = IdLanguageMain, Value = language }, v => v.id == IdLanguageMain);
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
partial class link : IMetadataItem { }
partial class meta : IMetadataItem { }
