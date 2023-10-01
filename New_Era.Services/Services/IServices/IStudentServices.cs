namespace New_Era.Services.Services.IServices
{
    public interface IStudentServices
    {
        public Task<IEnumerable<StudentModel>> GetAllAsync(int page, int ItemForPage);
        public IEnumerable<StudentModel> GetAllAsyncAsQuerable();
        public Task<StudentModel> GetByIdWithIncludeAsync(int id);
    }
}
