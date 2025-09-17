
using System;
using System.IO;
using System.Threading.Tasks;

namespace FileProcessorLib
{
    // Async streaming implementation to avoid blocking thread pool for large files.
    public class FileProcessor
    {
        public async Task<int> GetFileLengthAsync(string path)
        {
            using var reader = new StreamReader(path);
            int length = 0;
            char[] buffer = new char[4096];
            int read;
            while ((read = await reader.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                length += read;
            }
            return length;
        }
    }
}
