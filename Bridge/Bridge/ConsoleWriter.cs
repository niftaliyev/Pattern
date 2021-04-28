namespace Bridge
{
    class ConsoleWriter : IWriter
    {
        public void Write(string mesage)
        {
            System.Console.WriteLine(mesage);
        }
    }
}
