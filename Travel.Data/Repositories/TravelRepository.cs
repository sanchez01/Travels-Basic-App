

using Travel.Data.Abstract;

namespace Travel.Data.Repositories
{
    public class TravelRepository : Repository<Models.Registration.Travel>, ITravelRepository
    {
        public TravelRepository(IDataContext dataContext) : base(dataContext)
        {
        }
    }
}
