namespace ObjectPool
{
    interface IObjectPoll<T>
    {
        T Get();
        void Return (T obj);
    }
}
