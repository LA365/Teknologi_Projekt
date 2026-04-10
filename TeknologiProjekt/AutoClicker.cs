using System;
using System.Collections.Generic;
using System.Text;

namespace TeknologiProjekt
{
    class AutoClicker
    {
        readonly Thread t;
        int Duration { get; set; }
        CancellationToken token;

        public AutoClicker(CancellationToken token)
        {
            t = new Thread(Start);
            this.token = token;
        }
        void Start()
        {
        }
    }
}
