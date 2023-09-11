using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace BooksApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.DataBindings.Add("Text", textBox2, "Text", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.DataBindings.Add("BackColor", textBox2, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var url = "https://www.googleapis.com/books/v1/volumes?q=winforms";

            var http = new HttpClient();
            var json = await http.GetStringAsync(url);

            BooksResult result = System.Text.Json.JsonSerializer.Deserialize<BooksResult>(json);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = result.items.Select(x => x.volumeInfo).ToList();
        }
    }
}
