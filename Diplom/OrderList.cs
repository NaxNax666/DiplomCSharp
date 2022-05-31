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
    public partial class OrderList : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        private ContractPublish contract;
        private string UserName;

        public OrderList(string UserName)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string title="";
            contract = new ContractPublish(new Copyrighter(orderBox.SelectedItem.ToString()), new User(UserName), title);

        }
    }
}
