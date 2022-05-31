using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Diplom
{
    public partial class UserForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        User User;
        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(string name)
        {
            InitializeComponent();
            List<Publication> title = new List<Publication>();
            string PubK;
            float bill;
            User= new User(name, bill);
            for (int i = 0; i < title.Count; i++)
            {
                User.AddPublication(title[i]);
            }

            LName.Text = name;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            User.ShowPurchasingList();
        }

        private void Purchase_Button_Click(object sender, EventArgs e)
        {
            UserPurchasingForm userPurchasingForm = new UserPurchasingForm(User);
            userPurchasingForm.Show();
        }
    }
}
