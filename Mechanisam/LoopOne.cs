using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanisam
{
    public class LoopOne : TypeOfRun
    {
        public static List<Action> listOfFunctions;
        public LoopOne(IRun run) : base(run)
        {
        }

        public override void RunFunctions(List<Action> listOfFunctions)
        {
            Run.RunFunctions(listOfFunctions);
        }
    }
}
