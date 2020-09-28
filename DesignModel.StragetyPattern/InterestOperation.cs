using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.StragetyPattern.IStragety;

namespace DesignModel.StragetyPattern
{
    public class InterestOperation
    {
        private ITaxStragety m_strategy;

        public InterestOperation(ITaxStragety stragety)
        {
            this.m_strategy = stragety;
        }

        public double GetTax(double income)
        {
            return m_strategy.CalculateTax(income);
        }
    }
}
