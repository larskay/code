using System.Collections.Generic;
using System;
using System.Linq;

namespace AMSYSMobile
{
    public class DummyCompanyModules
    {
        public IEnumerable<Company> CompanyModules(int companyId)
        {
            var modules = new List<Company>
            {   
                new Company{ companyId=1, companyModules = new List<Module> { new Module { moduleId = 4, moduleName = "Avvik"}, new Module { moduleId = 1, moduleName = "Vernerunde" } } },
                new Company{ companyId=2, companyModules = new List<Module> { new Module { moduleId = 3, moduleName = "Vernerunde"} } },
                new Company{ companyId=3, companyModules = new List<Module> { new Module { moduleId = 5, moduleName = "NCR"}, new Module { moduleId = 2, moduleName = "Safety Inspection"} } }
            };

            return from m in modules where m.companyId == companyId select m;
        }
    }
    public class Company
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public List<Module> companyModules { get; set; }
    }
    //Module modell
    public class Module
    {
        public int companyId { get; set; }
        public int moduleId { get; set; }
        public string moduleName { get; set; }
        public List<Section> documents { get; set; }
    }
}