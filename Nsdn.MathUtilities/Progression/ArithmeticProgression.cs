using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Nsdn.MathUtilities.Progression
{
    /// <summary>
    /// 等差数列
    /// </summary>
    public class ArithmeticProgression
    {
        /// <summary>
        /// 获取等差数列数组
        /// </summary>
        /// <param name="firstItem">首项</param>
        /// <param name="commonDifference">公差</param>
        /// <param name="itemNumber">项数</param>
        /// <returns></returns>
        public static double[] GetArray(double firstItem, double commonDifference, uint itemNumber)
        {
            if (itemNumber == 0)
                throw new Exception.NotEnoughItemException();

            double[] darr = new double[itemNumber];

            darr[0] = firstItem;
            for (uint i = 1; i < itemNumber; i++)
                darr[i] = darr[i - 1] + commonDifference;

            return darr;
        }
        /// <summary>
        /// 获取等差数列的指定项
        /// </summary>
        /// <param name="firstItem">首项</param>
        /// <param name="commonDifference">公差</param>
        /// <param name="index">项数</param>
        /// <returns></returns>
        public static double IndexOf(double firstItem, double commonDifference, uint index)
        {
            if (index == 0)
                throw new Exception.NotEnoughItemException();

            double result = firstItem;
            for (uint i = 1; i < index; i++)
                result += commonDifference;

            return result;
        }
        /// <summary>
        /// 获取等差数列的倒序指定项
        /// </summary>
        /// <param name="lastItem">首项</param>
        /// <param name="commonDifference">公差</param>
        /// <param name="index">项数</param>
        /// <returns></returns>
        public static double LastIndexOf(double lastItem, double commonDifference, uint index)
        {
            if (index == 0)
                throw new Exception.NotEnoughItemException();

            double result = lastItem;
            for (uint i = 1; i < index; i++)
                result -= commonDifference;

            return result;
        }
        /// <summary>
        /// 计算等差数列的平均值
        /// </summary>
        /// <param name="firstItem">首项</param>
        /// <param name="commonDifference">公差</param>
        /// <param name="itemNumber">项数</param>
        /// <returns></returns>
        public static double AverageOf(double firstItem, double commonDifference, uint itemNumber)
        {
            if (itemNumber == 0)
                throw new Exception.NotEnoughItemException();

            if (itemNumber % 2 == 1)
            {
                double mid = firstItem;
                for (uint i = 1; i <= itemNumber / 2; i++)
                    mid += commonDifference;

                return mid;
            }
            else
            {
                double mid = firstItem;
                for (uint i = 1; i < itemNumber / 2; i++)
                    mid += commonDifference;

                return (mid + mid + commonDifference) / 2;
            }
        }
        /// <summary>
        /// 计算确定等差数列的公差
        /// </summary>
        /// <param name="firstItem">首项</param>
        /// <param name="lastItem">尾项</param>
        /// <param name="itemNumber">项数</param>
        /// <returns></returns>
        public static double CommonDifferenceOf(double firstItem, double lastItem, uint itemNumber)
        {
            if (itemNumber < 2)
                throw new Exception.NotEnoughItemException();

            return (lastItem - firstItem) / (itemNumber - 1);
        }
    }
}
