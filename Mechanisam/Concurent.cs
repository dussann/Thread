using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mechanisam
{
    public class Concurent : IRun
    {
        public void RunFunctions(List<Action> listOfFunctions)
        {
            foreach (var function in listOfFunctions)
            {
                Thread t = new Thread(new ThreadStart(function));
                t.Start();
            }
        }
    }
}
