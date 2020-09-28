using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.DecoratorPattern.DecoratorModule
{
    public class Sticker : Decorator
    {
        public Sticker(Phone phone)
            : base(phone)
        {

        }

        public override void Print()
        {
            base.Print();
            //添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("现在给手机贴上膜了。");
        }
    }
}
