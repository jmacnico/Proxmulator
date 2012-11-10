using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;

namespace Proxmulator.Extras
{
    public class Utils
    {

        public static string GetResourceTextFile(string filename)
        {
            string result = string.Empty;

            

            using (Stream stream = typeof(Utils).Assembly.
                        GetManifestResourceStream("Proxmulator.Resources." + filename))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }
            return result;
        }


        public static string PrettyPrint(XmlDocument xml)
        {
            var result = "";

            if (xml == null)
                return result;

            using (var ms = new MemoryStream())
            {
                var writer = new XmlTextWriter(ms, Encoding.Unicode);
                writer.Formatting = Formatting.Indented;

                xml.WriteTo(writer);

                writer.Flush();
                ms.Flush();

                ms.Position = 0;

                var reader = new StreamReader(ms);
                result = reader.ReadToEnd();

                writer.Close();
                reader.Close();

            }

            return result;
        }

        public static string PrettyPrint(string str)
        {
            try
            {
                var xml = new XmlDocument();
                xml.LoadXml(str);
                return PrettyPrint(xml);
            }
            catch (Exception)
            {
                return str;
            }

        }

        public  static Stream GetResourceImage(string filename)
        {
            var stream = typeof(Utils).Assembly.GetManifestResourceStream("Proxmulator.Resources.Images." + filename);
            return stream;
        }

        public static XmlNode SelectNode(XmlDocument xml, string name)
        {
            var xPath = string.Format(".//*[local-name()='{0}']", name);

            var node = xml.SelectSingleNode(xPath);

            return node;
        }

    }
}
