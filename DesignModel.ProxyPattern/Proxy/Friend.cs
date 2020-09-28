using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.ProxyPattern.Proxy
{
    /// <summary>
    /// 代理角色
    /// </summary>
    public class Friend : Person
    {
        private RealBuyPerson realSubject;
        public override void BuyProduct()
        {
            Console.WriteLine("通过代理类访问真实实体对象的方法");
            if (realSubject==null)
            {
                realSubject=new RealBuyPerson();
            }
            this.PreBuyProduct();
            //调用真实主题方法
            realSubject.BuyProduct();
            this.PostBuyProduct();
        }

        #region 代理角色需要做的一些操作
        public void PreBuyProduct()
        {
            Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带Iphone");
        }

        public void PostBuyProduct()
        {
            Console.WriteLine("终于买完了，现在要对东西分一下，相机是张三的；Iphone李四的");
        } 
        #endregion
    }
}
