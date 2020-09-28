using System;
using DesignModel.ProxyPattern.Proxy;

namespace DesignModel.ProxyPattern
{
    /// <summary>
    /// 设计模式-代理模式 原文地址 https://www.cnblogs.com/zhili/p/ProxyPattern.html
    /// </summary>
    class Program
    {
        /*
         * 以朋友海外帮忙购物为例
         */
        static void Main(string[] args)
        {
            //创建一个代理对象并发出请求
            Person proxy=new Friend();
            proxy.BuyProduct();
            Console.Read();
        }
    }
}
