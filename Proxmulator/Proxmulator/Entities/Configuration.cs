﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Xml;

namespace Proxmulator.Entities
{
    public class SoapAction
    {
        public string InterfaceToInvoke { get; set; }
        public string Operation { get; set; }
        public string Action { get; set; }


        public SoapAction()
        {

        }

        public SoapAction(string inter, string oper, string action){
            this.InterfaceToInvoke = inter;
            this.Operation = oper;
            this.Action = action;

        }

    }
  

    public class XmlConfiguration
    {
        public int ListenerPort { get; set; }
        public string UrlReturn { get; set; }
        
        public List<OperationName> OperationNames { get; set; }
        public List<DBConnection> Connections { get; set; }
        public List<SoapAction> SoapActions { get; set; }
        public List<KeyValueInfo> Urls { get; set; }

        public string IgnoreOperations { get; set; }
        public string IgnoreChunks { get; set; }

        public XmlConfiguration()
        {
            OperationNames = new List<OperationName>();
            Connections = new List<DBConnection>();
            Urls = new List<KeyValueInfo>();
            SoapActions = new List<SoapAction>();
        }
    }


    public static class Configuration
    {
        public static int ListenerPort { get; set; }
        public static string UrlReturn { get; set; }
        public static List<OperationName> OperationNames { get; set; }
        public static List<DBConnection> Connections { get; set; }
        public static string IgnoreOperations { get; set; }
        public static string IgnoreChunks { get; set; }

        public static List<KeyValueInfo> Urls { get; set; }
        public static List<SoapAction> SoapActions { get; set; }

        static Configuration()
        {
        }


        public static void Load()
        {
            var serializer = new XmlSerializer(typeof(XmlConfiguration));

            var path = GetConfigurationPath();
            XmlConfiguration conf = null;

            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                conf = (XmlConfiguration)serializer.Deserialize(reader);
            }

            if (conf == null)
            {
                ListenerPort = 8888;
                UrlReturn = "http://localhost:8080/cwf/services/ptMsgInInt";
                OperationNames = new List<OperationName>();
                Connections = new List<DBConnection>();
                Urls = new List<KeyValueInfo>();
                SoapActions = new List<SoapAction>();

            }
            else
            {
                ListenerPort = conf.ListenerPort;
                UrlReturn = conf.UrlReturn;
                OperationNames = conf.OperationNames;
                Connections = conf.Connections;
                IgnoreOperations = conf.IgnoreOperations;
                Urls = conf.Urls;
                SoapActions = conf.SoapActions;
                IgnoreChunks = conf.IgnoreChunks;
            }
        }


        public static void Save()
        {
            var serializer = new XmlSerializer(typeof(XmlConfiguration));
            var writer = new StreamWriter(GetConfigurationPath());

            var xml = new XmlConfiguration();
            xml.ListenerPort = ListenerPort;
            xml.UrlReturn = UrlReturn;
            xml.OperationNames = OperationNames;
            xml.Connections = Connections;
            xml.IgnoreOperations = IgnoreOperations;
            xml.SoapActions = SoapActions;
            xml.Urls = Urls;
            xml.IgnoreChunks = IgnoreChunks;

            serializer.Serialize(writer, xml);
            writer.Close();

        }


        private static string GetConfigurationPath()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..");

            return Path.Combine(path, "proxmulator.config");
        }




    }


}
