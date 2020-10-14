using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.责任链模式.Abstract;

namespace 设计模式.责任链模式.ManagerInherit
{
    public class President : Approver
    {
        public President(string name)
            : base(name)
        {

        }
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount<100000.00)
            {
                Console.WriteLine($"{this}-{Name} approved the request of purshing{request.ProductName}");
            }
            else
            {
               Console.WriteLine("Request需要组织一个会议讨论");
            }
            
        }
    }
}
