
namespace EF_RevisitedMVC.Models
{
    public class Student
    {
        public int? StudentId { get; set; }
        public string StudentName { get; set;}
        public double Marks { get; set;}
        public string StudentAddress { get; set;}
        public string StudentEmail { get; set;}
        public int StudentPhone { get; set;}

        internal object FindAsync(int? studentId)
        {
            throw new NotImplementedException();
        }
    }
}
