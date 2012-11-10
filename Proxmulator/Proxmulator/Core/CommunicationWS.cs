using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities;
using System.Net;
using System.IO;
using System.Xml;

namespace Proxmulator.Core
{
    public class CommunicationWS
    {

        public static void SendMessage(MessageSent msg, string url, string soapAction)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "text/xml;charset=UTF-8";
                //request.UserAgent = "Jakarta Commons-HttpClient/3.1";
                //request.ContentLength = msg.Send.Length;
                request.Headers.Add("SOAPAction", soapAction);
                request.Accept = "text/xml";
                request.KeepAlive = true;

                var aStream = request.GetRequestStream();
                var aStreamWriter = new StreamWriter(aStream);

                aStreamWriter.Write(msg.Send);
                aStreamWriter.Close();

                WebResponse response = request.GetResponse();

                ValidateResponse(response, msg);
            }
            catch (Exception ex)
            {
                msg.Status = MessageStatusEnum.Fail;
                msg.Received = ex.Message + "\r\n" + ex.StackTrace;
                Logger.Exception(ex, "SendMessage");
            }
        }


        private static void ValidateResponse(WebResponse response, MessageSent msg)
        {
            if (response == null)
            {
                msg.Received = "Unable to read response";
                msg.Status = MessageStatusEnum.Fail;
                return;
            }
            var reader = new StreamReader(response.GetResponseStream());

            var str = reader.ReadToEnd();

            str = cleanStream(str);

            msg.Received = str;

            reader.Close();

            var xml = new XmlDocument();
            xml.LoadXml(str);

            var eCode = xml.SelectSingleNode("//*[local-name()='eCode']");


            if (eCode == null || (eCode.InnerText != "22I0000" && eCode.InnerText != "I0"))
                msg.Status = MessageStatusEnum.Fail;
            else
                msg.Status = MessageStatusEnum.OK;

        }

       


        public static string GetSoapAction(string interfaceToInvoke, string operation = null)
        {
            if (Configuration.SoapActions.Any(a => a.InterfaceToInvoke == interfaceToInvoke))
            {
                if (Configuration.SoapActions.Any(a => a.Operation == operation))
                {

                    return Configuration.SoapActions.FirstOrDefault(a => a.InterfaceToInvoke == interfaceToInvoke && a.Operation == operation).Action;
                }

                return Configuration.SoapActions.FirstOrDefault(a => a.InterfaceToInvoke == interfaceToInvoke).Action;
            }


            return "http://telecom.pt/ptMsgInt/2009/12/16/in/pubMessage";
        }

        public static string GetUrl(string interfaceToInvoke)
        {
            if (Configuration.Urls.Any(a => a.Key == interfaceToInvoke))
            {
                return Configuration.Urls.FirstOrDefault(a => a.Key == interfaceToInvoke).Value;
            }

            return Configuration.UrlReturn;
        }


        public static string cleanStream(string str)
        {
            var index = str.IndexOf("<soapenv:Envelope");

            if (index < 0)
            {
                index = str.IndexOf("\r\n\r\n");
                index += 4;
            }


            var charToReplace = new string[] { "818", "78a", "6e5", "f9c", "\r", "\n" };


            str = str.Remove(0, index);
            str = str.TrimEnd('\r', '\n', '0');

            for (int i = 0; i < charToReplace.Length; i++)
            {
                str = str.Replace(charToReplace[i], "");

            }


            var end = str.IndexOf("</soapenv:Envelope>");

            if (end != -1)
            {
                index = end + "</soapenv:Envelope>".Length;
                if (index < str.Length)
                    str = str.Remove(index);
            }


            return str;
        }


    }
}
