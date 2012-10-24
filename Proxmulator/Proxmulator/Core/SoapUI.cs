using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities;
using System.IO;

namespace Proxmulator.Core
{
    public class SoapUI
    {

        public static Stream Export(Project project){

            var testCase = Utils.GetResourceTextFile("soapUI-TestCase.xml");
            var testStep = Utils.GetResourceTextFile("soapUI-TestStep.xml");

            var dic = new Dictionary<string, int>();

            var sb = new StringBuilder();
            var sbSteps = new StringBuilder();

            foreach (var s in project.Steps)
            {
                var index = 0;

                if (!dic.ContainsKey(s.Name))
                {
                    dic.Add(s.Name, index);
                }
               

                dic[s.Name]++;

                var stepName = string.Format("{0} - {1}", s.Name, dic[s.Name]);
                var content = s.Message.Payload.TrimEnd('\0');
                sbSteps.AppendFormat(testStep, stepName, content, s.UrlResponse);
                sbSteps.AppendLine();
            }



            sb.AppendFormat(testCase, project.Name, sbSteps.ToString());

            var bytes = Encoding.UTF8.GetBytes(sb.ToString());

            var ms = new MemoryStream(bytes);
            return ms;
        }

    }
}
