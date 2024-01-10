namespace StudentInfo.Model
{
    public class Student
    {

        public int StudentId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Course { get; set; }

        public bool? Sholarship { get; set; }

        public bool? Payer { get; set; }

        public DateTime? BornDate { get; set; }

        public string Sex { get; set; }

        public decimal GPA { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime DateStartStudy { get; set; }

        public DateTime? DateEndStudy { get; set; }

        public int GroupId { get; set; }

    }
}
