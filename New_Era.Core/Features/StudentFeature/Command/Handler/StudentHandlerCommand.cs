using New_Era.Core.Features.StudentFeature.Command.Model;

namespace New_Era.Core.Features.StudentFeature.Command.Handler
{
    public class StudentHandlerCommand : ResponseHandler,
        IRequestHandler<AddStudentAsyncCommand, ResponseModel<string>>,
        IRequestHandler<DeleteStudentAsyncCommand, ResponseModel<string>>,
        IRequestHandler<UpdateStudentAsyncCommand, ResponseModel<string>>
    {
        private readonly IStudentServices studentServices;
        private readonly IMapper mapper;
        private readonly IStringLocalizer<Lang> localizer;
        public StudentHandlerCommand(IStringLocalizer<Lang> localizer, IStudentServices studentServices, IMapper mapper) : base(localizer)
        {
            this.studentServices = studentServices;
            this.mapper = mapper;
            this.localizer = localizer;
        }
        public async Task<ResponseModel<string>> Handle(AddStudentAsyncCommand request, CancellationToken cancellationToken)
        {
            /*if (studentServices.GetAllAsyncAsQuerable().Where(i => i.Id.Equals(request.Id)) is null) return BadRequest<string>(localizer[LanguageKeys.IdNotFount]);*/

            var student = mapper.Map<StudentModel>(request);
            await studentServices.AddStudentAsync(student);
            return Success(data: "", message: localizer[LanguageKeys.AddAsync]);
        }

        public async Task<ResponseModel<string>> Handle(DeleteStudentAsyncCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<string>> Handle(UpdateStudentAsyncCommand request, CancellationToken cancellationToken)
        {
            var checkStudent = studentServices.GetAllAsyncAsQuerable().Where(i => i.Id.Equals(request.Id)).FirstOrDefault();
            if (checkStudent is null) return BadRequest<string>(localizer[LanguageKeys.IdNotFount]);
            if (studentServices.GetAllAsyncAsQuerable().Where(i => i.Phone.Equals(request.Phone) && !i.Phone.Equals(checkStudent.Phone) && !string.IsNullOrEmpty(i.Phone)).FirstOrDefault() != null) return BadRequest<string>(localizer[LanguageKeys.PhoneIsExist]);

            var student = mapper.Map<StudentModel>(request);
            await studentServices.UpdateStudent(student);
            return Success(data: "", message: localizer[LanguageKeys.UpdateAsync]);
        }
    }
}
