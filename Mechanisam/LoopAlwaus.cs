using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanisam
{
    public class LoopAlwaus : TypeOfRun
    {
        public LoopAlwaus(IRun run) : base(run)
        {
        }

        public override void RunFunctions(List<Action> listOfFunctions)
        {
            bool run = true;
            while (run)
            {
                Run.RunFunctions(listOfFunctions);
            }

        }


    }
}
