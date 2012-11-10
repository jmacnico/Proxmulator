using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Proxmulator.Core;
using Oracle.DataAccess.Client;
using System.Xml.Serialization;


namespace Proxmulator.Entities
{
    public class MessageInfo
    {

        public string NPU { get; set; }
        public string CorrelationNPU { get; set; }
        public string ProcessId { get; set; }
        public string BusinessId { get; set; }
        public string Operation { get; set; }
        public string SoapAction { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
        public DateTime ReceivedDatetime { get; set; }
        public string InterfaceToInvoke { get; set; }


        [XmlIgnore]
        public string System
        {
            get { return NPU.Substring(0, 4); }
        }

        private string _Payload;

        [XmlIgnore]
        public string Payload
        {
            get { return _Payload; }
            set
            {
                _Payload = value;
                _xml = null;

            }
        }

        [XmlElement("Payload")]
        public XmlCDataSection CDataPayLoad
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                return doc.CreateCDataSection(Payload);
            }
            set
            {
                Payload = value.Value;
            }
        }

        [XmlIgnore]
        private XmlDocument _xml;

        [XmlIgnore]
        public XmlDocument xml
        {
            get
            {
                if (_xml == null && !string.IsNullOrEmpty(this.Payload))
                {
                    try
                    {
                        _xml = new XmlDocument();
                        _xml.LoadXml(this.Payload);
                        return _xml;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }

                return _xml;
            }
            set
            {
                _xml = value;
            }

        }



        public static MessageInfo LoadFromString(string str)
        {
            var msg = new MessageInfo();
            msg.Payload = str;

            str = CommunicationWS.cleanStream(str);

            msg.ReceivedDatetime = DateTime.Now;
            ProcessXML(str, msg);
            msg.Name = GetPrettyName(msg.Operation, msg.SoapAction);


            return msg;
        }


        public static MessageInfo LoadFromDB(OracleDataReader reader)
        {
            var msg = new MessageInfo();

            //npu, correlationNpu, businessid, creationdate, processid, interfacetoinvoke, operation, payload

            msg.NPU = reader.GetString(0);
            msg.CorrelationNPU = reader.IsDBNull(1) ? null : reader.GetString(1);
            msg.BusinessId = reader.IsDBNull(2) ? null : reader.GetString(2);
            msg.ReceivedDatetime = reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3);
            msg.ProcessId = reader.IsDBNull(4) ? null : reader.GetString(4);
            msg.InterfaceToInvoke = reader.IsDBNull(5) ? null : reader.GetString(5);

            var oper = msg.NPU.Substring(4, 10);
            msg.Operation = oper;

            if (!string.IsNullOrEmpty(msg.CorrelationNPU))
                oper = msg.CorrelationNPU.Substring(4, 10);


            msg.Name = GetPrettyName(oper, null);

            var blob = reader.GetOracleBlob(7);

            var sb = new StringBuilder();

            var buffer = new byte[1000];

            while ((blob.Read(buffer, 0, buffer.Length)) > 0)
            {

                sb.Append(Encoding.UTF8.GetString(buffer));
                Array.Clear(buffer, 0, buffer.Length);

            }

            msg.Payload = sb.ToString().Trim('\0');


            return msg;
        }


        public static string GetPrettyName(string ope, string soapAction)
        {
            var c = Configuration.OperationNames.FirstOrDefault(a => a.Operation == ope || a.Operation == soapAction);

            if (c != null)
                return c.Name;

            return ope;
        }

        public static string GetOperationFromNPU(string npu)
        {
            if (!string.IsNullOrEmpty(npu))
                return npu.Substring(4, 10);

            return null;

        }




        private static XmlDocument ProcessXML(string str, MessageInfo msg)
        {
            try
            {
                var xml = new XmlDocument();
                xml.LoadXml(str);

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xml.NameTable);

                var npu = xml.SelectSingleNode(".//*[local-name()='npu']");
                var corr = xml.SelectSingleNode(".//*[local-name()='correlationNpu']");
                var processId = xml.SelectSingleNode(".//*[local-name()='processId']");
                var businessId = xml.SelectSingleNode(".//*[local-name()='processName']");

                if (npu == null)
                    npu = xml.SelectSingleNode(".//npu", nsmgr);

                if (corr == null)
                    corr = xml.SelectSingleNode(".//correlationNpu", nsmgr);

                if (processId == null)
                    processId = xml.SelectSingleNode(".//processId", nsmgr);

                if (businessId == null)
                    businessId = xml.SelectSingleNode(".//processName", nsmgr);


                if (npu != null)
                {
                    msg.NPU = npu.InnerXml;
                    msg.Operation = msg.NPU.Substring(4, 10);
                }

                if (corr != null)
                {
                    msg.CorrelationNPU = corr.InnerXml;
                }

                if (processId != null)
                {
                    msg.ProcessId = processId.InnerXml;
                }


                if (businessId != null)
                    msg.BusinessId = businessId.InnerXml;

                msg.xml = xml;

                return xml;
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "ProcessXML: XML->" + str);

                msg.NPU = "empty";
                msg.Name = "Error";
                msg.Operation = "Error";
            }

            return null;

        }






    }
}
