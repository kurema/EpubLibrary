namespace kurema.Epub.Helpers;

#nullable enable
public static class Mimetypes
{
    public const string Epub = DefaultValues.ContentMimetype;

    //https://www.w3.org/publishing/epub32/epub-spec.html#sec-cmt-supported
    public const string Gif = "image/gif";
    public const string Jpeg = "image/jpeg";
    public const string Png = "image/png";
    public const string Svg = "image/svg+xml";
    public const string Mp3 = "audio/mpeg";
    public const string Mp4Aac = "audio/mp4";

    public const string Css = "text/css";

    public const string TrueType = "font/ttf";
    public const string FontSfnt = "application/font-sfnt";
    public const string OpenType = "font/otf";
    public const string OpenTypeApp = "application/vnd.ms-opentype";
    public const string Woff = "font/woff";
    public const string WoffApp = "application/font-woff";
    public const string Woff2 = "font/woff2";

    public const string Xhtml = "application/xhtml+xml";
    public const string JavaScriptApp = "application/javascript";
    public const string JavaScript = "text/javascript";

    public const string Ncx = "application/x-dtbncx+xml";
    public const string MediaOverlay = "application/smil+xml";
    public const string PronunciationLexiconSpecification = "application/pls+xml";

    public static string? GetMimetypeFromPath(string path)
    {
        return GetMimetypeFromExtension(System.IO.Path.GetExtension(path));
    }

    public static string? GetMimetypeFromExtension(string extension)
    {
        if (!extension.StartsWith(".")) extension = "." + extension;
        return extension.ToUpperInvariant() switch
        {
            ".GIF" => Gif,
            ".JPG" or ".JPEG" or ".JPE" or ".JFIF" => Jpeg,
            ".PNG" => Png,
            ".SVG" => Svg,
            ".MP3" => Mp3,
            ".CSS" => Css,
            ".TTF" => TrueType,
            ".WOFF" => Woff,
            ".WOFF2" => Woff2,
            ".HTM" or ".HTML" or ".XHTML" or ".XHT" => Xhtml,
            ".JS" => JavaScript,
            ".NCX" => Ncx,
            ".SMIL" => MediaOverlay,
            ".PLS" => PronunciationLexiconSpecification,
            _ => null,
        };
    }
}