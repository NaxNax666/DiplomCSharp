using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom
{
    class User
    {
        public string name { get { return name; } set { name = value; } }
        public string Public_Key { get; set; }
        private string Secret_Key { get; set; }
        public float bill { get; set; }
        public List<Publication> PurchasingPublicatonsList = new List<Publication>();

        public User(string Name, float Bill, string PubK)
        {
            this.name = Name;
            this.bill = Bill;
            this.Public_Key = PubK;

        }

        public bool Auth(string Name, string password)
        {
            RsaEncryption rsa = new RsaEncryption();
            this.Secret_Key = rsa.Encrypt(this.Public_Key);
            return (password == rsa.Decrypt(this.Secret_Key)) && (Name == this.name);
        }

        public void AddPublication(Publication title)
        {
            PurchasingPublicatonsList.Add(title);
        }


    }
}
