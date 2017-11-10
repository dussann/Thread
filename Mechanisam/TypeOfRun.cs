using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanisam
{
    public abstract class TypeOfRun
    {

        public IRun Run { get; set; }

        public TypeOfRun(IRun run)
        {
            Run = run;
        }

        public abstract void RunFunctions(List<Action> listOfFunctions);
    }
}
