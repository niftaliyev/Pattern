using System;
using System.Collections;

namespace ObjectPool
{



    class Program
    {
        static void Main(string[] args)
        {
            ObjectPoll objectPoll = new ObjectPoll();
            objectPoll.Return(new Pool { X = 5, Y = 6 });
            objectPoll.Return(new Pool { X = 7, Y = 8 });
            objectPoll.Return(new Pool { X = 1, Y = 2 });
            Console.WriteLine(objectPoll.Get());
            Console.WriteLine(objectPoll.Get());


            Pool pool1 = new Pool();
            Pool pool2 = new Pool();
            Pool pool3 = new Pool();
            Pool pool4 = new Pool();

            pool1 = objectPoll.Get();

            Console.WriteLine(pool1);
            objectPoll.Return(pool1);
            pool2 = objectPoll.Get();

            Console.WriteLine(pool2);

            pool3 = objectPoll.Get();

            Console.WriteLine(pool3);

            objectPoll.Return(pool2);

            pool4 = objectPoll.Get();

            Console.WriteLine(pool4);


        }
    }
}
