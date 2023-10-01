namespace New_Era.Core.Features.StudentFeature.Command.Model
{
    public class AddStudentAsyncCommand : IRequest<ResponseModel<string>>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int DepartmentId { get; set; }

    }
}
