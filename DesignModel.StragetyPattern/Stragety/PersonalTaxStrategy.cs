using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.StragetyPattern.IStragety;

namespace DesignModel.StragetyPattern.Stragety
{
    public  class PersonalTaxStrategy : ITaxStragety
    {
        /// <summary>
        /// 个人所得税
        /// </summary>
        /// <param name="income"></param>
        /// <returns></returns>
        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}
