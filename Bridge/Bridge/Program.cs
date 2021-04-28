namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoger loger = new SimpleLogger(new ConsoleWriter());
            loger.LogInfo("TEST");
        }
    }
}
