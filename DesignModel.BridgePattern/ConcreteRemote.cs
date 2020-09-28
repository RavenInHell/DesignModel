using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModel.BridgePattern
{
    class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("------------------\n");
            base.SetChannel();
            Console.WriteLine("------------------\n");
        }
    }
}
