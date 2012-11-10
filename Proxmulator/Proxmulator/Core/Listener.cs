using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities;
using System.Net.Sockets;
using System.Net;
using System.Xml;
using System.Threading;
using Proxmulator.Extras;
using System.IO;

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

            _i0Bytes = Encoding.UTF8.GetBytes(_i0);
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
                const int BUFFER_SIZE = 5000;
                var client = obj as TcpClient;

               
                var stream = client.GetStream();
                var http = stream;

                var request = new WebClient();
                
                


                int bytesRead = 0;
                var buffer = new byte[BUFFER_SIZE];
                string data = "";
                
                var sb = new StringBuilder();


                var retries = 0;

                do
                {
                    if (client.Available > 0)
                    {
                        bytesRead = http.Read(buffer, 0, BUFFER_SIZE);

                        if (bytesRead == 0)
                            break;
                        
                        data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        sb.Append(data);
                        
                        buffer = new byte[BUFFER_SIZE];
                    }
                    else
                    {
                        Thread.Sleep(100);
                        retries++;

                        if (retries > 20)
                        {
                            break;
                        }

                    }

                } while ((!data.Contains("</soapenv:Envelope>")) && client.Connected );

                stream.Write(_i0Bytes, 0, _i0Bytes.Length);

                stream.Close();
                client.Close();

                var msg = MessageInfo.LoadFromString(sb.ToString());

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
