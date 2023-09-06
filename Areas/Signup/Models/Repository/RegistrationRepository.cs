using iTS_ApartBillingCheckList.Areas.InterfaceCollection;
using iTS_ApartBillingCheckList.Areas.Signup.Data;

namespace iTS_ApartBillingCheckList.Areas.Signup.Models.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDbContext _db;

        public RegistrationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Registration entity)
        {
            
            throw new NotImplementedException();
        }

        public bool Delete(Registration entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Registration> FindAll()
        {
            throw new NotImplementedException();
        }

        public Registration FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Registration entity)
        {
            throw new NotImplementedException();
        }
    }
}
