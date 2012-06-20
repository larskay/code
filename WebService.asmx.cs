using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace AMSYSMobile
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<User> GetUserService(string UserName, string PassWord)
        {
            return new DummyUser().GetDummyUser(UserName, PassWord).ToList();
        }
        //Webservice for returning Modules for combobox
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Company> GetModulesService(int companyId)
        {
            return new DummyCompanyModules().CompanyModules(companyId);
        }
        //Service with all documents for a specific user and module
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Section> IndexService(int moduleId, int pageSize, int pageNumber)
        {
            return new DummyIndex().GetDummyIndex(moduleId, pageSize, pageNumber);
        }
        //Service for returning new registration form
        //[WebMethod]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public IEnumerable<Module> NewPageService(int ModuleID)
        //{
        //    return new DummyTemplate().GetNewDummyTemplate(ModuleID);
        //}
        //Service for editing registered documents
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Module EditPageService(int UserID, int ModuleID, string ModuleName, int DocumentID)
        {
            return new DummyIndex().EditDummyPage(UserID, ModuleID, ModuleName, DocumentID);
        }
        //Service for posting edited document
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Module EditNewPageService(Module module)
        {
            return module;
        }
        //Service for returning Caption for index
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Module> GetTemplateCaptionService(int moduleId)
        {
            return new DummyTemplate().GetDummyTemplateCaption(moduleId);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Module> GetTemplateService(int ModuleID, int companyId)
        {
            return new DummyTemplate().GetDummyTemplate(ModuleID, companyId);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Section> GetDocumentService(int DocumentID)
        {
            return new DummyIndex().GetDummyDocument(DocumentID);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<EmailModel> SendToApprovalService(int wfModuleID)
        {
            return new WorkFlow().SendEmail(wfModuleID);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Module> EditTemplateService(int moduleId)
        {
            return new DummyTemplate().EditDummyTemplate(moduleId);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public IEnumerable<Section> EditDummyDocumentService(int documentId)
        {
            return new DummyIndex().GetDummyDocument(documentId);
        }

    }
}
