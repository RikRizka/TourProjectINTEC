using Microsoft.EntityFrameworkCore;
using MyTestAplicationMVCEnTity.Data;

namespace MyTestAplicationMVCEnTity.Models
{
    public class Pets
    {


        public int PetsId { get; set; }
        public string PetsName { get; set; }
        public string PetsDescription { get; set;}
        public string AnimalsGender { get; set; }

    }
}
