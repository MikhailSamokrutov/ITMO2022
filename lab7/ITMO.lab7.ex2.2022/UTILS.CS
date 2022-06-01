using System;

namespace lab7.ex2
{
    public class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(out int answer, int n)
        {
            int k;
            int f;
            bool ok = true;
            if (n < 0)
                ok = false;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;

            }
            answer = f;
            return ok;


        }

        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
            {
                sRev = sRev + s[k];
            }

            s = sRev;
        }
    }
}