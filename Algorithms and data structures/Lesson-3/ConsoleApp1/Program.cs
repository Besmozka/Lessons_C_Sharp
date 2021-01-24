using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace GeekBrainsAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {
        public int SumValueType(int value)
        {
            return 9 + value;
        }

        public int SumRefType(object value)
        {
            return 9 + (int)value;
        }

        [Benchmark]
        public void TestSum()
        {
            SumValueType(99);
        }

        [Benchmark]
        public void TestSumBoxing()
        {
            object x = 99;
            SumRefType(x);
        }
    }
}
