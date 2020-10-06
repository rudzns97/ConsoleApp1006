using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
    class Preprocessor1
    {
        static void Main()
        {
#if DEBUG
            string name = "홍길동";
            string pwd = "1234";
#endif
            Debug.WriteLine(name);

            Console.ReadLine();
        }
    }
}
