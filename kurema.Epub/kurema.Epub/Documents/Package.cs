namespace kurema.Epub.Documents;
#nullable enable
public class Package
{
    public Xml.Epub30.Package.package Xml { get; } = new Xml.Epub30.Package.package()
    {
        spine= new Xml.Epub30.Package.spine(),
        metadata=new Xml.Epub30.Package.opfpackagecontentMetadata(),
    };

    public Xml.Epub30.Package.spinePageprogressiondirection? Direction
    {
        get
        {
            if (Xml.spine is null) Xml.spine = new Xml.Epub30.Package.spine();
            return Xml.spine.pageprogressiondirection;
        }
    }
}
