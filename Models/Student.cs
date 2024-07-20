namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string? Department { get; set; }
        public decimal Price { get; set; }
        public string? City { get; set; }
    }
}
