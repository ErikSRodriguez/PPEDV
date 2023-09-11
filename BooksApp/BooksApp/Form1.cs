using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
