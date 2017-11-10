using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanisam
{
    public interface IRun
    {
        void RunFunctions(List<Action> listOfFunctions);
    }
}
