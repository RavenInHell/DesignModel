using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.StragetyPattern.IStragety;

namespace DesignModel.StragetyPattern.Stragety
{
    //企业所得税
    public class EnterpriseTaxStrategy : ITaxStragety
    {
        public double CalculateTax(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
        }
    }
}
