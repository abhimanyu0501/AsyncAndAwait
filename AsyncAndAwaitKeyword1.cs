using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConcept
{
    class AsyncAndAwaitKeyword1
    {
static void Main(String[] args)
        {
            Method1();
            method2();
            Console.ReadKey();

        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
               for(int i=0;i<100;i++)
                {
                    Console.WriteLine("Method1");
                }
            });
        }

        public static void method2()
        {
            for(int i=0;i<25;i++)
            {
                Console.WriteLine("Method2");
            }
        }

        


    }
}
