using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxmulator.Core
{
    public class Logger
    {
        private static StringBuilder sb = new StringBuilder();

        public static string GetLog()
        {
            return sb.ToString();
        }


        public static void Log(string text)
        {
            var line = string.Format("[{0}] {1}", DateTime.Now.ToString("hh24:mm:ss"), text);

            sb.Append(line);
            sb.AppendLine();

        }

        public static void Exception(Exception ex, string str)
        {
            var line = string.Format("[{0}] EXCECPTION on {1}: {2}\r\n{3}", DateTime.Now.ToString("hh24:mm:ss"), str, ex.Message, ex.StackTrace);

            sb.Append(line);
            sb.AppendLine();
        }



    }
}
