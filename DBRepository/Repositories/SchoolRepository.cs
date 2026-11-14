using DBRepository.Interfaces;

namespace DBRepository.Repositories
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly AppDbContext _appDbContext;
        public SchoolRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int AddSchool(School school)
        {
            _appDbContext.School.Add(school);
            return _appDbContext.SaveChanges();
        }
    }
}
