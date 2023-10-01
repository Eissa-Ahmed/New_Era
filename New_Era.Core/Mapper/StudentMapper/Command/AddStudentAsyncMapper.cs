using New_Era.Core.Features.StudentFeature.Command.Model;

namespace New_Era.Core.Mapper.StudentMapper
{
    public partial class StudentProfile
    {
        public void AddStudentAsyncMapper()
        {
            CreateMap<AddStudentAsyncCommand, StudentModel>();
        }
    }
}
