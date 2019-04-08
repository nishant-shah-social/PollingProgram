using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QueuePolling2
{
    public class Worker
    {
        public async Task performTaskAndKeepPolling(Queue<BankQueue> myqueue)
        {
            myqueue.Dequeue();
            Thread.Sleep(1000);

            //polling the queue once worker gets free
            while(myqueue.Count != 0)
            {                
                await performTaskAndKeepPolling(myqueue);
            }
        }
    }
}
