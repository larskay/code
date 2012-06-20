using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMSYSMobile
{
    public class DummyTemplate
    {
        //Search for document with LinQ
        public IEnumerable<Module> GetDummyTemplate(int ModuleID, int companyId)
        {
            return from m in ReturnDummyTemplate() where m.moduleId == ModuleID && m.companyId == companyId select m;
        }
        //LinQ to return specific module
        public IEnumerable<Module> GetDummyTemplateCaption(int moduleId)
        {
            return from d in ReturnDummyTemplate() where d.moduleId == moduleId select d;
        }
        //LinQ to return specific module
        public IEnumerable<Module> GetNewDummyTemplate(int ModuleID)
        {
            return from m in ReturnDummyTemplate() where m.moduleId == ModuleID select m;
        }
        public IEnumerable<Module> EditDummyTemplate(int moduleId)
        {
            return from m in ReturnDummyTemplate() where m.moduleId == moduleId select m;
        }
        //Template data for modules
        public IEnumerable<Module> ReturnDummyTemplate()
        {
            return new List<Module>{ 
            new Module{
                companyId = 1,
                moduleId = 1, 
                moduleName = "Vernerunde", 
                documents = new List<Section>{ 
                    new Section{ sectionId = 0, documentId = Sequence.NewDocId, fields= new List<Field>{ 
                        new Field{ fieldId = 0, type="String<=255", caption = "Tittel:", value = new List<string>{ "(None)" }, required = true},
                        new Field{ fieldId = 1, type="GMSDate", caption = "Date:", required = true },
                        new Field{ fieldId = 2, type="GMSList", caption = "Registrert av:", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown>{
                            new Dropdown{ dropdownId = 8, dropdownValue = "Lars Kay"},
                            new Dropdown{ dropdownId = 9, dropdownValue = "Rune Riskedal"},
                            new Dropdown{ dropdownId = 10,dropdownValue = "Marianne Martins" } } },
                        new Field{ fieldId= 3, type = "GMSRadio", caption = "Psykososialt arbeidsmiljø:", value = new List<string>{ "1", "2", "3" ,"4" } },
                        new Field{ fieldId= 4, type = "GMSRadio", caption = "Personslig Verneutstyr:", value = new List<string>{ "1", "2", "3" ,"4" } },
                        new Field{ fieldId= 5, type = "GMSRadio", caption = "Avfallshåndtering:", value = new List<string>{ "1", "2", "3" ,"4" } },
                        new Field{ fieldId= 6, type = "GMSCheckList", caption = "Avfall:", value = new List<string>{ "Brannfarligvæske", "Oljesøl" } },
                        new Field{ fieldId= 7, type = "String>=255", caption = "Kommentar:", value = new List<string>{ "(None)" }, required = true} } } } },
            new Module{
                companyId = 3,
                moduleId = 2, 
                moduleName = "Vernerunde", 
                documents = new List<Section>{ 
                    new Section{ sectionId = 0, documentId = Sequence.NewDocId, fields = new List<Field>{ 
                        new Field{ fieldId = 0, type = "String<=255", caption = "Tittel:", value = new List<string>{ "(None)" }, required = true},
                        new Field{ fieldId = 1, type = "GMSDate", caption = "Date:", required = true },
                        new Field{ fieldId= 2, type = "GMSList", caption = "Registrert av:", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown>{
                            new Dropdown{ dropdownId = 8, dropdownValue = "Lars Kay"},
                            new Dropdown{ dropdownId = 9, dropdownValue = "Rune Riskedal"},
                            new Dropdown{ dropdownId = 10, dropdownValue = "Marianne Martins" } } },
                        new Field{ fieldId= 3, type="GMSRadio", caption="Er Firma ISO sertifisert:", value = new List<string>{ "Ja", "Nei" } },
                        new Field{ fieldId= 4, type="GMSRadio", caption="Generell orden:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 5, type="GMSRadio", caption="Arbeidsstilling::", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 6, type="GMSRadio", caption="Adkomstveier:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 7, type="GMSRadio", caption="Arbeidsstasjon:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 8, type="GMSRadio", caption="Belysning/Lysforhold:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 9, type="GMSRadio", caption="Helsefarlige stoffer:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 10, type="GMSRadio", caption="Klima/ventilasjon:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 11, type="GMSRadio", caption="Dataterminal:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 12, type="GMSRadio", caption="Støy:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 13, type="GMSRadio", caption="Elektrisk utstyr:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 14, type="GMSRadio", caption="Brannsikring:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 15, type="GMSRadio", caption="Skilting:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 16, type="GMSRadio", caption="Sanitærrom:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 17, type="GMSRadio", caption="Personlig verneutstyr:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 18, type="GMSRadio", caption="Spiserom:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 19, type="GMSRadio", caption="Vern på maskiner:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 20, type="GMSRadio", caption="Renhold:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 21, type="GMSRadio", caption="Annet:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 22, type="GMSRadio", caption="Førstehjelpsutstyr:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 23, type="GMSRadio", caption="Psykososialt arbeidsmiljø:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 24, type="GMSRadio", caption="Personslig Verneutstyr:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 25, type="GMSRadio", caption="Avfallshåndtering:", value = new List<string>{ "Ok", "Anm", "I/R" } },
                        new Field{ fieldId= 26, type="GMSCheckList", caption="Avfall:", value = new List<string>{ "Brannfarligvæske", "Oljesøl" } },
                        new Field{ fieldId= 27, type="String>=255", caption="Kommentar:", value = new List<string>{ "(None)" }, required = true} } } } },
            new Module{
                companyId = 2,
                moduleId = 3, 
                moduleName = "Safety Inspection", 
                documents = new List<Section>{ 
                    new Section{ sectionId = 0, documentId = Sequence.NewDocId, fields= new List<Field>{ 
                        new Field{ fieldId= 0, type="String<=255", caption="Title:", value = new List<string>{ "(None)" }, required = true},
                        new Field{ fieldId= 1, type="GMSDate", caption="Date:" },
                        new Field{ fieldId= 2, type="GMSList", caption="Registered by:", value = new List<string>{ "(None)" }, dropdowns= new List<Dropdown>{
                            new Dropdown{ dropdownId=8, dropdownValue="Lars Kay"},
                            new Dropdown{ dropdownId=9, dropdownValue="Rune Riskedal"},
                            new Dropdown{ dropdownId=10, dropdownValue="Marianne Martins" } } },
                        new Field{ fieldId= 3, type="GMSRadio", caption="Psykosomatic work environment:", value = new List<string>{ "1", "2", "3" ,"4" } },
                        new Field{ fieldId= 4, type="GMSRadio", caption="Personal Work Gear:", value = new List<string>{ "1", "2", "3" ,"4" } },
                        new Field{ fieldId= 5, type="GMSRadio", caption="Waste Handling:", value = new List<string>{ "1", "2", "3" ,"4" } },
                        new Field{ fieldId= 6, type="GMSCheckList", caption="Waste:", value = new List<string>{ "Firehazardous liquid", "Oil Spill" } },
                        new Field{ fieldId= 7, type="String>=255", caption="Comments:", value = new List<string>{ "(None)" }, required = true} } } } },
            new Module{ 
                companyId = 1, 
                moduleId = 4, 
                moduleName = "Avvik", 
                documents = new List<Section>{ 
                new Section{ sectionId = 0, documentId = Sequence.NewDocId, fields = new List<Field>{ 
                    new Field { fieldId = 0, type = "String<=255",  caption = "Tittel", value = new List<string>{ "(None)" }, required = true },
                    new Field { fieldId = 1, type = "GMSDate", caption = "Dato" },
                    new Field { fieldId = 2, type = "Number", caption = "Antall personer involvert", value = new List<string>{ "(None)" }, required = true },
                    new Field { fieldId = 3, type = "GMSList", caption = "Registrert av", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown>{
                        new Dropdown{ dropdownId = 8, dropdownValue="Lars Kay"},
                        new Dropdown{ dropdownId = 9, dropdownValue="Rune Riskedal"},
                        new Dropdown{ dropdownId = 10, dropdownValue="Marianne Martins"} } },
                    new Field { fieldId = 4, type="GMSList", caption="Oppdaget av", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown> {
                        new Dropdown { dropdownId = 11, dropdownValue = "Lars Kay"},
                        new Dropdown { dropdownId = 12, dropdownValue = "Rune Riskedal"},
                        new Dropdown { dropdownId = 13, dropdownValue = "Marianne Martins"} } },
                    new Field { fieldId = 5, type="UserList", caption="Mottaker", value = new List<string> { "(None)" }, userListValues = new List<User> { 
                        new User { UserID=1, UserName = "Lars Kay" },
                        new User { UserID=2, UserName = "Rune Riskedal" },
                        new User { UserID=3, UserName = "Tore Gellein" } } },
                    new Field { fieldId = 6, type="GMSList", caption="Avdeling", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown> {
                        new Dropdown { dropdownId = 17, dropdownValue = "IT"},
                        new Dropdown { dropdownId = 18, dropdownValue = "Admin" } } },
                    new Field { fieldId = 7, type="String>=255", caption="Beskrivelse", value = new List<string>{ "(None)" } } } } } },
            new Module{ 
                companyId = 2, 
                moduleId = 5, 
                moduleName = "NCR", 
                documents = new List<Section>{ 
                new Section{ sectionId = 0, documentId = Sequence.NewDocId, fields = new List<Field>{ 
                    new Field { fieldId = 0, type = "String<=255",  caption = "Title", value = new List<string>{ "(None)" }, required = true },
                    new Field { fieldId = 1, type = "GMSDate", caption = "Date" },
                    new Field { fieldId = 2, type = "Number", caption = "People involved", value = new List<string>{ "(None)" }, required = true },
                    new Field { fieldId = 3, type = "GMSList", caption = "Registered by", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown>{
                        new Dropdown{ dropdownId = 8, dropdownValue="Lars Kay"},
                        new Dropdown{ dropdownId = 9, dropdownValue="Rune Riskedal"},
                        new Dropdown{ dropdownId = 10, dropdownValue="Marianne Martins"} } },
                    new Field { fieldId = 4, type="GMSList", caption="Discoverd by", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown> {
                        new Dropdown { dropdownId = 11, dropdownValue = "Lars Kay"},
                        new Dropdown { dropdownId = 12, dropdownValue = "Rune Riskedal"},
                        new Dropdown { dropdownId = 13, dropdownValue = "Marianne Martins"} } },
                    new Field { fieldId = 5, type="UserList", caption="Reciever", value = new List<string> { "(None)" }, userListValues = new List<User> { 
                        new User { UserID=1, UserName = "Lars Kay" },
                        new User { UserID=2, UserName = "Rune Riskedal" },
                        new User { UserID=3, UserName = "Tore Gellein" } } },
                    new Field { fieldId = 6, type="GMSList", caption="Department", value = new List<string>{ "(None)" }, dropdowns = new List<Dropdown> {
                        new Dropdown { dropdownId = 17, dropdownValue = "IT"},
                        new Dropdown { dropdownId = 18, dropdownValue = "Admin" } } },
                    new Field { fieldId = 7, type="String>=255", caption="Decription", value = new List<string>{ "(None)" } } } } } },
            new Module{
                companyId=3,
                moduleId=6, 
                moduleName="Avviksbehandling", 
                documents= new List<Section>{
                new Section { sectionId = 1, documentId = Sequence.NewDocId, sectionName = "Avviksbehandling", fields = new List<Field>{
                        new Field { fieldId = 0, type = "String<=255", caption = "Tittel", value = new List<string> { "(None)" }, required = true},
                        new Field { fieldId = 1, type = "GMSList", caption = "Registrert av", dropdowns = new List<Dropdown>{
                            new Dropdown{ dropdownId = 7, dropdownValue="Lars Kay"},
                            new Dropdown{ dropdownId = 8, dropdownValue="Rune Riskedal"},
                            new Dropdown{ dropdownId = 9, dropdownValue="Marianne Martins"} } },
                        new Field { fieldId = 2, type = "GMSDate", caption = "Hendelsesdato" },
                        new Field { fieldId = 3, type = "GMSList", caption = "Mottaker", dropdowns = new List<Dropdown>{
                            new Dropdown{ dropdownId = 7, dropdownValue="Lars Kay"},
                            new Dropdown{ dropdownId = 8, dropdownValue="Rune Riskedal"},
                            new Dropdown{ dropdownId = 9, dropdownValue="Marianne Martins"} } },
                        new Field { fieldId = 4, type = "GMSList", caption = "Type Hendelse", dropdowns = new List<Dropdown>{
                            new Dropdown{ dropdownId = 7, dropdownValue="Lars Kay"},
                            new Dropdown{ dropdownId = 8, dropdownValue="Rune Riskedal"},
                            new Dropdown{ dropdownId = 9, dropdownValue="Marianne Martins" } } },
                        new Field { fieldId = 5, type = "GMSList", caption = "Produkt Involvert", dropdowns = new List<Dropdown> {
                            new Dropdown{ dropdownId = 7, dropdownValue="Lars Kay"},
                            new Dropdown{ dropdownId = 8, dropdownValue="Rune Riskedal"},
                            new Dropdown{ dropdownId = 9, dropdownValue="Marianne Martins"} } },
                        new Field { fieldId = 6, type = "GMSList", caption = "Mottakers avd"} } } } }
            };
        }
    }

}
