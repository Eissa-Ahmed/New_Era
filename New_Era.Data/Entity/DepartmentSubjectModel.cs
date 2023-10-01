namespace New_Era.Data.Entity
{
    public class DepartmentSubjectModel
    {
        public int Id { get; set; }
        [ForeignKey("departments")]
        public int DepartmentId { get; set; }
        [ForeignKey("subjects")]
        public int SubjectId { get; set; }
        public DepartmentModel departments { get; set; }
        public SubjectModel subjects { get; set; }
    }
}
