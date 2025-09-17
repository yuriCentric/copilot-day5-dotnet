using FileProcessorLib;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Example usage of FileProcessor
        var processor = new FileProcessor();
        string tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".txt");
        await File.WriteAllTextAsync(tempPath, "hello world");
        int length = await processor.GetFileLengthAsync(tempPath);
        System.Console.WriteLine($"FileProcessorApp is running. File length: {length}");
        File.Delete(tempPath);
    }
}
