using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    class AsyncAndAwaitKeyword
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Starting");
            var worker = new Worker();
            worker.DoWork();
            while(!worker.IsComplete)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Done");
            Console.ReadKey();

        }
    }

    class Worker
    {
        public bool IsComplete { get; private set; }

        public async void DoWork()
        {
            this.IsComplete = false;
            Console.WriteLine("Doing Work");
            //the method body after this point will execute normal.and the long operation will execute asynchronously.
            //and rest of the application will continue execute.when long operation is done executing whatever it needs 
            //to do the remainder of the do work.method body then execute because we cannot await a void method.we need 
            //long operation to return a task.
            await LongOperation();
            Console.WriteLine("work completed");
            IsComplete = true;
        }

        public Task LongOperation()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Working!");
                Thread.Sleep(2000);
            }
            );
            
        }
    }
}
