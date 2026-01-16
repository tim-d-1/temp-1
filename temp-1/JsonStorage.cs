using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization.Metadata;

namespace temp_1;

internal class JsonStorage : IStorage
{
    public async Task WriteAsync(string data)
    {
        using FileStream SourceStream = File.Open("data.json", FileMode.Open);

        await JsonSerializer.SerializeAsync(SourceStream, data);
    }

    public async Task<string> ReadAsync()
    {
        using FileStream SourceStream = File.Open("data.json", FileMode.OpenOrCreate);

        return (string) await JsonSerializer.DeserializeAsync(SourceStream, (new JsonSerializerOptions()).GetTypeInfo(typeof(string)));
    }
}
