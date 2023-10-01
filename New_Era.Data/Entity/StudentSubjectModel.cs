namespace New_Era.Data.Entity
{
    public class StudentSubjectModel
    {
        public int Id { get; set; }
        [ForeignKey("students")]
        public int StudentId { get; set; }
        [ForeignKey("subjects")]
        public int SubjectId { get; set; }
        public StudentModel students { get; set; }
        public SubjectModel subjects { get; set; }

    }
}
