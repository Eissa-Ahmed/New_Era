namespace New_Era.Infrastructure.Repository.IRepository
{
    public interface IStudentRepo : IGenericRepo<StudentModel>
    {
        public Task<IEnumerable<StudentModel>> GetAllAsync();
        public Task<StudentModel> GetByIdWithIncludeAsync(int id);
    }
}
