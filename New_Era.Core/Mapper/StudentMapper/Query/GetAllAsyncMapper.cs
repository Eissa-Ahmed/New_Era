namespace New_Era.Core.Mapper.StudentMapper
{
    public partial class StudentProfile
    {
        public void GetAllAsyncMapper()
        {

            CreateMap<StudentModel, GetAsyncStudentResponse>()
                .ForMember(des => des.DepartmentName, opt => opt.MapFrom(src => MethodsLanguage.IsArbic() == "ar" ? src.department.NameAr : src.department.NameEn))
                .ForMember(des => des.Name, opt => opt.MapFrom(src => MethodsLanguage.IsArbic() == "ar" ? src.NameAr : src.NameEn));
        }

    }
}
