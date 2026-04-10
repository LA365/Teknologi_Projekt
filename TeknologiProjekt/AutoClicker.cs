using System;
using System.Collections.Generic;
using System.Text;

namespace TeknologiProjekt
{
    class AutoClicker
    {
        private readonly CancellationToken _token;
        private readonly Thread t;
        private static readonly Semaphore _semaphore = new Semaphore(1, 100);

        //public AutoClicker(CancellationToken token)
        //{
        //    _token = token;
        //    t = new Thread(Start);
        //}
        //static void Start(CancellationToken token)
        //{
        //    _semaphore.WaitOne();
        //    async Killer.Kill(_token);

        //    while(_token.IsCancellationRequested)
        //    {
        //        Points.AddPoints();
        //        Thread.Sleep(2000);
        //    }
        //}
    }
}
