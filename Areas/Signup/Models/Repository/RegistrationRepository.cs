using iTS_ApartBillingCheckList.Areas.InterfaceCollection;
using iTS_ApartBillingCheckList.Areas.Signup.Data;
using System.Threading.Tasks;

namespace iTS_ApartBillingCheckList.Areas.Signup.Models.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDbContext _db;

        public RegistrationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Add(Registration entity)
        {
            await _db.Registrations.AddAsync(entity);            
            Save();
        }

        public Task Delete(Registration entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Registration>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Registration> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Registration entity)
        {
            throw new NotImplementedException();
        }

        private void Save()
        {
            _db.SaveChanges();
        }
    }
}
