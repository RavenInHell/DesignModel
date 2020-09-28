using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DesignModel.BridgePattern.Abstract;

namespace DesignModel.BridgePattern
{
    /// <summary>
    /// 抽象概念中的遥控器
    /// </summary>
    public class RemoteControl
    {
        //字段
        private  TV implementor { get; set; } 

        public TV Implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }
        /// <summary>
        /// 关闭电视机，这里抽象类中不再提供实现，二十调用现实类中的实现
        /// </summary>
        public virtual void On()
        {
            implementor.On();
        }

        /// <summary>
        /// 打开电视
        /// </summary>
        public virtual void Off()
        {
            implementor.Off();
        }

        public virtual void SetChannel()
        {
            implementor.TuneChannel();
        }
    }
}
