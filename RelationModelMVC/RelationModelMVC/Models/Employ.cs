namespace RelationModelMVC.Models
{
    public class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; } //one to many
    }
}
