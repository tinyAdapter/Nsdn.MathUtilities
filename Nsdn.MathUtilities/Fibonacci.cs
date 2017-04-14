using System;
using System.Numerics;
using Nsdn.MathUtilities.Exception;

namespace Nsdn.MathUtilities
{
    /// <summary>
    /// 쳲���������
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// ��ȡ쳲���������ָ����
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
        /// ��ӡ쳲��������У���ĳλ��ֹͣ
        /// </summary>
        /// <param name="stopAt">ֹͣ��ӡ����</param>
        public static void PrintTable(int stopAt) => PrintTable(1, stopAt, " ");
        /// <summary>
        /// ��ӡ쳲��������У���ĳλ��ֹͣ����ָ���ָ���
        /// </summary>
        /// <param name="stopAt">��ʼ��ӡ����</param>
        /// <param name="splitWith">�ָ���</param>
        public static void PrintTable(int stopAt, string splitWith) => PrintTable(1, stopAt, splitWith);
        /// <summary>
        /// ��ӡ쳲��������У���ĳλ�ÿ�ʼ/ֹͣ
        /// </summary>
        /// <param name="startAt">��ʼ��ӡ����</param>
        /// <param name="stopAt">ֹͣ��ӡ����</param>
        public static void PrintTable(int startAt, int stopAt) => PrintTable(startAt, stopAt, " ");
        /// <summary>
        /// ��ӡ쳲��������У���ĳλ�ÿ�ʼ/ֹͣ����ָ���ָ���
        /// </summary>
        /// <param name="startAt">��ʼ��ӡ����</param>
        /// <param name="stopAt">ֹͣ��ӡ����</param>
        /// <param name="splitWith">�ָ���</param>
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
        /// ��ȡ쳲����������ַ�������ĳλ��ֹͣ
        /// </summary>
        /// <param name="stopAt">ֹͣ��ȡ����</param>
        /// <returns></returns>
        public static string GetTable(int stopAt) => GetTable(1, stopAt, " ");
        /// <summary>
        /// ��ȡ쳲����������ַ�������ĳλ��ֹͣ����ָ���ָ���
        /// </summary>
        /// <param name="stopAt">��ʼ��ȡ����</param>
        /// <param name="splitWith">�ָ���</param>
        /// <returns></returns>
        public static string GetTable(int stopAt, string splitWith) => GetTable(1, stopAt, splitWith);
        /// <summary>
        /// ��ȡ쳲����������ַ�������ĳλ�ÿ�ʼ/ֹͣ
        /// </summary>
        /// <param name="startAt">��ʼ��ȡ����</param>
        /// <param name="stopAt">ֹͣ��ȡ����</param>
        /// <returns></returns>
        public static string GetTable(int startAt, int stopAt) => GetTable(startAt, stopAt, " ");
        /// <summary>
        /// ��ȡ쳲����������ַ�������ĳλ�ÿ�ʼ/ֹͣ����ָ���ָ���
        /// </summary>
        /// <param name="startAt">��ʼ��ȡ����</param>
        /// <param name="stopAt">ֹͣ��ȡ����</param>
        /// <param name="splitWith">�ָ���</param>
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