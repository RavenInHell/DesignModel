using System;
using System.Collections.Generic;
using System.Text;
using 设计模式.责任链模式.Abstract;

namespace 设计模式.责任链模式.ManagerInherit
{
    public  class VicePresident:Approver
    {
        public VicePresident(string name)
            : base(name)
        {  
            
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount<25000.00)
            {
                Console.WriteLine($"{this}-{Name} approved the request of purshing {request.ProductName}");
            }else if (NextApprover!=null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
