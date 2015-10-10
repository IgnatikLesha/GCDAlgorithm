using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GCDAlgorithms
{
    public class GCDAlgorithm
    {
    public static void Swap(int a, int b)
    {
        int c = a;
        a = b;
        b = c;
    }

        public static int GCDof2Numbers(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == b)
                return a;
            if (a == 1)
                return b;
            if (b == 1)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (b > a)
                Swap(a, b);

            while (b != 0)
            {
                a = a % b;
                Swap(a, b);
            }
            return a;
        }

        public static int GCDPlusTime(int a, int b, out double time)
        {
            int result = 1;
            var timer = Stopwatch.StartNew();
            result = GCDof2Numbers(a, b);
            timer.Stop();
            time = timer.ElapsedMilliseconds;
            return result;
        }

        public static int GCDGeneral(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("There is no numbers") ;
            if (numbers == null)
                throw new ArgumentNullException("Null reference");
            if (numbers.Length == 1)
                return numbers[0];

            int gcd = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                gcd = GCDof2Numbers(numbers[i], numbers[i + 1]);
            }
            return gcd;
        }

        public static int GCDBinary(int a, int b)
        {

            a = Math.Abs(a);
            b = Math.Abs(b);
            // simple cases (termination)
            if (a == b)
                return a;

            if (a == 0)
                return b;

            if (b == 0)
                return a;

            // look for factors of 2
            if (a % 2 == 0) // u is eben
            {
                if (b % 2 != 0) // b is odd
                    return GCDBinary(a >> 1, b);
                else // both u and b are eben
                    return GCDBinary(a >> 1, b >> 1) << 1;
            }

            if (b % 2 == 0) // u is odd, b is eben
                return GCDBinary(a, b >> 1);

            // reduce larger argument
            if (a > b)
                return GCDBinary((a - b) >> 1, b);

            return GCDBinary((b - a) >> 1, a);
            
        }

        public static int GCDBinaryGeneral(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("There is no numbers");
            if (numbers == null)
                throw new ArgumentNullException("Null reference");
            if (numbers.Length == 1)
                return numbers[0];

            int gcd = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                gcd = GCDBinary(numbers[i], numbers[i + 1]);
            }
            return gcd;
        }

    }
}
