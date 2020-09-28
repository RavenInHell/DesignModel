using System;
using System.Collections.Generic;
using System.Text;
using DesignModel.BridgePattern.Abstract;

namespace DesignModel.BridgePattern.RealizeAbstract
{
    public class Chuangwei:TV
    {
        public override void Off()
        {
            Console.WriteLine("创维电视机已打开");
        }

        public override void On()
        {
            Console.WriteLine("创维电视机已关闭");
        }

        public override void TuneChannel()
        {
            Console.WriteLine("创维电视机切换频道");
        }
    }
}
