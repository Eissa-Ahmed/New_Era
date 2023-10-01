namespace New_Era.Core.Features.StudentFeature.Query.Model
{
    public class GetAllAsyncStudentQuery : IRequest<ResponseModel<PaginationModel<IEnumerable<GetAsyncStudentResponse>>>>
    {
        public GetAllAsyncStudentQuery(int? Page = null, int? ItemForPage = null)
        {
            this.Page = Page == null ? 1 : (int)Page;
            this.ItemForPage = ItemForPage == null ? 5 : (int)ItemForPage;
        }
        public int Page { get; set; }
        public int ItemForPage { get; set; }
    }
}
