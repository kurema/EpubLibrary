using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.OcfContainer
{
    partial class ocfcontainercontent
    {
        public void AddRootFiles(params rootfile[] newItems)
        {
            Helpers.Functions.AddItemsToArray(ref rootfilesField, newItems);
        }

        public void AddLinks(params link[] newItems)
        {
            Helpers.Functions.AddItemsToArray(ref linksField, newItems);
        }
    }
}
