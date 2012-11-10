using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxmulator.Entities;

namespace Proxmulator.Core
{
    public class ProcessProject : IProcesser
    {

        private MainForm _form;

        public ProcessProject(MainForm form)
        {
            _form = form;
        }


        public void ProcessRequest(object args)
        {
            var arr = args as object[];
            ProjectInstance project = arr[0] as ProjectInstance;
            MessageInfo msg = arr[1] as MessageInfo;

            var opeation = msg.Operation;
            var steps = project.Project.Steps.Where(s => s.Sent == false);

            var triggerFire = false;

            while (true)
            {
                var nextStep = steps.FirstOrDefault();

                if (nextStep == null)
                    break;

                var trigger = nextStep.Trigger;

                if (trigger.RunTrigger(msg, project.Received, triggerFire))
                {
                    var npu = trigger.NpuToUse;
                    var sent = Messaging.SendStep(nextStep, npu);
                    nextStep.Sent = true;
                    project.MessagesSent.Add(sent);
                    _form.UpdateStep(nextStep);
                    
                    triggerFire = true;
                }
                else
                {
                    break;
                }

            }

            if (triggerFire)
            {
                project.Received.Add(msg);
            }



        }
    }
}
