using IFix;
using System;

namespace testdll
{
    public class Temp<T>where T:new()
    {
        public T obj;

        public T yy
        {
            get => obj;
        }

        public virtual T HH() {
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
        public  Test()
        {

        }

        public Func<int> TestAction()
        {
            int a=0;
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

        //[Patch]
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //[Patch]
        //public static int Min(int a, int b)
        //{
        //    return _Min(a, b);
        //}

        //[Interpret]
        //static int _Min(int a, int b)
        //{
        //    return Math.Min(a, b);
        //}

        public int Add(int a, int b)
        {
            return a + b + 1000;
        }

        public static int Min(int a, int b)
        {
            return Math.Min(a, b) + 1000;
        }

        public static T Def<T>()where T:new()
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
    }
}
