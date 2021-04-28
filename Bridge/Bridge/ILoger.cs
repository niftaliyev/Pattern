namespace Bridge
{
    abstract class ILoger
    {
        protected IWriter writer;
        public ILoger(IWriter writer)
        {
            this.writer = writer;
        }
        public abstract void LogInfo (string mesage);
        public abstract void LogWarning (string mesage);
        public abstract void LogError (string mesage);

    }
}
