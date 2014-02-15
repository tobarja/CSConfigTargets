using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConfigTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            string Config;
#if (PROD)
            Config = "Production";
#elif (TEST)
            Config = "Testing";
#else
            Config = "Development";
#endif
            Console.WriteLine(Config);
            Console.ReadKey();
        }
    }
}
