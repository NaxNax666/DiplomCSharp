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
    public partial class CopyrighterForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Diplom.Properties.Settings.Diplom_primaryConnectionString"].ConnectionString;
        private Copyrighter Copyrighter;
        public CopyrighterForm()
        {
            InitializeComponent();

        }
        public CopyrighterForm(string name)
        {
            InitializeComponent();
            List<string> title = new List<string>();
            List<float> cost = new List<float>();
            string PubK;
            float bill;
            Copyrighter = new Copyrighter(name, bill);
            for(int i=0; i<title.Count; i++)
            {
                Copyrighter.NewPublication(title[i], cost[i]);
            }

            LName.Text = name;
            if (false)
            {

            }
        }

        private void ShowPublButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Copyrighter.ShowPublicationList();
        }
    }
}
