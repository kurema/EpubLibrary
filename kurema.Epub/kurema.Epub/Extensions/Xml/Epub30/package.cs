using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Xml.Epub30.Package
{
    partial class package
    {
        public package()
        {
            spine = new spine();
            manifest=new manifest();
            metadata = new opfpackagecontentMetadata();
            
        }
    }
}
