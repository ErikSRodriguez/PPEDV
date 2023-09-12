using ppedv.Personenverwaltung.Contracts;

namespace ppedv.Personenverwaltung.DemoDataSource
{
    public class DemoDataGenerator : IPersonenSource
    {
        public IEnumerable<Person> GetPersons()
        {
            yield return new Person() { Vorname = "Fred", Nachname = "Feuerstein", Stadt = "Steinhausen" , GebDatum = DateTime.Now };
            yield return new Person() { Vorname = "Wilma", Nachname = "Feuerstein", Stadt = "Steinhausen", GebDatum = DateTime.Now };
        }
    }
}
