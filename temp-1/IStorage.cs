using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp_1
{
    internal interface IStorage
    {
        public Task WriteAsync(string data);

        public Task<string> ReadAsync();
    }
}
