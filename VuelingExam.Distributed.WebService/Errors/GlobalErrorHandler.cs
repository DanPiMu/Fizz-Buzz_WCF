using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;

namespace VuelingExam.Distributed.WebService.Errors
{
    public class GlobalErrorHandler
    {
        // private readonly ILog _log;
        private static readonly ILog _log = log4net.LogManager.
            GetLogger(System.Reflection.MethodBase.
            GetCurrentMethod().DeclaringType);

        public GlobalErrorHandler()
        {

        }

        public bool HandleError(Exception error)
        {
            _log.Error(string.Format(@"Exception caught at Service Application 
                                GlobalErrorHandler{0}Method: {1}{2}Message: {3} 
                                StackTrace {4}{5}",
                Environment.NewLine, error.TargetSite.Name,
                Environment.NewLine, error.Message,
                Environment.NewLine, error.StackTrace));
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error.Source != "CustomValidations")
            {
                var newEx = new FaultException(
                    string.Format(@"Exception caught at Service Application 
                                     GlobalErrorHandler{0}Method: {1}{2}Message: {3}",
                    Environment.NewLine, error.TargetSite.Name,
                    Environment.NewLine, error.Message));

                MessageFault msgFault = newEx.CreateMessageFault();
                fault = Message.CreateMessage(version, msgFault, newEx.Action);
            }
        }
    }
}