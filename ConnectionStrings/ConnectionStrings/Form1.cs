using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionStringsTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            showConStringButton.Click += (s, e) => ShowConStrings();
            getConStringByNameButton.Click += (s, e) => GetConStringByName(conStringNamesComboBox.Text);


            ShowConStrings();

        }

        private void GetConStringByName(string text)
        {
            conStringByNameResultTextBox.Text = ConfigurationManager.ConnectionStrings[text].ConnectionString;
        }

        private void ShowConStrings()
        {
            List<ConnectionStringSettings> conStringList = ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>().ToList();
            dataGridView1.DataSource = conStringList;
            conStringNamesComboBox.DataSource = conStringList.Select(x => x.Name).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationManager.ConnectionStrings.CurrentConfiguration.Save();
        }

        private void saveConStringByNameButton_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


            config.ConnectionStrings.ConnectionStrings[conStringNamesComboBox.Text].ConnectionString = conStringByNameResultTextBox.Text;
            config.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            config.Save();
        }
    }
}
