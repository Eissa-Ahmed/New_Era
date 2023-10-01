namespace New_Era.Infrastructure.Repository
{
    public class StudentRepo : GenericRepo<StudentModel>, IStudentRepo
    {
        private readonly DbSet<StudentModel> dbContextStudent;
        public StudentRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            dbContextStudent = dbContext.Set<StudentModel>();
        }
        public async Task<IEnumerable<StudentModel>> GetAllAsync()
        {
            var data = await dbContextStudent.Include(i => i.department).ToListAsync();
            return data;
        }

        public async Task<StudentModel> GetByIdWithIncludeAsync(int id)
        {
            var data = await dbContextStudent.Where(i => i.Id.Equals(id)).Include(i => i.department).FirstOrDefaultAsync();
            return data;
        }
    }
}
