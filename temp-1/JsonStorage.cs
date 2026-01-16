using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace temp_1;

internal class JsonStorage : IStorage
{
    public async Task WriteAsync(string data)
    {
        using FileStream SourceStream = File.Open("data.json", FileMode.Open);

        await JsonSerializer.SerializeAsync(SourceStream, data);

    }
}
