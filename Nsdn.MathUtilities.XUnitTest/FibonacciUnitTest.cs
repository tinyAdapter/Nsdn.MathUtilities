using System;
using Xunit;
using Nsdn.MathUtilities;
using System.IO;
using System.Numerics;

namespace Nsdn.MathUtilities.XUnitTest
{
    public class FibonacciUnitTest
    {
        [Fact]
        public void FibonacciIndexOfTest()
        {
            Assert.Equal(BigInteger.Parse("5"), Fibonacci.IndexOf(5));
        }
        [Fact]
        public void FibonacciGetTableTest1()
        {
            Assert.Equal("1 1 2 3 5 8 13 21 34 55", Fibonacci.GetTable(1, 10));
        }
        [Fact]
        public void FibonacciGetTableTest2()
        {
            Assert.Equal("5 8 13 21 34 55", Fibonacci.GetTable(5, 10, " "));
        }
        [Fact]
        public void FibonacciPrintTableTest1()
        {
            StringWriter sw = CaptureConsoleOut();
            Fibonacci.PrintTable(1, 10);
            Assert.Equal("1 1 2 3 5 8 13 21 34 55", sw.ToString());
        }
        [Fact]
        public void FibonacciPrintTableTest2()
        {
            StringWriter sw = CaptureConsoleOut();
            Fibonacci.PrintTable(5, 10, "\n");
            Assert.Equal("5\n8\n13\n21\n34\n55", sw.ToString());
        }

        public static StringWriter CaptureConsoleOut()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            return sw;
        }
    }
}
