using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

#nullable enable

namespace kurema.Epub.Documents;

public interface IFileItem
{
    void WriteToStream(Stream stream);
    string Name { get; }
}

public class FileItemSerializer<T> : IFileItem where T : class
{
    public FileItemSerializer(string name, T? value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
    }

    public T? Value { get; set; }

    public string Name { get; }

    public void WriteToStream(Stream stream)
    {
        var xs = new XmlSerializer(typeof(T));
        var sw = new StreamWriter(stream);
        xs.Serialize(sw, Value);
    }
}

public class FileItemDelegate : IFileItem
{
    public FileItemDelegate(string name, Func<Stream?>? provider)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        StreamProvider = provider;
    }

    public string Name { get; }
    public Func<Stream?>? StreamProvider { get; }

    public void WriteToStream(Stream stream)
    {
        throw new NotImplementedException();
    }
}