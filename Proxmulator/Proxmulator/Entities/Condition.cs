using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Proxmulator.Extras;

namespace Proxmulator.Entities
{
    public enum EnumCondition { EQUAL = 1, LIKE = 2}

    public class Condition
    {
        public string ValueToCompare { get;  set; }
        public string ValueLocation { get;  set; }
        public bool Active { get; set; }

        public EnumCondition Comparator { get;  set; }

        public Condition()
        {

        }


        public Condition(string valueToCompare, string xpath, EnumCondition comp)
        {
            ValueToCompare = valueToCompare;
            ValueLocation = xpath;
            Comparator = comp;
        }


        public bool IsConditionTrue(XmlDocument xml)
        {
            XmlNode node = null;
            if (this.ValueLocation.Contains("/"))
            {
                node = xml.SelectSingleNode(this.ValueLocation);
            }
            else
            {
                node = Utils.SelectNode(xml, this.ValueLocation);
            }

            if (node == null)
                return false;

            var value = node.InnerXml;

            switch (Comparator)
            {
                case EnumCondition.EQUAL:
                    return ValueToCompare == value;

                case EnumCondition.LIKE:
                    return value.Contains(ValueToCompare);

            }
            return false;
        }


    }
}
