using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace Diplom
{
    class Copyrighter

    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        public string name { get { return name; } set { name=value; } }
        public string Public_Key { get; set; }
        public string Secret_Key { get; set; }
        public int bill { get; set; }
        private List<Publication> PublicationList = new List<Publication>();
        public RsaEncryption rsa;

        public Copyrighter(string Name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * from Author_List where Author ={Name}", connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            this.name = dataSet.Tables[0].Columns["Author"].ToString();
            this.bill = Int32.Parse(dataSet.Tables[0].Columns["bill"].ToString());
            this.Public_Key = dataSet.Tables[0].Columns["PublicKey"].ToString();
            this.Secret_Key = dataSet.Tables[0].Columns["SecretKey"].ToString();
            sqlDataAdapter = new SqlDataAdapter($"Select * from AuthorPublicationList where Author ={Name}", connection);
            sqlDataAdapter.Fill(dataSet);
            Publication Pub;
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Pub = new Publication(row["Title"].ToString(), this.Public_Key, Int32.Parse(row["Cost"].ToString()));
                this.PublicationList.Add(Pub);
            }
            connection.Close();
            /*
            rsa = new RsaEncryption();
            Public_Key = rsa.GetPublicKey();
            Secret_Key = rsa.GetPrivateKey();
            */


        }



        public void NewPublication(string title, float cost)
        {
            Publication publication = new Publication(title, this.Public_Key, cost);
            string ask = String.Format("insert into AuthorPublicationList values ('{0}','{1}',{2})", this.name, publication.Title, publication.Cost);
            this.PublicationList.Add(publication);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter;
            sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "AuthorPublicationList");
            connection.Close();
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
        public void saveDatabase(string password)
        {
            string ask = String.Format("insert into Author_List values ('{0}','{1}','{2}','{3}',{4})", this.name, password,this.Public_Key, this.Secret_Key,this.bill.ToString());
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter;
            sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "Author_List");
            connection.Close();
        }



    }
}
