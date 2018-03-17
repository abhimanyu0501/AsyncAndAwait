using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace LoopConcept
{
    class AsyncAndAwaitKeywordBasic1
    {

        static void Main(String[] args)
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
            string filePath = "F:\\git\\EventAndDelegate\\logger.txt";
            //Task<int> task = ReadFile(filePath);
            int task = ReadFile(filePath);
            Console.WriteLine("Other Work 1");
            Console.WriteLine("Other Work 1");
            Console.WriteLine("Other Work 1");

            //int length = await task;
            int length =  task;
            Console.WriteLine(" Total length: "+length);

            Console.WriteLine("after work 2");
            Console.WriteLine("after work 2");

        }

        //static async Task<int> ReadFile(string file)
        static  int ReadFile(string file)
        {
            int length = 0;
            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                //string s = await reader.ReadToEndAsync();
                string s = reader.ReadToEnd();
                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
