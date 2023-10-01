namespace New_Era.Data.Entity
{
    public class DepartmentModel : LocalizationModel
    {
        public DepartmentModel()
        {
            students = new HashSet<StudentModel>();
            departmentSubject = new HashSet<DepartmentSubjectModel>();
        }
        public int Id { get; set; }
        public IEnumerable<StudentModel> students { get; set; }
        public IEnumerable<DepartmentSubjectModel> departmentSubject { get; set; }
    }
}
