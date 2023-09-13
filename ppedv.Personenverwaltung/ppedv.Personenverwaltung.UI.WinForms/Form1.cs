using ppedv.Personenverwaltung.Contracts;
using ppedv.Personenverwaltung.DemoDataSource;

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
            if(bindingSource1.Current is Person p)
            {
                MessageBox.Show(p.Nachname);
            }

        }
    }
}
