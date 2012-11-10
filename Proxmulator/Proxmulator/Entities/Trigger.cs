using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxmulator.Entities.Interfaces
{
    public enum TriggerType { None = 1, Operation = 2, Custom = 3 };

    public class Trigger
    {
        public List<Condition> Conditions { get; set; }
        public TriggerType Type { get; set; }
        public MessageInfo Message { get; set; }
        public bool RunOnReceivedMsg { get; set; }
        public string NpuToUse { get;  set; }
        public bool OnlyOneUse { get; set; }

        public Trigger()
        {

        }

        public Trigger(MessageInfo msg, TriggerType type)
        {
            this.OnlyOneUse = false;
            this.RunOnReceivedMsg = false;
            this.Conditions = new List<Condition>();
            this.Message = msg;
            this.Type = type;
        }
        
        public virtual bool RunTrigger(MessageInfo msg, List<MessageInfo> Received, bool triggerFired)
        {
            if (msg == null)
                return false;

            var result = true;
            var xml = msg.xml;
            NpuToUse = msg.NPU;

            if (triggerFired && OnlyOneUse)
                return false;


            foreach (var cond in Conditions)
            {
                if (!cond.IsConditionTrue(xml))
                    result =  false;
            }

            if (!result && RunOnReceivedMsg)
            {
                foreach (var oldMsg in Received)
                {
                    
                    var oldXml = oldMsg.xml;
                    result = true;
                    foreach (var cond in Conditions)
                    {
                        if (!cond.IsConditionTrue(oldXml))
                        {
                            result = false;
                            break;
                        }
                    }

                    if (result == true)
                    {
                        NpuToUse = oldMsg.NPU;
                        break;
                    }
                }

            }

            return result;
        }



        public virtual void AddCondition(Proxmulator.Entities.Condition condition)
        {
            Conditions.Add(condition);
        }

    }
}
