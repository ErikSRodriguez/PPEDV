namespace ppedv.Personenverwaltung.Contracts
{
    public class Person
    {
        public int Id { get; set; }
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public DateTime GebDatum { get; set; }
        public string? Stadt { get; set; }
    }
}
