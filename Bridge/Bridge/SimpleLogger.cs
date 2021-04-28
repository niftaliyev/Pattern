using System;

namespace Bridge
{
    class SimpleLogger : ILoger
    {
        public SimpleLogger(IWriter writer) : base(writer)
        {

        }    
        public override void LogError(string mesage)
        {
            writer.Write($"Error: {mesage}");
        }

        public override void LogInfo(string mesage)
        {
            writer.Write($"Info: {mesage}");
        }

        public override void LogWarning(string mesage)
        {
            writer.Write($"Warning: {mesage}");
        }
    }
}
