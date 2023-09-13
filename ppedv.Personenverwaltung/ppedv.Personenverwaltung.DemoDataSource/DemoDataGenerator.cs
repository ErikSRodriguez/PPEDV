using Bogus;
using ppedv.Personenverwaltung.Contracts;

namespace ppedv.Personenverwaltung.DemoDataSource
{
    public class DemoDataGenerator : IPersonenSource
    {
        Faker<Contracts.Person> personFaker;
        int idCount;

        public DemoDataGenerator()
        {
            var landFaker = new Faker<Contracts.Land>()
              .RuleFor(x => x.Name, x => x.Address.Country());

            var länds = landFaker.Generate(10);

            personFaker = new Faker<Contracts.Person>("de")
            .UseSeed(7)
            //.CustomInstantiator(x => new Contracts.Person() { Id = idCount++ })
            .RuleFor(x => x.Vorname, x => x.Person.FirstName)
            .RuleFor(x => x.Nachname, x => x.Person.LastName)
            .RuleFor(x => x.Stadt, x => x.Address.City())
            .RuleFor(x => x.Land, x => x.PickRandom(länds))
            .RuleFor(x => x.GebDatum, x => x.Date.Past(35));
        }

        public IEnumerable<Contracts.Person> GetPersons()
        {
            return personFaker.Generate(100);
        }
    }
}
