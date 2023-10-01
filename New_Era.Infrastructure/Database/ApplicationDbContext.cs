namespace New_Era.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<StudentModel> students { get; set; }
        public DbSet<SubjectModel> subjects { get; set; }
        public DbSet<DepartmentModel> departments { get; set; }
        public DbSet<StudentSubjectModel> studentSubjects { get; set; }
        public DbSet<DepartmentSubjectModel> departmentSubjects { get; set; }
    }
}
