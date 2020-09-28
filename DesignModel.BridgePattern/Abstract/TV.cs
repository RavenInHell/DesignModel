using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.BridgePattern.Abstract
{
    /// <summary>
    /// 电视机提供抽象的方法
    /// </summary>
    public  abstract  class TV
    {
        public abstract void On();

        public abstract void Off();

        public abstract void TuneChannel();
    }
}
