using System;
using System.Collections.Generic;
using System.Text;

namespace 设计模式.责任链模式.Abstract
{
    /// <summary>
    /// 审批人（类的级别），其他（经理，副总）将继承此抽象方法
    /// </summary>
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }

        public string Name { get; set; }

        public Approver(string name)
        {
            this.Name = name;
        }

        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
