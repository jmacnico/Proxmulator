using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities.Interfaces;
using Proxmulator.Core;

namespace Proxmulator.Entities
{
   public class TriggerOperation : Trigger
    {
        public TriggerOperation()
        {
        }

        public TriggerOperation(MessageInfo msg)
            : base(msg, TriggerType.Operation)
        {
            OnlyOneUse = true;
            var cond = new Condition(MessageInfo.GetOperationFromNPU(msg.CorrelationNPU) , "npu", EnumCondition.LIKE);
            AddCondition(cond);
        }

    }


    public class TriggerNone : Trigger
    {

        public TriggerNone() { 
       
        }

        public TriggerNone(MessageInfo msg)
            : base(msg, TriggerType.None)
        {
            OnlyOneUse = true;
        }



        public override bool RunTrigger(MessageInfo msg, List<MessageInfo> received, bool triggerFired)
        {
            return true;
        }

    }

}
