using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadPoolDemo
{
    class FileThreadPool
    {

    }
    class ThreadInfo
    {
        public string FileName { get; set; }
        public int SelectedIndex { get; set; }
    }

    public class Example
    {
        public Example()
        {
            // Declare a new argument object.
            ThreadInfo threadInfo = new ThreadInfo();
            threadInfo.FileName = "file.txt";
            threadInfo.SelectedIndex = 3;

            // Send the custom object to the threaded method.
            ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessFile), threadInfo);
        }
        public void DoWork(int x, CancellationToken cancellationToken)
        {
            {
                Console.WriteLine("launching {0} tasks...", x);
            }
        }

        private void ProcessFile(object a)
        {
            // Constrain the number of worker threads
            // (Omitted here.)

            // We receive the threadInfo as an uncasted object.
            // Use the 'as' operator to cast it to ThreadInfo.
            ThreadInfo threadInfo = a as ThreadInfo;
            string fileName = threadInfo.FileName;
            int index = threadInfo.SelectedIndex;
            Console.WriteLine(index);
            Console.WriteLine(fileName);
        }
    }
}
