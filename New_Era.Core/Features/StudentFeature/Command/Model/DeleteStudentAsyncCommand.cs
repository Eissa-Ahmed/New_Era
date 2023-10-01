namespace New_Era.Core.Features.StudentFeature.Command.Model
{
    public class DeleteStudentAsyncCommand : IRequest<ResponseModel<string>>
    {
        public DeleteStudentAsyncCommand(int id)
        {
            Id = Id;
        }
        public int Id { get; set; }
    }
}
