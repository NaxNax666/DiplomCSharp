using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;

namespace Diplom
{
    public class Publication
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        public string Title { get { return Title; } set { Title = value; } }
       private string Watermark { get; set; }
        public int Cost;
       public Publication(string title, string Authsign, float cost)
        {
            this.Title = title;
            byte[] source;
            SHA512 shaM = new SHA512Managed();
            source = shaM.ComputeHash(Encoding.UTF8.GetBytes(Authsign));

            var sBuilder = new StringBuilder();
            for (int i = 0; i < source.Length; i++)
            {
                sBuilder.Append(source[i].ToString("x2"));
            }
            this.Watermark = sBuilder.ToString();
            this.Cost = cost;

        }

       public string GetWatermark()
        {
            return this.Watermark;
        }
    }
}
