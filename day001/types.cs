using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본 자료형 1byte(8bit)
            sbyte a = -128;  //-128 ~ 127
            byte b = 255;  //0 ~ 255

            Console.WriteLine($"a={a},b={b}");

            //2byte(16bit)

            short c = -32768;   //-32768 ~ 32767
            ushort d = 65535;   //0 ~ 65535

            Console.WriteLine($"c={c},d={d}");

            //4byte(32bit)

            int e = -214783648; //-2147483648 ~ 2147483647
            uint f = 4294967295;    // 0 ~ 4294967295

            Console.WriteLine($"e={e}, f={f}");

            //8byte(64bit)

            long g = -5000_0000_0000; //0이 11개
            ulong h = 200_0000_0000_0000_0000; //0이 18개

            Console.WriteLine($"g = {g} , h = {h}")

            //52p.

            byte = 240; //240 --> 리터럴

        }
    }
}
