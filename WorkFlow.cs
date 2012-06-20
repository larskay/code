using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMSYSMobile
{
    public class WorkFlow
    {
        public IEnumerable<EmailModel> WorkFlowObject()
        {
            return new List<EmailModel> { new EmailModel { wfModuleID = 20, wfFieldID = 5, wfFromField = "DontReply@antenor.no", wfEmailBody = "Du har et avvik som venter på din godkjennelse" },
                                          new EmailModel { wfModuleID = 21, wfFieldID = 5, wfFromField = "DontReply@antenor.no", wfEmailBody = "You have an NCR waiting for your approval" } };
        }

        public IEnumerable<EmailModel> SendEmail(int wfModuleID)
        {
            return from w in new WorkFlow().WorkFlowObject() where w.wfModuleID == wfModuleID select w;
        }
    }
    public class EmailModel
    {
        public int wfModuleID { get; set; }
        public int wfFieldID { get; set; }
        public string wfEmailBody { get; set; }
        public string wfFromField { get; set; }
    }
}