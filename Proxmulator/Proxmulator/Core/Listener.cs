using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities;
using System.Net.Sockets;
using System.Net;
using System.Xml;
using System.Threading;

namespace Proxmulator.Core
{
    public class Listener
    {
       
        private string _i0;
        static bool _running = false;

        private Processer _Processer;
        private Thread _ThreadProcesser;

        private TcpListener _listener = null;
        private MainForm _form;
        private byte[] _i0Bytes;

        public Listener(MainForm form)
        {
            _i0 = Utils.GetResourceTextFile("I0.xml");
           
            _Processer = new Processer(form);
            _form = form;
        }


        public void Start()
        {
            _running = true;

            _ThreadProcesser = new Thread(_Processer.Process);
            _ThreadProcesser.Start();


            _i0Bytes = Encoding.ASCII.GetBytes(_i0);
            _listener = new TcpListener(IPAddress.Loopback, Configuration.ListenerPort);

            _listener.Start(50);

            Logger.Log("Listener started on " + Configuration.ListenerPort);
            Logger.Log("Wait connections...");
            while (_running)
            {
                try
                {
                    var client = _listener.AcceptTcpClient();
                    var thread2 = new Thread(new ParameterizedThreadStart(ProcessRequest));
                    thread2.Start(client);

                }
                catch (Exception ex)
                {
                    Logger.Exception(ex, "Listener");
                }
            }
        }


        internal void Stop()
        {
            _running = false;
            if (_listener != null)
                _listener.Stop();
            if (_ThreadProcesser != null)
            {
                _ThreadProcesser.Abort();
            }

        }


        private void ProcessRequest(object obj)
        {
            try
            {
                var client = obj as TcpClient;
                
                var stream = client.GetStream();
                int bytesRead = 0;
                var buffer = new Byte[client.ReceiveBufferSize];
                string data = "";
                string allData = "";
                var sb = new StringBuilder();

                do
                {
                    if (client.Available > 0)
                    {
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        sb.Append(data);

                        allData = sb.ToString();

                    }
                    else
                    {
                        Thread.Sleep(30);
                    }


                } while ((!allData.Contains("</soapenv:Envelope>")) && client.Connected);

                stream.Write(_i0Bytes, 0, _i0Bytes.Length);

                stream.Close();
                client.Close();

                var msg = MessageInfo.LoadFromString(allData);

                Logger.Log("Message received:" + msg.NPU);

                _Processer.AddMessage(msg);
                _form.AddMessage(msg);

                
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Listener:Process Request");

            }

        }






    }
}
