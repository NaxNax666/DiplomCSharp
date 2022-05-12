using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom
{
    class Copyrighter
    {
        public string name { get { return name; } set { name=value; } }
        public string Public_Key { get; set; }
        private string Secret_Key { get; set; }
        public float bill { get; set; }
        private List<Publication> PublicationList = new List<Publication>();

        public Copyrighter(string Name, float Bill, string PubK)
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

        public void NewPublication(string title, float cost)
        {
            Publication publication = new Publication(title, this.Public_Key, cost);
            this.PublicationList.Add(publication);
        }

        public string ShowPublicationList()
        {
            string ret = "";
            int i = 1;
            foreach(Publication Pub in this.PublicationList)
            {
                ret = ret + Pub.Title + ". " + Pub + "\n";
            }
            return ret;
           
        }
        
        public Publication GetPublicationByTitle(string title)
        {
            foreach (Publication Pub in this.PublicationList)
            {
                if (title == Pub.Title)
                {
                    return Pub;
                }
            }
            return null;
        }



    }
}
