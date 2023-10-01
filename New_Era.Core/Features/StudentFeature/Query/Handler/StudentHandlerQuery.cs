namespace New_Era.Core.Features.StudentFeature.Query.Handler
{
    public class StudentHandlerQuery : ResponseHandler,
        IRequestHandler<GetAllAsyncStudentQuery, ResponseModel<PaginationModel<IEnumerable<GetAsyncStudentResponse>>>>,
        IRequestHandler<GetByIdAsyncStudentQuery, ResponseModel<GetAsyncStudentResponse>>
    {
        private readonly IStudentServices studentServices;
        private readonly IMapper mapper;
        private readonly IStringLocalizer<Lang> localizer;
        public StudentHandlerQuery(IStringLocalizer<Lang> localizer, IMapper mapper, IStudentServices studentServices) : base(localizer)
        {
            this.studentServices = studentServices;
            this.mapper = mapper;
            this.localizer = localizer;
        }
        public async Task<ResponseModel<PaginationModel<IEnumerable<GetAsyncStudentResponse>>>> Handle(GetAllAsyncStudentQuery request, CancellationToken cancellationToken)
        {
            var studentModel = await studentServices.GetAllAsync(page: request.Page, ItemForPage: request.ItemForPage);
            var result = new PaginationModel<IEnumerable<GetAsyncStudentResponse>>
            {
                Data = mapper.Map<IEnumerable<GetAsyncStudentResponse>>(studentModel),
                ItemForPage = request.ItemForPage,
                Page = request.Page,
                success = true,
                TotalItems = studentServices.GetAllAsyncAsQuerable().Count()
            };
            return Success(result);
        }

        public async Task<ResponseModel<GetAsyncStudentResponse>> Handle(GetByIdAsyncStudentQuery request, CancellationToken cancellationToken)
        {
            var item = await studentServices.GetByIdWithIncludeAsync(request.Id);
            if (item is null) return BadRequest<GetAsyncStudentResponse>(localizer[LanguageKeys.IdNotFount]);

            var result = mapper.Map<GetAsyncStudentResponse>(item);
            return Success(result);
        }
    }
}
