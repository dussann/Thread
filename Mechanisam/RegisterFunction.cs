using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanisam
{
    public class RegisterFunction
    {
        public static List<Action> lista = new List<Action>();

        public RegisterFunction()
        {

        }

        public static void Register(Action function)
        {
            lista.Add(function);
        }
    }
}
