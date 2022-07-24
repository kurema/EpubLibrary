using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

#nullable enable

namespace kurema.Epub.Documents;

public interface IFileItem
{
    Task WriteToStream(Stream stream);
    string Name { get; set; }
}

public class FileItemSerializer<T> : IFileItem where T : class
{
    public FileItemSerializer(string name, T? value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
    }

    public T? Value { get; set; }

    public string Name { get; set; }

    public Task WriteToStream(Stream stream)
    {
        var xs = new XmlSerializer(typeof(T));
        var sw = new StreamWriter(stream);
        xs.Serialize(sw, Value);
        return Task.CompletedTask;
    }
}

public class FileItemString : IFileItem
{
    public FileItemString(string name, string content, Encoding? encoding = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        if (content is null) throw new ArgumentException(nameof(content));
        Content = new StringBuilder(content);
        Encoding = encoding ?? Encoding.UTF8;
    }

    public string Name { get; set; }
    public StringBuilder Content { get; }

    public Encoding Encoding { get; set; }

    public async Task WriteToStream(Stream stream)
    {
        var sw = new StreamWriter(stream, Encoding);
        await sw.WriteAsync(Content.ToString());
    }
}

public class FileItemDelegate : IFileItem
{
    public FileItemDelegate(string name, Func<Stream?>? provider)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        StreamProvider = provider;
    }

    public string Name { get; set; }
    public Func<Stream?>? StreamProvider { get; set; }

    public async Task WriteToStream(Stream stream)
    {
        if (StreamProvider is null) return;
        var result = StreamProvider.Invoke();
        if (result is null) return;
        await result.CopyToAsync(stream);
    }
}