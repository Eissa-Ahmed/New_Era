﻿using Microsoft.EntityFrameworkCore;

namespace New_Era.Services.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepo studentRepo;

        public StudentServices(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public async Task AddStudentAsync(StudentModel model)
        {
            await studentRepo.AddAsync(model);
        }

        /*        public async Task<bool> CheckPhone(string Phone)
                {
                    await studentRepo.GetTableNoTracking().Where
                }*/

        public async Task DeleteStudent(int id)
        {
            await studentRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<StudentModel>> GetAllAsync(int page, int ItemForPage)
        {

            var items = await studentRepo.GetTableNoTracking().Skip((page - 1) * ItemForPage).Take(ItemForPage).Include(i => i.department).ToListAsync();
            return items;
        }

        public IEnumerable<StudentModel> GetAllAsyncAsQuerable()
        {
            return studentRepo.GetTableNoTracking();
        }

        public async Task<StudentModel> GetByIdWithIncludeAsync(int id)
        {
            return await studentRepo.GetByIdWithIncludeAsync(id);
        }

        public async Task UpdateStudent(StudentModel model)
        {
            await studentRepo.UpdateAsync(model);
        }
    }
}
