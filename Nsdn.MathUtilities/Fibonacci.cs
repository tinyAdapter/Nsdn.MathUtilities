using System;
using System.Numerics;
using Nsdn.MathUtilities.Exception;

namespace Nsdn.MathUtilities
{
    /// <summary>
    /// 斐波那契数列
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// 获取斐波那契数列指定项
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static BigInteger IndexOf(int index)
        {
            if (index == 1 || index == 2)
                return BigInteger.One;

            BigInteger now, lastOne = BigInteger.One, lastTwo = BigInteger.One;

            for (int i = 3; i <= index; i++)
            {
                now = BigInteger.Add(lastOne, lastTwo);
                lastTwo = lastOne;
                lastOne = now;
            }
            return now;
        }
        /// <summary>
        /// 打印斐波那契数列，在某位置停止
        /// </summary>
        /// <param name="stopAt">停止打印项数</param>
        public static void PrintTable(int stopAt) => PrintTable(1, stopAt, " ");
        /// <summary>
        /// 打印斐波那契数列，在某位置停止，并指定分隔符
        /// </summary>
        /// <param name="stopAt">开始打印项数</param>
        /// <param name="splitWith">分隔符</param>
        public static void PrintTable(int stopAt, string splitWith) => PrintTable(1, stopAt, splitWith);
        /// <summary>
        /// 打印斐波那契数列，在某位置开始/停止
        /// </summary>
        /// <param name="startAt">开始打印项数</param>
        /// <param name="stopAt">停止打印项数</param>
        public static void PrintTable(int startAt, int stopAt) => PrintTable(startAt, stopAt, " ");
        /// <summary>
        /// 打印斐波那契数列，在某位置开始/停止，并指定分隔符
        /// </summary>
        /// <param name="startAt">开始打印项数</param>
        /// <param name="stopAt">停止打印项数</param>
        /// <param name="splitWith">分隔符</param>
        public static void PrintTable(int startAt, int stopAt, string splitWith)
        {
            try
            {
                if (startAt < 1 || stopAt < startAt)
                    throw new Exception.StopBeforeStartException();
                if ((startAt == 1 && stopAt == 1) || (startAt == 2 && stopAt == 2))
                {
                    Console.Write("1");
                    return;
                }
                if (startAt == 1 && stopAt == 2)
                {
                    Console.Write("1" + splitWith + "1");
                    return;
                }

                switch (startAt)
                {
                    case 1:
                        Console.Write("1" + splitWith + "1" + splitWith);
                        break;
                    case 2:
                        Console.Write("1" + splitWith);
                        break;
                    default:
                        break;
                }

                BigInteger now, lastOne = BigInteger.One, lastTwo = BigInteger.One;

                for (int i = 3; i < startAt; i++)
                {
                    now = BigInteger.Add(lastOne, lastTwo);
                    lastTwo = lastOne;
                    lastOne = now;
                }
                now = BigInteger.Add(lastOne, lastTwo);
                lastTwo = lastOne;
                lastOne = now;
                Console.Write(now);
                for (int i = (startAt >= 3 ? startAt : 3); i < stopAt; i++)
                {
                    now = BigInteger.Add(lastOne, lastTwo);
                    lastTwo = lastOne;
                    lastOne = now;
                    Console.Write(splitWith + now);
                }

                return;
            }
            catch (StopBeforeStartException)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取斐波那契数列字符串，在某位置停止
        /// </summary>
        /// <param name="stopAt">停止获取项数</param>
        /// <returns></returns>
        public static string GetTable(int stopAt) => GetTable(1, stopAt, " ");
        /// <summary>
        /// 获取斐波那契数列字符串，在某位置停止，并指定分隔符
        /// </summary>
        /// <param name="stopAt">开始获取项数</param>
        /// <param name="splitWith">分隔符</param>
        /// <returns></returns>
        public static string GetTable(int stopAt, string splitWith) => GetTable(1, stopAt, splitWith);
        /// <summary>
        /// 获取斐波那契数列字符串，在某位置开始/停止
        /// </summary>
        /// <param name="startAt">开始获取项数</param>
        /// <param name="stopAt">停止获取项数</param>
        /// <returns></returns>
        public static string GetTable(int startAt, int stopAt) => GetTable(startAt, stopAt, " ");
        /// <summary>
        /// 获取斐波那契数列字符串，在某位置开始/停止，并指定分隔符
        /// </summary>
        /// <param name="startAt">开始获取项数</param>
        /// <param name="stopAt">停止获取项数</param>
        /// <param name="splitWith">分隔符</param>
        /// <returns></returns>
        public static string GetTable(int startAt, int stopAt, string splitWith)
        {
            try
            {
                if (startAt < 1 || stopAt < startAt)
                    throw new Exception.StopBeforeStartException();
                if ((startAt == 1 && stopAt == 1) || (startAt == 2 && stopAt == 2))
                    return "1";
                if (startAt == 1 && stopAt == 2)
                    return "1" + splitWith + "1";

                string s;
                switch (startAt)
                {
                    case 1:
                        s = "1" + splitWith + "1" + splitWith;
                        break;
                    case 2:
                        s = "1" + splitWith;
                        break;
                    default:
                        s = "";
                        break;
                }

                BigInteger now, lastOne = BigInteger.One, lastTwo = BigInteger.One;

                for (int i = 3; i < startAt; i++)
                {
                    now = BigInteger.Add(lastOne, lastTwo);
                    lastTwo = lastOne;
                    lastOne = now;
                }
                now = BigInteger.Add(lastOne, lastTwo);
                lastTwo = lastOne;
                lastOne = now;
                s = s + now;
                for (int i = (startAt >= 3 ? startAt : 3); i < stopAt; i++)
                {
                    now = BigInteger.Add(lastOne, lastTwo);
                    lastTwo = lastOne;
                    lastOne = now;
                    s = s + splitWith + now;
                }

                return s;
            }
            catch (StopBeforeStartException)
            {
                throw;
            }
        }
    }
}