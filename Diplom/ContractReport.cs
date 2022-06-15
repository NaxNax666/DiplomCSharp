using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace Diplom
{
    internal class ContractReport
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        private float buffBill;
        private Copyrighter copyrighter;
        private User user;
        private string Contract_id;
        public ContractReport(Copyrighter cp, User ur, string title)
        {
            this.copyrighter = cp;
            this.user = ur;
            Publication pub = copyrighter.GetPublicationByTitle(title);
            if (pub != null)
            {
                if ((pub.Cost) <= user.bill)
                {
                    user.bill -= (pub.Cost);
                    buffBill = pub.Cost;
                    copyrighter.bill += pub.Cost;
                    byte[] source;
                    SHA512 shaM = new SHA512Managed();
                    source = shaM.ComputeHash(Encoding.UTF8.GetBytes(String.Concat(copyrighter.Public_Key, user.Public_Key)));

                    var sBuilder = new StringBuilder();
                    for (int i = 0; i < source.Length; i++)
                    {
                        sBuilder.Append(source[i].ToString("x2"));
                    }
                    this.Contract_id = sBuilder.ToString();
                }
                else
                {
                    //TODO ошибка не хватает средств
                }

            }
            else
            {
                //TODO ошибка нет публикации
            }


        }

        public void ContractSucsses()
        {

        }

    }
}
