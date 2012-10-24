using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxmulator.Entities
{

    public enum TriggerType { None = 1, Operation = 2 };

    public class TestStep
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public TriggerType Trigger { get; set; }
        public MessageInfo Message { get; set; }
        public string UrlResponse { get; set; }
        public bool Sent { get; set; }

        public TestStep()
        {
            Sent = false;
        }


        public bool isTriggerOperation(MessageInfo msg)
        {
            var operation = msg.Operation;
            var operationCorr = MessageInfo.GetOperationFromNPU(this.Message.CorrelationNPU);

            if (operation == operationCorr)
                return true;

            return false;
        }








    }



}
