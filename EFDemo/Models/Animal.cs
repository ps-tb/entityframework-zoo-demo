namespace EFDemo.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public string Name { get; set; }

        public string Order { get; set; }

        public string Genus { get; set; }

        public string Family { get; set; }

        public string Species { get; set; }

        public Zoo Zoo { get; set; }

        public int ZooId { get; set; }
    }
}