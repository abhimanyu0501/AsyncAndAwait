using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LoopConcept
{
    class AsuncAndAwaitKeywordBasics
    {
        /*
        Task<string> MyTask()
        {
            return Task.Run<string>( ()=> { Thread.Sleep(2000); return "y"; });
        }
        */

        Task<string> MyTask()
        {
            return Task.Run( () => { Thread.Sleep(2000); return "y"; });
        }

        async void MyTaskAsync()
        {
            string result = await MyTask();
            Console.Write(result);
        }

        static void Main(String[] args)
        {
 new AsuncAndAwaitKeywordBasics().MyTaskAsync();
            Console.Write("X");
            Console.ReadKey();

        }
    }
}
