namespace New_Era.Core.Features.StudentFeature.Query.Model
{
    public class GetByIdAsyncStudentQuery : IRequest<ResponseModel<GetAsyncStudentResponse>>
    {
        public GetByIdAsyncStudentQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
