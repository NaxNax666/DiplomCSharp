using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Diplom
{
    public partial class UserPurchasingForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        public UserPurchasingForm()
        {
            InitializeComponent();
        }
        public UserPurchasingForm(User buyer)
        {
            InitializeComponent();
            BalanceLabel.Text = buyer.bill.ToString();
            SelectAuthor.Items.AddRange(new string[] { "Уругвай", "Эквадор" });//ЗАГЛУШКА ИСПРАВИТЬ
            ConfirmButton.Hide();
;
            CostLabel.Hide();
        }

        private void SelectAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTitle.Items.AddRange(new string[] { "Уругвай", "Эквадор" });//ЗАГЛУШКА ИСПРАВИТЬ
            
        }

        private void SelectTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostLabel.Show();
            CostLabel.Text = "Ваш выбор " + SelectAuthor.SelectedItem + "\n" + SelectTitle.SelectedItem + "\n" + "Вы хотите приобрести эту публикацию?";
            ConfirmButton.Show();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //Save request to DATABASE
        }
    }
}
