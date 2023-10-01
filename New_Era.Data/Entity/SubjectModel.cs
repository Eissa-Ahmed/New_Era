
namespace New_Era.Data.Entity
{
    public class SubjectModel : LocalizationModel
    {
        public SubjectModel()
        {
            StudentSubject = new HashSet<StudentSubjectModel>();
            departmentSubject = new HashSet<DepartmentSubjectModel>();
        }
        public int Id { get; set; }
        public IEnumerable<StudentSubjectModel> StudentSubject { get; set; }
        public IEnumerable<DepartmentSubjectModel> departmentSubject { get; set; }
    }
}
