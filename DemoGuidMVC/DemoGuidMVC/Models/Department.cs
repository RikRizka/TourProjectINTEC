namespace DemoGuidMVC.Models
{
    public class Department
    {
        //di kleas department bisa banyak Employ
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Employ> Employes { get; set; }
    }
}
