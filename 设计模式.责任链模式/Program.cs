using System;
using 设计模式.责任链模式.Abstract;
using 设计模式.责任链模式.ManagerInherit;

namespace 设计模式.责任链模式
{
    /// <summary>
    /// 设计模式-责任链模式 （Chain of Responsibility Pattern ） 原文链接 https://www.cnblogs.com/zhili/p/ChainOfResponsibity.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 下面以公司采购东西为例子来实现责任链模式。公司规定，采购架构总价在1万之
        /// 内，经理级别的人批准即可，总价大于1万小于2万5的则还需要副总进行批准，总
        /// 价大于2万5小于10万的需要还需要总经理批准，而大于总价大于10万的则需要组
        /// 织一个会议进行讨论。对于这样一个需求，最直观的方法就是设计一个方法，参数
        /// 是采购的总价，然后在这个方法内对价格进行调整判断，然后针对不同的条件交
        /// 给不同级别的人去处理，这样确实可以解决问题，但这样一来，我们就需要多重
        /// if-else语句来进行判断，但当加入一个新的条件范围时，我们又不得不去修改原
        /// 来设计的方法来再添加一个条件判断，这样的设计显然违背了“开-闭”原则。
        /// 这时候，可以采用责任链模式来解决这样的问题
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //实例化采购的请求
            PurchaseRequest approveOfTeamLeader = new PurchaseRequest(4000.00, "Telphone");
            PurchaseRequest approveOfVicePresident = new PurchaseRequest(10000.00, "Camera");
            PurchaseRequest approveOfPresident=new PurchaseRequest(40000.00,"Second-hand car");
            PurchaseRequest approveOfBoardDirectors = new PurchaseRequest(400000.00, "Second-hand car");
            //实例化参与审批的管理者
            Approver teamLeader=new TeamLeader("LearningHard");
            Approver vicePresident=new VicePresident("Tony");
            Approver president=new President("BossTom");

            //设置责任链 管理者的层次排序
            teamLeader.NextApprover = vicePresident;
            vicePresident.NextApprover = president;

            //处理请求
            Console.WriteLine("小组长能审批的：");
            teamLeader.ProcessRequest(approveOfTeamLeader);
            Console.WriteLine("副总经理能审批的：");
            teamLeader.ProcessRequest(approveOfVicePresident);
            Console.WriteLine("总经理能审批的：");
            teamLeader.ProcessRequest(approveOfPresident);
            Console.WriteLine("董事会开会能审批的：");
            teamLeader.ProcessRequest(approveOfBoardDirectors);
            Console.Read();
        }
    }
}
