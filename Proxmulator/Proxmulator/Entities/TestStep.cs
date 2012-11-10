using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities.Interfaces;
using System.Xml.Serialization;

namespace Proxmulator.Entities
{

    public class TestStep 
    {
        public int Index { get; set; }
        public string Name { get; set; }

        [XmlElement(typeof(TriggerOperation))]
        [XmlElement(typeof(TriggerNone))]
        [XmlElement(typeof(TriggerCustom))]
        public Trigger Trigger { get; set; }
        
        public MessageInfo Message { get; set; }
        public string UrlResponse { get; set; }

        [XmlIgnore]
        public bool Sent { get; set; }

        public TestStep()
        {
            Sent = false;
            Trigger = new TriggerNone();
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
