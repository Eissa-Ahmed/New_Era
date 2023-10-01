
namespace New_Era.Core.Mapper.StudentMapper
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetAllAsyncMapper();
            AddStudentAsyncMapper();
            UpdateStudentAsyncMapper();
        }
    }
}
