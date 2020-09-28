using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.StragetyPattern.IStragety
{
    /// <summary>
    /// 所得税计算策略
    /// </summary>
    public interface ITaxStragety
    {
        double CalculateTax(double income);
    }
}
