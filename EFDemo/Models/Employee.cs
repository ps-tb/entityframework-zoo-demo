namespace EFDemo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int AnnualSalary { get; set; }

        public bool Active { get; set; }

        public Zoo Zoo { get; set; }

        public int ZooId { get; set; }
    }
}