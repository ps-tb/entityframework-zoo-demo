using System.Collections.Generic;

namespace EFDemo.Models
{
    public class Zoo
    {
        public int ZooId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public int YearFounded { get; set; }

        public int AnnualBudge { get; set; }

        public IEnumerable<Animal> Animals { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}