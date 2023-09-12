namespace ppedv.Personenverwaltung.Contracts
{
    public interface IPersonenSource
    {
        IEnumerable<Person> GetPersons();
    }
}
