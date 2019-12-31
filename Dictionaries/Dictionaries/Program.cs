using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDic = new Dictionary<string, string>();

            //插入
            myDic.Add("1", "依依");
            myDic.Add("2", "落落");
            myDic.Add("3", "姗姗");

            //key 存在
            try
            {
                myDic.Add("1", "1joye.net");
            }
            catch
            {
                Console.WriteLine("Tkey = \"1\" 天宇.");
            }
            //取值
            Console.WriteLine("Tkey = \"2\", Tvalue = {0}.", myDic["2"]);

            //修改
            myDic["2"] = "嘟凡";
            myDic["4"] = "发光";   //修改的key不存在则新增
            Console.WriteLine("Tkey = \"2\", Tvalue = {0}.", myDic["2"]);
            Console.WriteLine("Tkey = \"4\", Tvalue = {0}.", myDic["4"]);

            //判断key是否存在
            if (!myDic.ContainsKey("5"))
            {
                myDic.Add("5", "婷婷");
                Console.WriteLine("Tkey = \"5\": {0}", myDic["5"]);
            }
            //移除
            myDic.Remove("1");

            if (!myDic.ContainsKey("1"))
            {
                Console.WriteLine("Tkey =\"1\" 归归");
            }
            //foreach 取值
            foreach (var item in myDic)
            {
                Console.WriteLine("Tkey = {0}, Tvalue = {1}", item.Key, item.Value);
            }
            //所有的值
            foreach (var item in myDic.Values)
            {
                Console.WriteLine("Tvalue = {0}", item);
            }

            //所有的key
            foreach (var item in myDic.Keys)
            {
                Console.WriteLine("Tkey = {0}", item);
            }
            Console.ReadKey();
        }
    }
}
