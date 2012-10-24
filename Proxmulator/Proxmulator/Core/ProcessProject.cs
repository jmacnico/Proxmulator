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

            project.Received.Add(msg);

            var opeation = msg.Operation;
            var steps = project.Project.Steps.Where(s => s.Sent == false);

            while (true)
            {
                var nextStep = steps.FirstOrDefault();

                if (nextStep == null)
                    break;

                if (nextStep.Trigger == TriggerType.None)
                {
                   var sent = Messaging.SendStep(nextStep);
                   nextStep.Sent = true;
                   project.MessagesSent.Add(sent);
                   _form.UpdateStep(nextStep);
                    
                }
                else if (nextStep.Trigger == TriggerType.Operation)
                {
                    if (nextStep.isTriggerOperation(msg))
                    {
                       var sent =  Messaging.SendStep(nextStep, msg.NPU);
                       nextStep.Sent = true;
                       project.MessagesSent.Add(sent);
                       _form.UpdateStep(nextStep);
                    }
                    else
                    {
                        break;
                    }

                }
            }




        }
    }
}
