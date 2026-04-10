using System;
using System.Collections.Generic;
using System.Text;

namespace TeknologiProjekt
{
    class AutoClicker
    {
        private readonly CancellationTokenSource _tokenSource;
        private readonly CancellationToken _token;
        private readonly Thread t;
        private static readonly Semaphore _semaphore = new Semaphore(1, 100);

        public AutoClicker()
        {
            _tokenSource = new CancellationTokenSource();
            _token = _tokenSource.Token;
            t = new Thread(Start);
            t.Start(); 
        }

        private void Start()
        {
            _semaphore.WaitOne();
            try
            {
                _tokenSource.CancelAfter(25000);
                while (!_token.IsCancellationRequested)
                {
                    Points.AddPoints();
                    Thread.Sleep(2000);
                }
            } 
            finally 
            { 
                _semaphore.Release(); 
            }

        }
    }
}
