using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
    class IntegerText
    {
        char[] txtNumber;

        public char this[int idx]
        {
            get { return txtNumber[txtNumber.Length - (idx + 1)]; }
            set { txtNumber[txtNumber.Length - (idx + 1)] = value; }
        }

        public IntegerText(int number)
        {
            txtNumber = number.ToString().ToCharArray();
        }
        public char GetPointNumber(int Point)
        {
            return txtNumber[txtNumber.Length - (Point +1)];
        }
    }
    class Indexer1
    {
        static void Main()
        {
            IntegerText c1 = new IntegerText(123456);

            int step = 1;
            for(int i=0; i < 6; i++)
            {
                //Console.WriteLine($"{step}의 자릿수" + c1.GetPointNumber(i));
                Console.WriteLine($"{step}의 자릿수" + c1[i].ToString());

                
                step = step * 10;
            }
            

        }
    }
}
