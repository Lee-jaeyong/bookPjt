using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace bookPjt
{
    class CheckStatus
    {
        void DoTest()
        {
            // 새로운 쓰레드에서 Run() 실행
            Thread chkThead = new Thread(new ThreadStart(Run));
            chkThead.Start();

            Run();
        }

        void Run()
        {
            Console.WriteLine("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId);
            // Do Something
            Thread.Sleep(3000);
            Console.WriteLine("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
