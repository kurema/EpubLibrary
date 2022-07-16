using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package
{
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
    }

    partial class opfpackagecontentMetadata
    {
        public opfpackagecontentMetadata()
        {
            Items = new object[0];
        }
    }
}
