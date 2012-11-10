using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities.Interfaces;

namespace Proxmulator.Entities
{
   public class TriggerCustom:  Trigger
    {

       public TriggerCustom(){
       }

       public TriggerCustom(MessageInfo msg)
           : base(msg, TriggerType.Custom)
       {
           this.RunOnReceivedMsg = true;
       }



    }
}
