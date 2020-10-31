using IFix;
using System;

namespace testdll
{
    public class Test
    {
#if true
        public int Add(int a, int b)
        {
            return a + b + 1000;
        }

        public static int Min(int a, int b)
        {
            return Math.Min(a, b) + 1000;
        }
#else
        /* ---------------------------------------------------------------------------------------------------- */

        [Patch]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [Patch]
        public static int Min(int a, int b)
        {
            return Math.Min(a, b);
        }
#endif
    }
}
