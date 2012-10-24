using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Proxmulator.Entities
{
    public class ProjectInstance 
    {
        [XmlIgnore]
        public List<MessageSent> MessagesSent { get; set; }
        [XmlIgnore]
        public List<MessageInfo> Received { get; set; }


        public Project Project { get; set;}

        public ProjectInstance(Project p) : this()
        {
            Project = p;
        }

        public ProjectInstance()
        {
            MessagesSent = new List<MessageSent>();
            Received = new List<MessageInfo>();
        }
    }


    public enum MessageStatusEnum { OK, Fail }

    public class MessageSent
    {
        public MessageInfo Msg { get; set; }
        public string Send { get; set; }
        public string Received { get; set; }
        public string Url { get; set; }

        public string NPU { get; set; }
        public MessageStatusEnum Status { get; set; }
        public DateTime Date { get; set; }

    }


}
