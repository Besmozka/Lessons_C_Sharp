using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BenchmarkClass
    {
        static float[] fArray = GetFloatArray(10000);
        static double[] dArray= GetDoubleArray(10000);
        public static float[] GetFloatArray(int arrayLength)
        {
            Random random = new Random();
            var array = new float[arrayLength];
            for (int i = 0; i < arrayLength - 1; i++)
                array[i] = (float)random.NextDouble();
            return array;
        }

        public static double[] GetDoubleArray(int arrayLength)
        {
            Random random = new Random();
            var array = new double[arrayLength];
            for (int i = 0; i < arrayLength - 1; i++)
                array[i] = random.NextDouble();
            return array;
        }        

        public static float PointDistanceFloat(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.fX - pointTwo.fX;
            float y = pointOne.fY - pointTwo.fY;
            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.dX - pointTwo.dX;
            double y = pointOne.dY - pointTwo.dY;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceWithoutSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.fX - pointTwo.fX;
            float y = pointOne.fY - pointTwo.fY;
            return (x * x) + (y * y);
        }

        [Benchmark]

        public void TestClassFloat()
        {
            for (int i = 1; i < fArray.Length - 1; i++)
            {
                var pointOne = new PointClass(fArray[i - 1], fArray[i]);
                var pointTwo = new PointClass(fArray[fArray.Length - (i + 1)], fArray[fArray.Length - i]);
                PointDistanceFloat(pointOne, pointTwo);
            }
        }
        [Benchmark]

        public void TestStructFloat()
        {
            for (int i = 1; i < fArray.Length - 1; i++)
            {
                var pointOne = new PointStruct(fArray[i - 1], fArray[i], dArray[i], dArray[i]);
                var pointTwo = new PointStruct(fArray[fArray.Length - (i + 1)], fArray[fArray.Length - i], dArray[i], dArray[i]);
                PointDistance(pointOne, pointTwo);
            }
        }
        [Benchmark]

        public void TestStructDouble()
        {
            for (int i = 1; i < dArray.Length - 1; i++)
            {
                var pointOne = new PointStruct(fArray[i], fArray[i], dArray[i - 1], dArray[i]);
                var pointTwo = new PointStruct(fArray[i], fArray[i], dArray[dArray.Length - (i + 1)], dArray[dArray.Length - i]);
                PointDistanceDouble(pointOne, pointTwo);
            }
        }
        [Benchmark]

        public void TestStructFloatWithoutSqrt()
        {
            for (int i = 1; i < fArray.Length - 1; i++)
            {
                var pointOne = new PointStruct(fArray[i - 1], fArray[i], dArray[i], dArray[i]);
                var pointTwo = new PointStruct(fArray[fArray.Length - (i + 1)], fArray[fArray.Length - i], dArray[i], dArray[i]);
                PointDistanceWithoutSqrt(pointOne, pointTwo);
            }
        }
    }
  
}
