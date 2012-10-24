using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities;

namespace Proxmulator.Core
{
    public class Messaging
    {

        public static MessageSent ReplyI2(MessageInfo msg)
        {
            var i2 = Utils.GetResourceTextFile("GR_I2.xml");

            var npu = createNpu("GENREPIRTO");
            i2 = string.Format(i2, npu, msg.NPU);

            var msgSent = new MessageSent();
            msgSent.Msg = msg;
            msgSent.NPU = npu;
            msgSent.Date = DateTime.Now;
            msgSent.Send = i2;

            CommunicationWS.SendMessage(msgSent, Configuration.UrlReturn, "http://telecom.pt/ptMsgInt/2009/12/16/in/pubMsgReport");

            return msgSent;
        }


        internal static MessageSent SendMsg(MessageInfo msg, string url = null)
        {
            if(url == null){
                url = CommunicationWS.GetUrl(msg.InterfaceToInvoke);
            }

            var soapEnv = Utils.GetResourceTextFile("soapEnv.xml");
            var bodyMsg = string.Format(soapEnv, msg.Payload);

            var messageSent = new MessageSent();

            messageSent.Date = DateTime.Now;
            messageSent.Msg = msg;
            messageSent.Send = bodyMsg;

            CommunicationWS.SendMessage(messageSent, url, CommunicationWS.GetSoapAction(msg.InterfaceToInvoke));

            return messageSent;
        }


        public static MessageSent SendStep(TestStep step, string correlation = null)
        {
            if (!string.IsNullOrEmpty(correlation))
            {
                var n = Utils.SelectNode(step.Message.xml, "correlationNPU");
                if (n != null)
                {
                    n.InnerText = correlation;
                }
                else
                {
                    n = Utils.SelectNode(step.Message.xml, "correlationNpu");
                    if (n != null)
                    {
                        n.InnerText = correlation;
                    }
                }
            }

            var nNpu = Utils.SelectNode(step.Message.xml, "npu");
            nNpu.InnerText = Messaging.createNpu(step.Message.Operation);


            step.Message.Payload = step.Message.xml.OuterXml;


            var msg = Messaging.SendMsg(step.Message);

            return msg;
        }


        internal static MessageSent ReplyGPError(MessageInfo msg)
        {
            var e0 = Utils.GetResourceTextFile("GR_E0.xml");

            var npu = createNpu("GENREPIRTO");
            e0 = string.Format(e0, npu, msg.NPU);

            var msgSent = new MessageSent();
            msgSent.Msg = msg;
            msgSent.NPU = npu;
            msgSent.Date = DateTime.Now;
            msgSent.Send = e0;
            
            CommunicationWS.SendMessage(msgSent, Configuration.UrlReturn, "http://telecom.pt/ptMsgInt/2009/12/16/in/pubMsgReport");

            return msgSent;
        }



        internal static string createNpu(string operation)
        {
            var npu = string.Format("0022{0}{1}0000000000000000000", operation, DateTime.Now.ToString("yyyyMMddHHmmssfff"));

            return npu;
        }

    }
}
