using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Diplom
{
    public partial class AuthForm : Form

    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select Author, Password from Author_List where Author ={login} and Password = {password}", connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);


            if (dataSet.Tables[0].Rows.Count == 1)
            {
                CopyrighterForm copyrighterForm = new CopyrighterForm(login);
                copyrighterForm.Show();
                connection.Close();
            }
            else
            {
                sqlDataAdapter = new SqlDataAdapter($"Select User, Password from User_List where User ={login} and Password = {password}", connection);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    UserForm userForm = new UserForm(login);
                    userForm.Show();
                    connection.Close();
                }
                else { MessageBox.Show("Неверный логин или Пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
