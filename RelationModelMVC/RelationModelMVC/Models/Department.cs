namespace RelationModelMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employ> Employes { get; set; }
    }
}
