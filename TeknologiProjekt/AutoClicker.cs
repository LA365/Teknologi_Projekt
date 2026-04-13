using System;
using System.Collections.Generic;
using System.Text;

namespace TeknologiProjekt
{
    public class AutoClicker
    {
        private readonly CancellationTokenSource _tokenSource;
        private readonly CancellationToken _token;
        private readonly Thread t;
        private static readonly Semaphore _semaphore = new Semaphore(1, 100);
        private readonly Action _updateUI;

        public AutoClicker(Action updateUI)
        {
            _updateUI = updateUI;
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
                _tokenSource.CancelAfter(2500);
                while (!_token.IsCancellationRequested)
                {
                    Points.AddPoints();
                    _updateUI.Invoke();
                    Thread.Sleep(500);
                }
            } 
            finally 
            { 
                _semaphore.Release(); 
            }

        }
    }
}
