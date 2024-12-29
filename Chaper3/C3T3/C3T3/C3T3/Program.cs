using System;
/*
模拟输出中国联通流量提醒　定义两个浮点型变量，分别表示已用流量（3.592）
和剩余流量（3.408），定义一个字符型变量，用来表示网址（http://u.10010.cn/tAE3v），
编写一个程序，输出中国联通流量提醒。

 */
namespace C3T4
{
    class Program
    {
        static void Main(string[] args)
        {
            float usedData = 3.592f; // have to add f to indicate it's a float number
            float leftData = 3.408f;
            string url = "http://u.10010.cn/tAE3v";
            Console.WriteLine("Reminder: Your data has been used: {0} G, there has {1} G left and to" +
                              "get more data, please vist {2}.", usedData, leftData, url);
        }
    
    }
    
}


