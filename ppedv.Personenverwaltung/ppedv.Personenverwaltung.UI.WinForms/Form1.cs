using ClosedXML.Excel;
using ppedv.Personenverwaltung.Contracts;
using ppedv.Personenverwaltung.DemoDataSource;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ppedv.Personenverwaltung.UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            splitContainer1.SplitterDistance = 1000;

            personenSource = new DemoDataGenerator();
            //var pfad = @"C:\Users\Fred\source\repos\CSharpFortgeschrittene_228438\ppedv.Personenverwaltung\ppedv.Personenverwaltung.DemoDataSource\bin\Debug\net7.0\ppedv.Personenverwaltung.DemoDataSource.dll";
            //var ass = Assembly.LoadFrom(pfad);
            //var typeMitISource = ass.GetTypes().First(x => x.GetInterfaces().Contains(typeof(IPersonenSource)));
            //personenSource = Activator.CreateInstance(typeMitISource) as IPersonenSource;

            bindingSource1.DataSource = personenSource.GetPersons();
            dataGridView1.DataSource = bindingSource1;

            vornameTextBox.DataBindings.Add("Text", bindingSource1, nameof(Person.Vorname), false, DataSourceUpdateMode.OnPropertyChanged);
            nachnameTextBox.DataBindings.Add("Text", bindingSource1, nameof(Person.Nachname), false, DataSourceUpdateMode.OnPropertyChanged);
            stadtTextBox.DataBindings.Add("Text", bindingSource1, nameof(Person.Stadt), false, DataSourceUpdateMode.OnPropertyChanged);
            gebDateTimePicker.DataBindings.Add("Value", bindingSource1, nameof(Person.GebDatum), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        IPersonenSource personenSource;

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = personenSource.GetPersons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bindingSource1.Current is Person p)
            {
                MessageBox.Show(p.Nachname);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = "Personen als XML Speichern",
                Filter = "XML-Datei|*.xml|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using var sw = new StreamWriter(dlg.FileName);
                var serial = new XmlSerializer(typeof(List<Person>));
                serial.Serialize(sw, bindingSource1.DataSource);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Title = "Personen XML-Datei",
                Filter = "XML-Datei|*.xml|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using var sr = new StreamReader(dlg.FileName);
                var serial = new XmlSerializer(typeof(List<Person>));
                bindingSource1.DataSource = serial.Deserialize(sr);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = "Personen als JSON Speichern",
                Filter = "JSON-Datei|*.json|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, JsonSerializer.Serialize(bindingSource1.DataSource));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Title = "Personen JSON-Datei",
                Filter = "JSON-Datei|*.json|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bindingSource1.DataSource = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(dlg.FileName));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog()
            {
                Title = "Personen als Excel Speichern",
                Filter = "xlsx-Datei|*.xlsx|Alle Dateien|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.AddWorksheet("Personen");

                    ws.Cell(1, 1).Value = nameof(Person.Vorname);
                    ws.Cell(1, 2).Value = nameof(Person.Nachname);
                    ws.Cell(1, 3).Value = nameof(Person.Stadt);
                    ws.Cell(1, 4).Value = nameof(Person.GebDatum);
                    ws.Cells("A1:D1").Style.Font.Bold = true;

                    int row = 2;
                    foreach (var item in bindingSource1.Cast<Person>())
                    {
                        ws.Cell(row, 1).Value = item.Vorname;
                        ws.Cell(row, 2).Value = item.Nachname;
                        ws.Cell(row, 3).Value = item.Stadt;
                        ws.Cell(row, 4).Value = item.GebDatum;
                        row++;
                    }

                    wb.SaveAs(dlg.FileName);
                }
                //System.Diagnostics.Process.Start(dlg.FileName);
            }
        }
    }
}
