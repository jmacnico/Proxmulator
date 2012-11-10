using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Net;
using Proxmulator.Entities;
using Proxmulator.Extras;

namespace Proxmulator.Core
{
    public class ProcessRequestSignal : IProcesser
    {
        private string _sample;


        public ProcessRequestSignal()
        {
            var tmp = Utils.GetResourceTextFile("sample.xml");
            _sample = tmp;
           
        }


        public void ProcessRequest(object args)
        {
            try
            {
                var msg = args as MessageInfo;
                var xml = msg.xml;

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xml.NameTable);
                nsmgr.AddNamespace("ptpSoapHeader", "urn://ptp.pt/SharedResources/SchemaDefinitions/EAIMessaging/SOAPHeader");
                nsmgr.AddNamespace("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");

                var aux = xml.SelectSingleNode("//auxiliaryGroupInfo", nsmgr);

                var msgOut = _sample;

                if (msg.NPU != null)
                {
                    msgOut = msgOut.Replace("###NPU##", msg.NPU);
                }

                if (msg.CorrelationNPU != null)
                {
                    msgOut = msgOut.Replace("##CORR_NPU##", "<correlationNPU>" + msg.CorrelationNPU + "</correlationNPU>");
                }
                else
                {
                    msgOut = msgOut.Replace("##CORR_NPU##", "");
                }


                if (msg.ProcessId != null)
                {
                    msgOut = msgOut.Replace("##PROC_ID##", msg.ProcessId);
                }
                else
                {
                    msgOut = msgOut.Replace("##PROC_ID##", "");
                }

                msgOut = msgOut.Replace("##DATE##", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));

                if (aux != null)
                    msgOut = msgOut.Replace("##AUX##", aux.OuterXml);

                var msgSent = new MessageSent();
                msgSent.Send = msgOut;
                CommunicationWS.SendMessage(msgSent, Configuration.UrlReturn, "http://telecom.pt/ptMsgInt/2009/12/16/in/pubMessage");

                var strNpu = msg.NPU == null ? "N/A" : msg.NPU;
                Logger.Log("#INFO# Send Signal, NPU: " + strNpu);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "ProcessRequestSignal");
            }

        }
    }
}
