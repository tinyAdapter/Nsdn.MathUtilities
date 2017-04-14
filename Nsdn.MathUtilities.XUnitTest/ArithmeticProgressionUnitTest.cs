using System;
using Xunit;
using Nsdn.MathUtilities;
using System.IO;
using System.Numerics;
using Nsdn.MathUtilities.Progression;

namespace Nsdn.MathUtilities.XUnitTest
{
    public class ArithmeticProgressionUnitTest
    {
        [Fact]
        public void ArithmeticProgressionGetArrayTest()
        {
            Assert.Equal(new double[] { 1.0 }, ArithmeticProgression.GetArray(1.0, 2.0, 1));
            Assert.Equal(new double[] { 1.0, 3.0, 5.0 }, ArithmeticProgression.GetArray(1.0, 2.0, 3));
            Assert.Throws<Exception.NotEnoughItemException>(() => ArithmeticProgression.GetArray(1.0, 2.0, 0));
        }
        [Fact]
        public void ArithmeticProgressionIndexOfTest()
        {
            Assert.Equal(1.0, ArithmeticProgression.IndexOf(1.0, 2.0, 1));
            Assert.Equal(5.0, ArithmeticProgression.IndexOf(1.0, 2.0, 3));
            Assert.Throws<Exception.NotEnoughItemException>(() => ArithmeticProgression.IndexOf(1.0, 2.0, 0));
        }
        [Fact]
        public void ArithmeticProgressionLastIndexOfTest()
        {
            Assert.Equal(1.0, ArithmeticProgression.LastIndexOf(1.0, 2.0, 1));
            Assert.Equal(-3.0, ArithmeticProgression.LastIndexOf(1.0, 2.0, 3));
            Assert.Throws<Exception.NotEnoughItemException>(() => ArithmeticProgression.LastIndexOf(1.0, 2.0, 0));
        }
        [Fact]
        public void ArithmeticProgressionAverageOfTest()
        {
            Assert.Equal(1.0, ArithmeticProgression.AverageOf(1.0, 2.0, 1));
            Assert.Equal(3.0, ArithmeticProgression.AverageOf(1.0, 2.0, 3));
            Assert.Equal(4.0, ArithmeticProgression.AverageOf(1.0, 2.0, 4));
            Assert.Throws<Exception.NotEnoughItemException>(() => ArithmeticProgression.AverageOf(1.0, 2.0, 0));
        }
        [Fact]
        public void ArithmeticProgressionCommonDifferenceOfTest()
        {
            Assert.Throws<Exception.NotEnoughItemException>(() => ArithmeticProgression.CommonDifferenceOf(1.0, 2.0, 1));
            Assert.Equal(1.0, ArithmeticProgression.CommonDifferenceOf(1.0, 2.0, 2));
            Assert.Equal(0.25, ArithmeticProgression.CommonDifferenceOf(1.0, 2.0, 5));
            Assert.Throws<Exception.NotEnoughItemException>(() => ArithmeticProgression.CommonDifferenceOf(1.0, 2.0, 0));
        }
    }
}
