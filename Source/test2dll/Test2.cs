﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test2dll
{
    public delegate void TestDelegage(List<int> list, bool add);

    public class Test2
    {
        public static readonly Test2 single = new Test2();

        private TestDelegage func;

        public void Register(TestDelegage f)
        {
            func = f;
        }

        public void Add(List<int> list, bool add)
        {
            func?.Invoke(list, add);
        }
    }
}
