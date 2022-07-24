using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Helpers;

public static class DefaultValues
{
    public const string UniqueIdentifier = "pub-id";
    public const string IdTitleMain = "main-title";
    public const string IdLanguageMain = "main-language";

    public const string PathMimetype = "mimetype";

    public const string PathContentsDir = "EPUB/";
    public const string PathPackage = PathContentsDir + "package.opf";

    public const string PathMetaInfDir = "META-INF/";
    public const string PathContainer = PathMetaInfDir + "container.xml";
    public const string PathSignatures = PathMetaInfDir + "signatures.xml";
    public const string PathEncryption = PathMetaInfDir + "encryption.xml";
    public const string PathManifest = PathMetaInfDir + "manifest.xml";
    public const string PathMetadata = PathMetaInfDir + "metadata.xml";
    public const string PathRights = PathMetaInfDir + "rights.xml";

    public const string ContentMimetype = "application/epub+zip";
}
