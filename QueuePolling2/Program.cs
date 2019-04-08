using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePolling2
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructing the Bank Queue
            Queue<BankQueue> myQueue = new Queue<BankQueue>();
            myQueue.Enqueue(new BankQueue());
            myQueue.Enqueue(new BankQueue());
            myQueue.Enqueue(new BankQueue());

            //Initializing workers
            Worker w1 = new Worker();
            Worker w2 = new Worker();
            Worker w3 = new Worker();

            //sending items from queue to all the workers
            Task t =  w1.performTaskAndKeepPolling(myQueue);
            Task t2 = w2.performTaskAndKeepPolling(myQueue);
            Task t3 = w3.performTaskAndKeepPolling(myQueue);
        }


    }
}
