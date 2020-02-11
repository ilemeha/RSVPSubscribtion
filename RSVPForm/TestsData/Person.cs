using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSVPForm.TestsData
{
    public class Person
    {
        public Person()
        {
            SeedRandomData();
        }
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public string CompanyName;


        public void SeedRandomData()
        {
            var faker = new Faker();


            this.FirstName = faker.Name.FirstName();
            this.LastName = faker.Name.LastName();
            this.Email = faker.Internet.Email();
            this.PhoneNumber = faker.Phone.PhoneNumber();
            this.CompanyName = faker.Company.CompanyName();
        }
    }
}
