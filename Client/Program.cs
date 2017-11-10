using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mechanisam;

namespace Client
{
    class Program
    {
        public static void Function1()
        {
            Console.WriteLine("aaaaaaaa");
        }

        public static void Function2()
        {
            Console.WriteLine("eeeeeeee");
        }


        static void Main(string[] args)
        {
            RegisterFunction.Register(Function1);
            RegisterFunction.Register(Function2);

            LoopOne l = new LoopOne(new Sequential());
            l.RunFunctions(RegisterFunction.lista);
        }
    }
}
