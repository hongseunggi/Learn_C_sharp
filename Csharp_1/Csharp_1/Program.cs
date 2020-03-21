using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_1
{
    class CS
    {
        int global;
        const int Max = 1024;
        public void Method()
        {
            int local;
            local = 200; // if Do not give init local var, program will be crashed
            Console.WriteLine("init global var : {0}",global);
            Console.WriteLine("Local var : {0}",local);
            try
            {
                global = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine only read string so convert to int format
            }
            catch(Exception error)
            {
                Console.WriteLine("입력이 올바르지 않습니다.\n"+error);
                return;
            }
            Console.WriteLine("input num : {0}",global);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CS obj = new CS();
            obj.Method();
        }
    }
}
