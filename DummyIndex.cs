using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMSYSMobile
{
    public class DummyIndex
    {   //LinQ to return dummyindex for specific module and user
        public IEnumerable<Section> GetDummyIndex(int moduleId, int pageSize, int pageNumber)
        {
            var index = from m in ReturnDummyIndex() where m.moduleId == moduleId select m;
            if (pageSize > 0) index = index.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return index;
        }
        //Builds document and returns it for registration
        public Module EditDummyPage(int userId, int moduleId, string moduleName, int documentId)
        {
            var editedDocument = new Module();
            editedDocument.documents = new List<Section>(from m in ReturnDummyIndex() where m.documentId == documentId select m);
            editedDocument.companyId = userId;
            editedDocument.moduleId = moduleId;
            editedDocument.moduleName = moduleName;
            return editedDocument;
        }
        public IEnumerable<Section> GetDummyDocument(int documentId)
        {
            return from d in ReturnDummyIndex() where d.documentId == documentId select d;
        }
        //Dummy data for index and documents
        public IEnumerable<Section> ReturnDummyIndex()
        {
            return new List<Section> {
                    new Section { moduleId = 1, sectionId = 0, documentId = 1, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 1" }},
                        new Field { fieldId = 1, value = new List<string>{ "25/01/2012" }},
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" }},
                        new Field { fieldId= 3, value = new List<string>{ "4" } },
                        new Field { fieldId= 4, value = new List<string>{ "4" } },
                        new Field { fieldId= 5, value = new List<string>{ "4" } },
                        new Field { fieldId= 6, value = new List<string>{"Brannfarligvæske"} },
                        new Field { fieldId= 7, value = new List<string>{ "Må fixes"} } } },
                    new Section { moduleId = 1, sectionId = 0, documentId = 2, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 2" } },
                        new Field { fieldId = 1, value = new List<string>{ "26/01/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "3"} },
                        new Field { fieldId= 4, value = new List<string>{ "2"} },
                        new Field { fieldId= 5, value = new List<string>{ "4" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Må fixes umiddelbart" } } } },
                    new Section { moduleId = 1, sectionId = 0, documentId = 3, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 3" } },
                        new Field { fieldId = 1, value = new List<string>{ "27/01/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "4" } },
                        new Field { fieldId= 4, value = new List<string>{ "3" } },
                        new Field { fieldId= 5, value = new List<string>{ "4" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Helt OK!!" } } } },
                    new Section { moduleId = 1, sectionId = 0, documentId = 4, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 4" } },
                        new Field { fieldId = 1, value = new List<string>{ "01/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "2" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "2" } },
                        new Field { fieldId= 6, value = new List<string>{"Brannfarligvæske", "Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "2 ting må gjøres" } } } },
                    new Section { moduleId = 1, sectionId = 0, documentId = 5, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 5" } },
                        new Field { fieldId = 1, value = new List<string>{ "11/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "4"} },
                        new Field { fieldId= 4, value = new List<string>{ "3"} },
                        new Field { fieldId= 5, value = new List<string>{ "2" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Helt Greit" } } } },
                    new Section { moduleId = 1, sectionId = 0, documentId = 6, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 6" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 7, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 7" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 8, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 8" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 9, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 9" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 10, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 10" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 11, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 11" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 12, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 12" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                        new Section { moduleId = 1, sectionId = 0, documentId = 13, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Vernerunde 13" }},
                        new Field { fieldId = 1, value = new List<string>{ "13/02/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId= 3, value = new List<string>{ "1" } },
                        new Field { fieldId= 4, value = new List<string>{ "2" } },
                        new Field { fieldId= 5, value = new List<string>{ "3" } },
                        new Field { fieldId= 6, value = new List<string>{"Oljesøl"} },
                        new Field { fieldId= 7, value = new List<string>{ "Umiddelbar Fiksing" } } } },
                    new Section{ moduleId = 2, sectionId = 0, documentId = 12, fields= new List<Field>{ 
                        new Field { fieldId= 0, value = new List<string>{ "Vernerunde Tore Gellein" } },
                        new Field { fieldId= 1, caption="Date:", value= new List<string>{"20/05/2011"} },
                        new Field { fieldId= 2, value = new List<string>{ "Tore Gellein" } },
                        new Field { fieldId= 3, value = new List<string>{ "Ja" } },
                        new Field { fieldId= 4, value = new List<string>{ "Anm"} },
                        new Field { fieldId= 5, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 6, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 7, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 8, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 9, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 10, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 11, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 12, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 13, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 14, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 15, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 16, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 17, value = new List<string>{ "Anm"} },
                        new Field { fieldId= 18, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 19, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 20, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 21, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 22, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 23, value = new List<string>{ "Anm" } },
                        new Field { fieldId= 24, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 25, value = new List<string>{ "Ok" } },
                        new Field { fieldId= 26, value = new List<string>{ "Brannfarligvæske", "Oljesøl" } },
                        new Field { fieldId= 27, value = new List<string>{ "Noen anmerkninger men ellers ok" }, required = true} } },
                    new Section { moduleId = 3, sectionId = 0, documentId = 7, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Rune Sin" } },
                        new Field { fieldId = 1, value = new List<string>{ "25/01/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Rune Riskdal" } },
                        new Field { fieldId = 3, value = new List<string>{ "4" } },
                        new Field { fieldId = 4, value = new List<string>{ "3" } },
                        new Field { fieldId = 5, value = new List<string>{ "2" } },
                        new Field { fieldId = 6, value = new List<string>{"Firehazardous liquid"} },
                        new Field { fieldId = 7, value = new List<string>{ "Must be fixed"} } } },
                    new Section { moduleId = 3, sectionId = 0, documentId = 8, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Rune's safety Inspection" } },
                        new Field { fieldId = 1, value = new List<string>{ "26/01/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Rune Riskedal" } },
                        new Field { fieldId = 3, value = new List<string>{ "3"} },
                        new Field { fieldId = 4, value = new List<string>{ "2"} },
                        new Field { fieldId = 5, value = new List<string>{ "4" } },
                        new Field { fieldId = 6, value = new List<string>{"Firehazardous liquid"} },
                        new Field { fieldId= 7, value = new List<string>{ "Fixed ASAP" } } } },
                    new Section { moduleId = 3, sectionId = 0, documentId = 9, fields = new List<Field> { 
                        new Field { fieldId = 0, value = new List<string>{ "Rune sin vernerunde 1" }, required = true },
                        new Field { fieldId = 1, value = new List<string>{ "27/01/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId = 3, value = new List<string>{ "4" } },
                        new Field { fieldId = 4, value = new List<string>{ "3" } },
                        new Field { fieldId = 5, value = new List<string>{ "4" } },
                        new Field { fieldId = 6, value = new List<string>{"Firehazardous liquid", "Oil Spill"} },
                        new Field { fieldId = 7, value = new List<string>{ "Perfectly Fine!!" } } } },
                    new Section{ moduleId = 4, sectionId = 0, documentId = 10, fields= new List<Field> {
                        new Field { fieldId = 0, value = new List<string>{ "Lars sitt første avvik" } },
                        new Field { fieldId = 1, value = new List<string>{ "20/01/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "3" } },
                        new Field { fieldId = 3, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId = 4, value = new List<string>{ "Rune Riskedal" } },
                        new Field { fieldId = 5, value = new List<string>{ "Rune Riskedal"} },
                        new Field { fieldId = 6, value = new List<string>{ "HMSK" } },
                        new Field { fieldId = 7, value = new List<string>{ "Isolasjon på ledning ødelagt" } } } },
                    new Section{ moduleId = 5, sectionId = 0, documentId = 11, fields= new List<Field> {
                        new Field { fieldId = 0, value = new List<string>{ "Rune's first NCR" } },
                        new Field { fieldId = 1, value = new List<string>{ "23/04/2012" } },
                        new Field { fieldId = 2, value = new List<string>{ "4" } },
                        new Field { fieldId = 3, value = new List<string>{ "Lars Kay" } },
                        new Field { fieldId = 4, value = new List<string>{ "Rune Riskedal" } },
                        new Field { fieldId = 5, value = new List<string>{ "Lars Kay"} },
                        new Field { fieldId = 6, value = new List<string>{ "QHSE" } },
                        new Field { fieldId = 7, value = new List<string>{ "USB cable broken" } } } }
            };
        }
    }

        //Documents model
        public class Section
        {
            public int moduleId { get; set; }
            public int documentId { get; set; }
            public int sectionId { get; set; }
            public string sectionName { get; set; }
            public List<Field> fields { get; set; }
        }
        //Field modell
        public class Field
        {
            public int fieldId { get; set; }
            public string type { get; set; }
            public string caption { get; set; }
            public bool required { get; set; }
            public List<string> value { get; set; }
            public List<Dropdown> dropdowns { get; set; }
            public List<User> userListValues { get; set; }
        }
        //UserList Modell
        public class UserList
        {
            public int userID { get; set; }
            public string userName { get; set; }
        }
        //Dropdown modell
        public class Dropdown
        {
            public int dropdownId { get; set; }
            public string dropdownValue { get; set; }
        }
        //Returns a new integer for document ID
        public class Sequence
        {
            private static int _value = 0;
            public static int NewDocId
            {
                get
                {
                    System.Nullable<Int32> documentId =
                        (from id in new DummyIndex().ReturnDummyIndex() select id.documentId)
                        .Max();
                    return ++_value;
                }
            }
        }
}