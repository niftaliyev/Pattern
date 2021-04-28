using System;

namespace Bridge
{
    class DetailedLogger : ILoger
    {
        string time = DateTime.Now.ToString();
        public DetailedLogger (IWriter writer) : base(writer)
        {
            
        }
        public override void LogError(string mesage)
        {
            writer.Write($"Type: Error\nTime: {time}\nMessage: {mesage}");
        }

        public override void LogInfo(string mesage)
        {
            writer.Write($"Type: Info\nTime: {time}\nMessage: {mesage}");

        }

        public override void LogWarning(string mesage)
        {
            writer.Write($"Type: Warning\nTime: {time}\nMessage: {mesage}");

        }
    }
}
