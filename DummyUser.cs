using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMSYSMobile
{
    public class DummyUser
    {
        //Dummy users
        public IEnumerable<User> DummyUsers()
        {
            return new List<User> { new User { company = new Company{ companyId = 1 }, UserID = 1, UserName="antlak", Password="antlak", Name = "Lars Kay", Address = "Hoddelande 11", Email="lars@antenor.no"},
                                    new User { company = new Company{ companyId = 2 }, UserID = 2, UserName="anttg", Password="anttg", Name = "Tore Gellein", Address="Der han bor", Email="tore@antenor.no"},
                                    new User { company = new Company{ companyId = 3 }, UserID = 3, UserName="antrr", Password="antrr", Name = "Rune Riskedal", Address="Vet ikke hvor han bor", Email="rune@antenor.no"},
                                    new User { company = new Company{ companyId = 4 }, UserID = 4, UserName="antmm", Password="antmm", Name = "Marianne Martins", Address="Der hun bor", Email="marianne@antenor.no"} };
        }

        //Linq for returning specific user
        public IEnumerable<User> GetDummyUser(string UserName, string PassWord)
        {
            return from u in DummyUsers() where u.UserName == UserName && u.Password == PassWord select u;
        }
    }
    public class User
    {
        public Company company { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}