namespace New_Era.Services.Services.IServices
{
    public interface IStudentServices
    {
        public Task<IEnumerable<StudentModel>> GetAllAsync(int page, int ItemForPage);
        public IEnumerable<StudentModel> GetAllAsyncAsQuerable();
        public Task<StudentModel> GetByIdWithIncludeAsync(int id);
        public Task AddStudentAsync(StudentModel model);
        public Task DeleteStudent(int id);
        public Task UpdateStudent(StudentModel model);
        /*        public Task<bool> CheckPhone(string Phone);*/
    }
}
