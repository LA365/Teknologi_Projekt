using System;
using System.Collections.Generic;
using System.Text;

namespace TeknologiProjekt
{
    public static class Killer
    {
        public async static void KillAsync(CancellationToken token)
        {
            Thread.Sleep(25000);
            //token.Cancel = true;
        }
    }
}
