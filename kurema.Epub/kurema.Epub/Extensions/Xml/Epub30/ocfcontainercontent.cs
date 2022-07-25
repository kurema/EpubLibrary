using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.OcfContainer
{
    partial class ocfcontainercontent
    {
        public void AddRootFile(params rootfile[] newItems)
        {
            Helpers.Functions.AddItemsToArray(ref rootfilesField, newItems);
        }

        public void AddLink(params link[] newItems)
        {
            Helpers.Functions.AddItemsToArray(ref linksField, newItems);
        }
    }
}
