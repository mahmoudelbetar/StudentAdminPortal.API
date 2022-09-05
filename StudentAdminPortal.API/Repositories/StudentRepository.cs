using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.Models;

namespace StudentAdminPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await db.Student.Include(u => u.Gender).Include(u => u.Address).ToListAsync();
        }
    }
}
