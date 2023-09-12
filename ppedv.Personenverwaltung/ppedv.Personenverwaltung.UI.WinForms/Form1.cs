using ppedv.Personenverwaltung.Contracts;
using System.Reflection;

namespace ppedv.Personenverwaltung.UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //personenSource = new DemoDataGenerator();
            var pfad = @"C:\Users\Fred\source\repos\CSharpFortgeschrittene_228438\ppedv.Personenverwaltung\ppedv.Personenverwaltung.DemoDataSource\bin\Debug\net7.0\ppedv.Personenverwaltung.DemoDataSource.dll";
            var ass = Assembly.LoadFrom(pfad);
            var typeMitISource = ass.GetTypes().First(x => x.GetInterfaces().Contains(typeof(IPersonenSource)));
            personenSource = Activator.CreateInstance(typeMitISource) as IPersonenSource;
        }

        IPersonenSource personenSource;

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personenSource.GetPersons().ToList();
        }
    }
}
