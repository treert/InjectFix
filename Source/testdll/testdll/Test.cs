using IFix;
using System;
using System.Collections.Generic;

namespace testdll
{
    //public delegate int TestDelegate(int a, bool b);
    ////[CustomBridge]
    //public static class AdditionalBridge
    //{
    //    static List<Type> bridge = new List<Type>()
    //    {
    //        typeof(TestDelegate),
    //        typeof(test2dll.TestDelegage),
    //        typeof(IEnumerator<long>),
    //        typeof(IEnumerable<double>),
    //        typeof(Action<int, float, double, char>),
    //    };
    //}

    public class Temp<T> where T : new()
    {
        public T obj;

        public T yy
        {
            get => obj;
        }

        public virtual T HH()
        {
            return obj;
        }
    }

    public struct StructA
    {
        public int a;
    }

    public class BB : Temp<int>
    {

        public override int HH()
        {
            return base.HH();
        }
        public int xx
        {
            get { return obj; }
        }
        public BB()
        {
            obj = 2;
        }

        public void FF()
        {
            Console.WriteLine(obj);
        }
    }
    public class Test
    {
        public List<int> m_list = new List<int>() { 2};
        public Test()
        {
        }

        public Func<int> TestAction()
        {
            int a = 0;
            Func<int> f = () =>
            {
                return a++;

            };
            return f;
        }

        public int TestSet()
        {
            int a = 1, b = 1;
            Set(out a, ref b);
            return a + b;
        }

        public void Set(out int a, ref int b)
        {
            a = 2;
            b = 3;
        }

        private void hhh()
        {

        }

        private void hhh(int a)
        {

        }

        public static T Def<T>() where T : new()
        {
            return new Temp<T>().obj;
        }

        public static void haha()
        {
            {
                var obj = new Temp<DateTime>();
            }
            {
                var obj = new Temp<Test>();
            }

        }

        [IFix.Patch]
        public static int TestStruct()
        {
            StructA a = new StructA();
            // StructA a;
            a.a = 1;
            return a.a;
        }

        [IFix.Patch]
        public int TestDll2()
        {
            //test2dll.Test2.single.Register((ls, add) =>
            //{
            //    ls.Clear(); ls.Add(200);
            //});

            //test2dll.Test2.single.Register(TestDll2_func);

            test2dll.Test2.single.Add(m_list, true);
            return m_list[0];
        }

        //[IFix.Interpret]
        //private static void TestDll2_func(List<int> list, bool add)
        //{
        //    list.Clear();list.Add(100);
        //}

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
