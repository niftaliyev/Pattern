using System.IO;
using System.Text.Json;

namespace Bridge
{
    class FileWriter : IWriter
    {
        public void Write(string mesage)
        {
            var json = JsonSerializer.Serialize(mesage);
            File.WriteAllText("text.json", json);
        }
    }
}
