using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using 设计模式.责任链模式.Abstract;

namespace 设计模式.责任链模式.ManagerInherit
{
    public class TeamLeader : Approver
    {
        public TeamLeader(string name)
            : base(name)
        {

        }
        public override void ProcessRequest(PurchaseRequest request)
        {
            //小于一万项目组长可以直接审批
            if (request.Amount<10000.00)
            {
                Console.WriteLine($"{this}-{Name} approved the request of purshing{request.ProductName}");
            }
            //不小于一万且项目组长有上级，则请求由上级批准
            else if (NextApprover!=null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
