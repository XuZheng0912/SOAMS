using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateOwnedAssetsManagementSystem.Class.Entity
{
    class University
    {
        private string name;
        private string abbreviation;
        private string identifier;
        private string adminPhoneNumber;
        private string address;
        private string postalCode;

        public University(string name, string abbreviation, string identifier, string adminPhoneNumber, string address, string postalCode)
        {
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.Identifier = identifier;
            this.AdminPhoneNumber = adminPhoneNumber;
            this.Address = address;
            this.PostalCode = postalCode;
        }

        public string Name { get => name; set => name = value; }
        public string Abbreviation { get => abbreviation; set => abbreviation = value; }
        public string Identifier { get => identifier; set => identifier = value; }
        public string AdminPhoneNumber { get => adminPhoneNumber; set => adminPhoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
    }
}
