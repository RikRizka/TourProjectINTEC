namespace DemoGuidMVC.Models
{
    public class Employ
    {
        //Di kelas Employ ganya ada 1 department
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; } //one to many
    }
}
