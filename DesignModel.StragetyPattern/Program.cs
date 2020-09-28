using System;
using DesignModel.StragetyPattern.Stragety;

namespace DesignModel.StragetyPattern
{
    /// <summary>
    /// 设计模式-策略模式 原文地址 https://www.cnblogs.com/zhili/p/StragetyPattern.html
    /// </summary>
    class Program
    {
        /*
         * 计算中国的所得税，分为企业所得税、个人所得税等，当添加别的税种时
         */
        static void Main(string[] args)
        {
           //个人所得税计算
           InterestOperation persionTaxOperation=new InterestOperation(new PersonalTaxStrategy());
           Console.WriteLine($"个人所得税为{ persionTaxOperation.GetTax(5000.00)}");
           //企业所得税计算

           InterestOperation enterpriseTaxOperation=new InterestOperation(new EnterpriseTaxStrategy());
           Console.WriteLine($"企业所得税计算{enterpriseTaxOperation.GetTax(5000.00)}");
           Console.Read();
        }

    }
}
