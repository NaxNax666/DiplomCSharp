using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Diplom
{
    public class User
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        public string name { get { return name; } set { name = value; } }
        public string Public_Key { get; set; }
        public string Secret_Key { get; set; }
        public float bill { get; set; }
        public List<Publication> PurchasingPublicatonsList = new List<Publication>();
        public RsaEncryption rsa;

        public User(string Name)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * from User_list where [User] ={Name}", connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            this.name = dataSet.Tables[0].Columns["User"].ToString();
            this.bill = Int32.Parse(dataSet.Tables[0].Columns["bill"].ToString());
            this.Public_Key = dataSet.Tables[0].Columns["PublicKey"].ToString();
            this.Secret_Key = dataSet.Tables[0].Columns["SecretKey"].ToString();
            sqlDataAdapter = new SqlDataAdapter($"Select * from UserPublicationList where Author ={Name}", connection);
            sqlDataAdapter.Fill(dataSet);
            Publication Pub;
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Pub = new Publication(row["Title"].ToString(), this.Secret_Key, Int32.Parse(row["Cost"].ToString()));
                this.PurchasingPublicatonsList.Add(Pub);
            }
            connection.Close();
        }


        public void AddPublication(Publication title)
        {
            string ask = String.Format("insert into UserPublicationList values ('{0}','{1}',{2})", this.name, title.Title, title.Cost);
            PurchasingPublicatonsList.Add(title);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter;
            sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "UserPublicationList");
            connection.Close();
        }
        public string ShowPurchasingList()
        {
            string ret = "";
            int i = 1;
            foreach (Publication Pub in this.PurchasingPublicatonsList)
            {
                ret = ret + Pub.Title + ". " + Pub + "\n";
            }
            return ret;

        }

        public void saveDatabase(string password)
        {
            string ask = String.Format("insert into User_List values ('{0}','{1}','{2}','{3}',{4})", this.name, password, this.Public_Key, this.Secret_Key, this.bill.ToString());
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter;
            sqlDataAdapter = new SqlDataAdapter(ask, connection);
            sqlDataAdapter.Fill(dataSet, "User_List");
            connection.Close();
        }


    }
}
