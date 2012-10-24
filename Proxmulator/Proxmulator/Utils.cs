using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;

namespace Proxmulator
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
            catch (Exception ex)
            {
                return str;
            }

        }

        internal static Stream GetResourceImage(string filename)
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



        public class HighlightColors
        {
            public static Color HC_NODE = Color.Firebrick;
            public static Color HC_STRING = Color.Blue;
            public static Color HC_ATTRIBUTE = Color.Red;
            public static Color HC_COMMENT = Color.GreenYellow;
            public static Color HC_INNERTEXT = Color.Blue;
        }

        public static void HighlightRTF(RichTextBox rtb)
        {
            int k = 0;

            string str = rtb.Text;

            int st, en;
            int lasten = -1;
            while (k < str.Length)
            {
                st = str.IndexOf('<', k);

                if (st < 0)
                    break;

                if (lasten > 0)
                {
                    rtb.Select(lasten + 1, st - lasten - 1);
                    rtb.SelectionColor = HighlightColors.HC_INNERTEXT;
                }

                en = str.IndexOf('>', st + 1);
                if (en < 0)
                    break;

                k = en + 1;
                lasten = en;

                if (str[st + 1] == '!')
                {
                    rtb.Select(st + 1, en - st - 1);
                    rtb.SelectionColor = HighlightColors.HC_COMMENT;
                    continue;

                }
                String nodeText = str.Substring(st + 1, en - st - 1);


                bool inString = false;

                int lastSt = -1;
                int state = 0;
                /* 0 = before node name
                 * 1 = in node name
                   2 = after node name
                   3 = in attribute
                   4 = in string
                   */
                int startNodeName = 0, startAtt = 0;
                for (int i = 0; i < nodeText.Length; ++i)
                {
                    if (nodeText[i] == '"')
                        inString = !inString;

                    if (inString && nodeText[i] == '"')
                        lastSt = i;
                    else
                        if (nodeText[i] == '"')
                        {
                            rtb.Select(lastSt + st + 2, i - lastSt - 1);
                            rtb.SelectionColor = HighlightColors.HC_STRING;
                        }

                    switch (state)
                    {
                        case 0:
                            if (!Char.IsWhiteSpace(nodeText, i))
                            {
                                startNodeName = i;
                                state = 1;
                            }
                            break;
                        case 1:
                            if (Char.IsWhiteSpace(nodeText, i))
                            {
                                rtb.Select(startNodeName + st, i - startNodeName + 1);
                                rtb.SelectionColor = HighlightColors.HC_NODE;
                                state = 2;
                            }
                            break;
                        case 2:
                            if (!Char.IsWhiteSpace(nodeText, i))
                            {
                                startAtt = i;
                                state = 3;
                            }
                            break;

                        case 3:
                            if (Char.IsWhiteSpace(nodeText, i) || nodeText[i] == '=')
                            {
                                rtb.Select(startAtt + st, i - startAtt + 1);
                                rtb.SelectionColor = HighlightColors.HC_ATTRIBUTE;
                                state = 4;
                            }
                            break;
                        case 4:
                            if (nodeText[i] == '"' && !inString)
                                state = 2;
                            break;


                    }

                }
                if (state == 1)
                {
                    rtb.Select(st + 1, nodeText.Length);
                    rtb.SelectionColor = HighlightColors.HC_NODE;
                }


            }
        }
    }
}
