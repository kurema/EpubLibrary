using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Documents;

public class Archive
{
    public Package PackagePrimary { get; set; }
    public List<Package> PackageAdditional { get; } = new List<Package>() { };
}
