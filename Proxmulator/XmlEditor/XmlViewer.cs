using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace XmlEditor
{
    public partial class XmlViewer : UserControl
    {
        public XmlViewer()
        {
            InitializeComponent();
            _xslt = GetResourceTextFile("prettyPrint.xslt");
        }

        private string _xml;
        private string _xslt;


        public string Text
        {
            set
            {
                _xml = value;

                BindXml();
            }
            get
            {
                return _xml;
            }

        }

        private void BindXml()
        {
            try
            {
                var xml = new XmlDocument();
                xml.LoadXml(_xml);

                XPathDocument myXPathDoc = new XPathDocument(new XmlNodeReader(xml));

                XslCompiledTransform myXslTrans = new XslCompiledTransform(true);
                var xslt = XmlReader.Create(new StringReader(_xslt));
                myXslTrans.Load(xslt);

                var ms = new MemoryStream();
                XmlTextWriter myWriter = new XmlTextWriter(ms, Encoding.UTF8);
                myXslTrans.Transform(myXPathDoc, null, myWriter);

                ms.Seek(0, SeekOrigin.Begin);
                var reader = new StreamReader(ms);

                var html = reader.ReadToEnd();

                webBrowser1.DocumentText = html;
            }
            catch (Exception)
            {
                webBrowser1.DocumentText = _xml;
            }
        }

        public static string GetResourceTextFile(string filename)
        {
            string result = string.Empty;



            using (Stream stream = typeof(XmlViewer).Assembly.
                        GetManifestResourceStream("XmlEditor." + filename))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }
            return result;
        }

    }
}
