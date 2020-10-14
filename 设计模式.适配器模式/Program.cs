using System;
using 设计模式.适配器模式.ClassAdapter.Interface;
using 设计模式.适配器模式.ObjectAdapter;
using ClassPowerAdapter = 设计模式.适配器模式.ClassAdapter.PowerAdapter;
using ObjectPowerAdapter=设计模式.适配器模式.ObjectAdapter.PowerAdapter;
namespace 设计模式.适配器模式
{
    /// <summary>
    /// 设计模式-适配器模式 https://www.cnblogs.com/zhili/p/AdapterPattern.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 以插孔和插座的适配为例子
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region 类的适配器模式
            Console.WriteLine("------------类的适配器模式--------");
            IThreeHole threeHole = new ClassPowerAdapter();
            threeHole.Request();
            Console.ReadLine(); 
            #endregion



            Console.WriteLine("------------对象的适配器模式--------");
            ThreeHole threeHoleObj=new ObjectPowerAdapter();
            threeHoleObj.Request();
            Console.ReadLine();
        }
    }
}
