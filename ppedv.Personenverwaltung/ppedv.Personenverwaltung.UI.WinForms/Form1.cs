using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using ppedv.Personenverwaltung.Contracts;
using ppedv.Personenverwaltung.Data.EfCore;
using ppedv.Personenverwaltung.DemoDataSource;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

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

            context = new EfContext();
            context.Database.EnsureCreated();

            //bindingSource1.DataSource = personenSource.GetPersons();
            bindingSource1.DataSource = context.Persons.ToList();
            dataGridView1.DataSource = bindingSource1;

            vornameTextBox.DataBindings.Add("Text", bindingSource1, nameof(Person.Vorname), false, DataSourceUpdateMode.OnPropertyChanged);
            nachnameTextBox.DataBindings.Add("Text", bindingSource1, nameof(Person.Nachname), false, DataSourceUpdateMode.OnPropertyChanged);
            stadtTextBox.DataBindings.Add("Text", bindingSource1, nameof(Person.Stadt), false, DataSourceUpdateMode.OnPropertyChanged);
            gebDateTimePicker.DataBindings.Add("Value", bindingSource1, nameof(Person.GebDatum), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        EfContext context;
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
                MessageBox.Show(p.Nachname + " " + p.GebDatum.GetKw());
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

        private void button7_Click(object sender, EventArgs e)
        {
            //earger loading
            //bindingSource1.DataSource = context.Persons.Include(x => x.Land).ToList();
            bindingSource1.DataSource = context.Persons.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var person = new Person()
            {
                Vorname = "NEU",
                Nachname = "NEU",
                GebDatum = DateTime.Now.Date,
                Stadt = "NEU"
            };

            bindingSource1.Add(person);
            context.Add(person);

            context.SaveChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var rowCount = context.SaveChanges();

            Program.Log.Information("SaveChanges {rowCount}", rowCount);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Person p)
            {
                var msg = $"Soll die Person {p.Nachname} wirklich gelöscht werden?";
                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    == DialogResult.Yes)
                {
                    context.Remove(p);
                    bindingSource1.Remove(p);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            context.AddRange(new DemoDataGenerator().GetPersons());
            context.SaveChanges();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var query = from p in context.Persons
                        where p.GebDatum.Year < 2000
                        orderby p.GebDatum.Year descending, p.Nachname
                        select p;

            bindingSource1.DataSource = query.ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = context.Persons.Where(x => x.GebDatum.Year < 2000)
                                                       .OrderByDescending(x => x.Land.Name)
                                                       .ThenBy(x => x.Nachname)
                                                       .ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == nameof(Person.Land))
            {
                if (e.Value is Land l)
                {
                    e.Value = l.Name;
                }
            }
        }
    }
}
