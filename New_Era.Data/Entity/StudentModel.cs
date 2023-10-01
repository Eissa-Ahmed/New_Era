namespace New_Era.Data.Entity
{
    public class StudentModel : LocalizationModel
    {
        public StudentModel()
        {
            StudentSubjectModel = new HashSet<StudentSubjectModel>();
        }
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        public IEnumerable<StudentSubjectModel> StudentSubjectModel { get; set; }
        public DepartmentModel department { get; set; }

    }
}
