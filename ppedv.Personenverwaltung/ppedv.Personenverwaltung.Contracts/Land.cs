namespace ppedv.Personenverwaltung.Contracts
{
    public class Land
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Person> Personen { get; set; } = new HashSet<Person>();
    }
}
