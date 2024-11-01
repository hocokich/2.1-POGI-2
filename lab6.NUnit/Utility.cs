using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.NUnit
{
    internal class Utility
    {
        public int Convert(float num, string unit)
        {
            if (num <= 0 && num <= float.MaxValue) throw new ArgumentException("Число должно быть > 0 < MaxValue");

            if (unit == "inch")
                return (int)(num * 2.5);
            if (unit == "cm")
                return (int)(num / 2.5);
            else throw new ArgumentException("unit должен быть inch || cm");
        }
        public bool DefineOrOddNum(int num)
        {
            return num % 2 == 0;
        }
        public int BiggestNum(int[] num) 
        {
            if(num == null) throw new ArgumentException("Массив не должен быть null");
            return num.Max();
        }
        public int Remainder(int a, int b)
        {
            if (b <= 0) throw new ArgumentException("Делитель должен быть > 0");
            return a % b;
        }
    }
}