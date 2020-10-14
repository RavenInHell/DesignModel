using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.责任链模式
{
    /// <summary>
    /// 采购请求,包括：金额和采购名称
    /// </summary>
    public class PurchaseRequest
    {
        /// <summary>
        /// 金额
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string  ProductName { get; set; }

        public PurchaseRequest(double amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }

    }
}
