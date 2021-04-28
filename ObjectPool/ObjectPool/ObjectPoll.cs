using System.Collections.Generic;

namespace ObjectPool
{
    class ObjectPoll : IObjectPoll<Pool>
    {
        Queue<Pool> queue = new Queue<Pool>();
        public Pool Get()
        {
            if (queue.Count >0)
            {

                return queue.Dequeue();
            }
            else
            {
                return new Pool();
            }
        }

        public void Return(Pool obj)
        {
            queue.Enqueue(obj);
        }

        public void Add(Pool obj)
        {
            queue.Enqueue(obj);
        }
    }
}
