using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using Proxmulator.Entities;
using System.Threading;

namespace Proxmulator.Core
{
    public class Processer
    {
        private ConcurrentQueue<MessageInfo> _Queue;
        public IProcesser _processSignals;
        public IProcesser _processProject;
        private MainForm _form;

        public Processer(MainForm form)
        {
            _Queue = new ConcurrentQueue<MessageInfo>();
            _processSignals = new ProcessRequestSignal();
            _processProject = new ProcessProject(form);
            _form = form;
        }


        public void AddMessage(MessageInfo msg)
        {
            _Queue.Enqueue(msg);
        }


        private MessageInfo Next()
        {
            MessageInfo msg = null;

            while (true)
            {
                if (_Queue.TryDequeue(out msg))
                    return msg;

                Thread.Sleep(100);
            }

        }


        public void Process()
        {
            while (true)
            {
                var msg = Next();
                var npu = msg.NPU;
                var businessId = msg.BusinessId;

                if (npu != null && (npu.Contains("CESIGNLSUB") || npu.Contains("CEISSGLNOT") || npu.Contains("COEVSIGNAL")))
                {
                    var thread = new Thread(_processSignals.ProcessRequest);
                    thread.Start(msg);
                }
                else if (_form != null && _form.ProjectInstance != null && _form.ProjectInstance.Active == true)
                {
                    if (_form.ProjectInstance.Project.BusinessId == businessId)
                    {
                        var args = new object[] { _form.ProjectInstance, msg };
                        var thread = new Thread(_processProject.ProcessRequest);
                        thread.Start(args);
                    }
                }
            }
        }




    }
}
